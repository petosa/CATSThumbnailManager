using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CATSThumbnailUploader
{

    public class ListViewUtils
    {
        //Resize columns in ListView lv
        public static void resizeColumns(ListView lv)
        {
            int x = lv.Width / 3;
            lv.Columns[0].Width = 1 * x;
            lv.Columns[1].Width = 2 * x;
        }

        public static void searchFilter(Boolean type1, ListView lv, TextBox tb,
            List<ListViewItem> l, Dictionary<ListViewItem, VideoContext> hash)
        {
            List<ListViewItem> results = new List<ListViewItem>();
            foreach (ListViewItem v in l)
            {
                if (!type1 && hash[v].name.ToLower().Contains(tb.Text.ToLower()) ||
                    type1 && v.Text.ToLower().Contains(tb.Text.ToLower()))
                {
                    results.Add(v);
                }
            }
            lv.Items.Clear();
            foreach (ListViewItem lvi in results)
                lv.Items.Add(lvi);
        }

    }

    class ListViewItemComparer : IComparer
    {
        private static Boolean rev0 = false;
        private static Boolean rev1 = false;
        private int col;
        private Boolean rev;
        public ListViewItemComparer(int column)
        {
            col = column;
            if (col == 0)
            {
                rev = rev0;
                rev0 = !rev0;
            }
            else
            {
                rev = rev1;
                rev1 = !rev1;
            }
        }
        public int Compare(object x, object y)
        {
            String sx = ((ListViewItem)x).SubItems[col].Text;
            String sy = ((ListViewItem)y).SubItems[col].Text;

            if (col == 0)
            {
                if (sx.Equals("") && !sy.Equals(""))
                    return 1;
                if (sy.Equals("") && !sx.Equals(""))
                    return -1;
            }
            int returnVal = -1;
            returnVal = String.Compare(sx, sy);
            if (rev)
                returnVal *= -1;
            return returnVal;
        }
    }
}
