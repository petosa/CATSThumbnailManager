using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CATSThumbnailUploader
{
    public partial class Form1 : Form
    {
        //Global static variables
        public static String channel = "";
        public static List<Video> videos = new List<Video>();
        public static Dictionary<ListViewItem, String> lv1Hash =
            new Dictionary<ListViewItem, String>();
        public static Dictionary<ListViewItem, VideoContext> lv2Hash =
            new Dictionary<ListViewItem, VideoContext>();
        public static ListViewItem currentViewedImage = null;
        public static ListViewItem currentViewedVideo = null;
        public static List<ListViewItem> videoSearchable = new List<ListViewItem>();
        public static List<ListViewItem> imageSearchable = new List<ListViewItem>();

        public Form1()
        {
            //Load form
            InitializeComponent();
            //Adjust channel name label
            channelLabel.Text += channel;
            //Resize columns in listView2
            ListViewUtils.resizeColumns(listView2);
            //Populate listView2 with videos
            foreach(Video vid in videos)
            {
                //Add listviewitem to listview
                ListViewItem lvi = new ListViewItem(new[] {"", vid.name});
                listView2.Items.Add(lvi);

                //Create a new VideoContext
                VideoContext vc = new VideoContext();
                vc.name = vid.name;
                vc.url = vid.thumbnail.Url;
                vc.file = "";
                vc.loc = "";
                vc.id = vid.id;

                //Pair these objects
                lv2Hash.Add(lvi, vc);
                videoSearchable.Add(lvi);
            }
        }

        //Event: User checks an item on listView2
        private void listView2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //Get references
            ListViewItem thisItem = listView2.Items[e.Index];
            VideoContext vc = lv2Hash[thisItem];

            //Turn off all other checks first
            foreach (ListViewItem item in listView2.CheckedItems)
            {
                if (thisItem != item)
                {
                    item.Checked = false;
                }

            }

            //Make sure this check turns the item on
            if (!thisItem.Checked)
            {
                try
                {
                    //Load current thumbnail
                    currentThumbnailPicture.Load(vc.url);
                }
                catch
                {
                    MessageBox.Show("Problem getting thumbnail.");
                }
                //If there is a new thumbnail
                if(!vc.file.Equals(""))
                {
                    try
                    {
                        //Load the new thumbnail
                        newThumbnailPicture.Image = imageList1.Images[vc.loc];
                    }
                    catch
                    {
                        MessageBox.Show("Problem getting new thumbnail.");
                    }
                } else
                {
                    //Clear PictureBox
                    newThumbnailPicture.Image = null;
                }
                //Update reference
                currentViewedVideo = thisItem;
            } else
            {
                //Nullify references
                currentViewedVideo = null;
                newThumbnailPicture.Image = null;
                currentThumbnailPicture.Image = null;
            }
        }

        //Event: User checks an item in listView1
        private void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //Get reference
            ListViewItem thisItem = listView1.Items[e.Index];
            //Clear all checks first
            foreach (ListViewItem item in listView1.CheckedItems)
            {
                if (thisItem != item)
                {
                    item.Checked = false;
                }

            }
            //If check turned on
            if (!thisItem.Checked)
            {
                //Set reference
                currentViewedImage = thisItem;
            } else
            {
                //Null reference
                currentViewedImage = null;
            }

        }

        //Event: User clicks set button
        private void setButton_Click(object sender, EventArgs e)
        {
            //Reference check
            if(currentViewedVideo == null)
            {
                MessageBox.Show("Please check a video on the right.");
                return;
            }
            //Reference check
            if (currentViewedImage == null)
            {
                MessageBox.Show("Please check an image on the left.");
                return;
            }
            //Update new thumbnail
            String loc = lv1Hash[currentViewedImage];
            try
            {
                newThumbnailPicture.Image = imageList1.Images[loc];
            }
            catch
            {
                MessageBox.Show("Problem getting new thumbnail.");
            }
            //Get reference
            VideoContext vc = lv2Hash[currentViewedVideo];
            vc.file = currentViewedImage.Text;
            vc.loc = loc;
            //Set subitem for column display
            currentViewedVideo.SubItems[0].Text = ExplorerUtils.getFileName(loc);
        }

        //Event: user clicks columns header
        private void listView2_ColumnClick(object sender, ColumnClickEventArgs e)
        {
                //Set comparator
                this.listView2.ListViewItemSorter = new ListViewItemComparer(e.Column);
                // Call the sort method to manually sort.
                listView2.Sort();
        }

        //Event: user types something in the video search box
        private void videoSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            //Filter based on text
            ListViewUtils.searchFilter(false, listView2, videoSearchTextBox, videoSearchable, lv2Hash);
        }

        //Event: user types something in the image search box
        private void imageSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            //Filter based on text
            ListViewUtils.searchFilter(true, listView1, imageSearchTextBox, imageSearchable, null);
        }

        //Event: user clicks reset button
        private void resetButton_Click(object sender, EventArgs e)
        {
            //Error check
            if(currentViewedVideo == null)
            {
                MessageBox.Show("Please check a video on the right.");
                return;
            }
            //Set column text
            currentViewedVideo.SubItems[0].Text = "";
            //Clear image
            newThumbnailPicture.Image = null;
            //Reset video context
            lv2Hash[currentViewedVideo].file = "";
            lv2Hash[currentViewedVideo].loc = "";
        }

        //Event: User clicks Individual Image button
        private void oneImageButton_Click(object sender, EventArgs e)
        {
            //Freeze
            freeze(this, false);
            //Poupup
            DialogResult result = openFileDialog1.ShowDialog();
            //Selected files
            if (result == DialogResult.OK)
            {
                //For each image, add it to imageList1 and listView1
                foreach (String s in openFileDialog1.FileNames)
                {
                    imageList1.Images.Add(s, Image.FromFile(s));
                    ListViewItem lvi = new ListViewItem();
                    lvi.ImageKey = s;
                    lvi.Text = ExplorerUtils.getFileName(s);
                    listView1.Items.Add(lvi);
                    lv1Hash.Add(lvi, s);
                    imageSearchable.Add(lvi);
                }
            }
            //Unfreeze
            freeze(this, true);
        }

        //Event: User clicks Image Source Folder button
        private void imageFolderButton_Click(object sender, EventArgs e)
        {
            //Freeze
            freeze(this, false);
            //Popup
            DialogResult result = folderBrowserDialog1.ShowDialog();
            //Selected directory
            if (result == DialogResult.OK)
            {
                List<String> filteredFiles = ExplorerUtils.getAllImages(folderBrowserDialog1.SelectedPath);

                //For each image, add it to imageList1 and listView1
                foreach (String s in filteredFiles)
                {
                    imageList1.Images.Add(s, Image.FromFile(s));
                    ListViewItem lvi = new ListViewItem();
                    lvi.ImageKey = s;
                    lvi.Text = ExplorerUtils.getFileName(s);
                    listView1.Items.Add(lvi);
                    lv1Hash.Add(lvi, s);
                    imageSearchable.Add(lvi);
                }

            }
            //Unfreeze
            freeze(this, true);
        }

        //Event: user clicks publish button
        private void publishButton_Click(object sender, EventArgs e)
        {
            //Freeze
            freeze(this, false);
            List<ListViewItem> arr = new List<ListViewItem>();
            //Go through each listviewitem in the video list and filter based on whether they have a new thumbnail
            foreach (ListViewItem lvi in videoSearchable) {
                VideoContext vc = lv2Hash[lvi];
                if (vc.loc != "")
                {
                    arr.Add(lvi);
                }
            }
            //Go through each filtered listviewitem, save it locally, and upload thumbnail
            foreach (ListViewItem lvi in arr)
            {
                VideoContext vc = lv2Hash[lvi];
                Image im = Image.FromFile(vc.loc);
                Bitmap b = new Bitmap(im, new Size(1080, 720));
                Directory.CreateDirectory("thumbs");
                b.Save("thumbs\\" + vc.name + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                UploadThumbnail.run(vc.id, "thumbs\\" + vc.name + ".jpg");
            }
            //Unfreeze
            freeze(this, true);
            //Show message box
            MessageBox.Show("Done setting thumbnails. Your videos will take a few minutes to update. Changes do not propagate right away. Check again in 5 minutes to make sure your videos have updated thumbnails.");
            //Restart app
            System.Diagnostics.Process.Start(Application.ExecutablePath);
            this.Close();
        }

        //Freeze or unfreeze controls
        private void freeze(Control con, Boolean t)   
        {
            foreach (Control c in con.Controls)
            {
                freeze(c, t);
            }
            con.Enabled = t;
        }

    }
}
