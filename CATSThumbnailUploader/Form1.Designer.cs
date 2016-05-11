namespace CATSThumbnailUploader
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageSearchTextBox = new System.Windows.Forms.TextBox();
            this.imagePanel = new System.Windows.Forms.Panel();
            this.imageSearchButton = new System.Windows.Forms.Button();
            this.oneImageButton = new System.Windows.Forms.Button();
            this.imageFolderButton = new System.Windows.Forms.Button();
            this.videoPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.currentThumbnailPicture = new System.Windows.Forms.PictureBox();
            this.newThumbnailPicture = new System.Windows.Forms.PictureBox();
            this.channelLabel = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.newThumbnail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.videoTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.videoSearchButton = new System.Windows.Forms.Button();
            this.videoSearchTextBox = new System.Windows.Forms.TextBox();
            this.setButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.publishButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.imagePanel.SuspendLayout();
            this.videoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentThumbnailPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newThumbnailPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.FullRowSelect = true;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(3, 96);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(287, 336);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listView1_ItemCheck);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(190, 100);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageSearchTextBox
            // 
            this.imageSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.imageSearchTextBox.Location = new System.Drawing.Point(84, 63);
            this.imageSearchTextBox.Name = "imageSearchTextBox";
            this.imageSearchTextBox.Size = new System.Drawing.Size(206, 30);
            this.imageSearchTextBox.TabIndex = 1;
            this.imageSearchTextBox.TextChanged += new System.EventHandler(this.imageSearchTextBox_TextChanged);
            // 
            // imagePanel
            // 
            this.imagePanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.imagePanel.Controls.Add(this.imageSearchButton);
            this.imagePanel.Controls.Add(this.oneImageButton);
            this.imagePanel.Controls.Add(this.imageFolderButton);
            this.imagePanel.Controls.Add(this.listView1);
            this.imagePanel.Controls.Add(this.imageSearchTextBox);
            this.imagePanel.Location = new System.Drawing.Point(12, 31);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(293, 435);
            this.imagePanel.TabIndex = 2;
            // 
            // imageSearchButton
            // 
            this.imageSearchButton.Enabled = false;
            this.imageSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.imageSearchButton.Location = new System.Drawing.Point(3, 62);
            this.imageSearchButton.Name = "imageSearchButton";
            this.imageSearchButton.Size = new System.Drawing.Size(78, 32);
            this.imageSearchButton.TabIndex = 5;
            this.imageSearchButton.Text = "Search";
            this.imageSearchButton.UseVisualStyleBackColor = true;
            // 
            // oneImageButton
            // 
            this.oneImageButton.Location = new System.Drawing.Point(3, 3);
            this.oneImageButton.Name = "oneImageButton";
            this.oneImageButton.Size = new System.Drawing.Size(287, 26);
            this.oneImageButton.TabIndex = 3;
            this.oneImageButton.Text = "Browse single images";
            this.oneImageButton.UseVisualStyleBackColor = true;
            this.oneImageButton.Click += new System.EventHandler(this.oneImageButton_Click);
            // 
            // imageFolderButton
            // 
            this.imageFolderButton.Location = new System.Drawing.Point(3, 30);
            this.imageFolderButton.Name = "imageFolderButton";
            this.imageFolderButton.Size = new System.Drawing.Size(287, 26);
            this.imageFolderButton.TabIndex = 4;
            this.imageFolderButton.Text = "Browse image folder";
            this.imageFolderButton.UseVisualStyleBackColor = true;
            this.imageFolderButton.Click += new System.EventHandler(this.imageFolderButton_Click);
            // 
            // videoPanel
            // 
            this.videoPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.videoPanel.Controls.Add(this.label2);
            this.videoPanel.Controls.Add(this.label1);
            this.videoPanel.Controls.Add(this.currentThumbnailPicture);
            this.videoPanel.Controls.Add(this.newThumbnailPicture);
            this.videoPanel.Controls.Add(this.channelLabel);
            this.videoPanel.Controls.Add(this.listView2);
            this.videoPanel.Controls.Add(this.videoSearchButton);
            this.videoPanel.Controls.Add(this.videoSearchTextBox);
            this.videoPanel.Location = new System.Drawing.Point(435, 31);
            this.videoPanel.Name = "videoPanel";
            this.videoPanel.Size = new System.Drawing.Size(402, 435);
            this.videoPanel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "New Thumbnail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Current Thumbnail";
            // 
            // currentThumbnailPicture
            // 
            this.currentThumbnailPicture.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.currentThumbnailPicture.Location = new System.Drawing.Point(211, 306);
            this.currentThumbnailPicture.Name = "currentThumbnailPicture";
            this.currentThumbnailPicture.Size = new System.Drawing.Size(187, 126);
            this.currentThumbnailPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.currentThumbnailPicture.TabIndex = 10;
            this.currentThumbnailPicture.TabStop = false;
            // 
            // newThumbnailPicture
            // 
            this.newThumbnailPicture.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.newThumbnailPicture.Location = new System.Drawing.Point(5, 306);
            this.newThumbnailPicture.Name = "newThumbnailPicture";
            this.newThumbnailPicture.Size = new System.Drawing.Size(187, 126);
            this.newThumbnailPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.newThumbnailPicture.TabIndex = 9;
            this.newThumbnailPicture.TabStop = false;
            // 
            // channelLabel
            // 
            this.channelLabel.AutoSize = true;
            this.channelLabel.Location = new System.Drawing.Point(4, 3);
            this.channelLabel.Name = "channelLabel";
            this.channelLabel.Size = new System.Drawing.Size(68, 17);
            this.channelLabel.TabIndex = 8;
            this.channelLabel.Text = "Channel: ";
            // 
            // listView2
            // 
            this.listView2.CheckBoxes = true;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.newThumbnail,
            this.videoTitle});
            this.listView2.FullRowSelect = true;
            this.listView2.Location = new System.Drawing.Point(3, 62);
            this.listView2.MultiSelect = false;
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(396, 223);
            this.listView2.TabIndex = 6;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView2_ColumnClick);
            this.listView2.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listView2_ItemCheck);
            // 
            // newThumbnail
            // 
            this.newThumbnail.Text = "New Thumbnail";
            // 
            // videoTitle
            // 
            this.videoTitle.Text = "Video Title";
            // 
            // videoSearchButton
            // 
            this.videoSearchButton.Enabled = false;
            this.videoSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.videoSearchButton.Location = new System.Drawing.Point(3, 23);
            this.videoSearchButton.Name = "videoSearchButton";
            this.videoSearchButton.Size = new System.Drawing.Size(65, 33);
            this.videoSearchButton.TabIndex = 7;
            this.videoSearchButton.Text = "Search";
            this.videoSearchButton.UseVisualStyleBackColor = true;
            // 
            // videoSearchTextBox
            // 
            this.videoSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.videoSearchTextBox.Location = new System.Drawing.Point(71, 25);
            this.videoSearchTextBox.Name = "videoSearchTextBox";
            this.videoSearchTextBox.Size = new System.Drawing.Size(328, 30);
            this.videoSearchTextBox.TabIndex = 6;
            this.videoSearchTextBox.TextChanged += new System.EventHandler(this.videoSearchTextBox_TextChanged);
            // 
            // setButton
            // 
            this.setButton.Location = new System.Drawing.Point(311, 31);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(118, 132);
            this.setButton.TabIndex = 4;
            this.setButton.Text = "Set selected image as thumbnail for selected video";
            this.setButton.UseVisualStyleBackColor = true;
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(311, 184);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(118, 132);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "Reset new thumbnail for selected video";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // publishButton
            // 
            this.publishButton.Location = new System.Drawing.Point(311, 334);
            this.publishButton.Name = "publishButton";
            this.publishButton.Size = new System.Drawing.Size(118, 132);
            this.publishButton.TabIndex = 6;
            this.publishButton.Text = "Publish changes to YouTube";
            this.publishButton.UseVisualStyleBackColor = true;
            this.publishButton.Click += new System.EventHandler(this.publishButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(15, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Local image selector";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Tomato;
            this.label4.Location = new System.Drawing.Point(438, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "My uploads";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Image Files (*.png, *.jpg)|*.png;*.jpg";
            this.openFileDialog1.Multiselect = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 470);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.publishButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.setButton);
            this.Controls.Add(this.videoPanel);
            this.Controls.Add(this.imagePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "CATS Thumbnail Uploader";
            this.imagePanel.ResumeLayout(false);
            this.imagePanel.PerformLayout();
            this.videoPanel.ResumeLayout(false);
            this.videoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentThumbnailPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newThumbnailPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox imageSearchTextBox;
        private System.Windows.Forms.Panel imagePanel;
        private System.Windows.Forms.Button imageSearchButton;
        private System.Windows.Forms.Button oneImageButton;
        private System.Windows.Forms.Button imageFolderButton;
        private System.Windows.Forms.Panel videoPanel;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button videoSearchButton;
        private System.Windows.Forms.TextBox videoSearchTextBox;
        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button publishButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label channelLabel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ColumnHeader newThumbnail;
        private System.Windows.Forms.ColumnHeader videoTitle;
        private System.Windows.Forms.PictureBox currentThumbnailPicture;
        private System.Windows.Forms.PictureBox newThumbnailPicture;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

