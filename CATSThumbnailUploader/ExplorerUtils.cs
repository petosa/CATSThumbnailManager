using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CATSThumbnailUploader
{
    class ExplorerUtils
    {
        //Collect all images from directory
        public static List<String> getAllImages(String path)
        {
            return Directory
                .GetFiles(path, "*.*", SearchOption.AllDirectories)
                .Where(file => file.ToLower().EndsWith("jpg") || file.ToLower().EndsWith("png"))
                .ToList();
        }

        //Convert path string to file name
        public static String getFileName(String s)
        {
            int li = s.LastIndexOf("\\");
            if(li == -1)
            {
                return s;
            }
            return s.Substring(li + 1);
        }
    }
}
