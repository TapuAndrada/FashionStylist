using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionStylist
{
   
    public class ChosenCategory
    {
        public String name { get; set; }
        public String path { get; set; }
        public List<String> imageFiles { get; set; }

        public ChosenCategory(String name)
        {
            this.name = name;
            imageFiles = new List<string>();
        }
        public void LoadImages()
        {
            if (!string.IsNullOrEmpty(path) && Directory.Exists(path))
            {
                imageFiles = Directory.GetFiles(path, "*.jpeg").ToList();
            }
        }
    }
}
