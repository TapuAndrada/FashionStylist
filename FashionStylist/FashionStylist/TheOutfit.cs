using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FashionStylist
{
    public partial class TheOutfit: Form
    {
        private List<ChosenCategory> chcateg = new List<ChosenCategory>();

        public TheOutfit(List<ChosenCategory> chcateg)
        {
            InitializeComponent();
            this.chcateg = chcateg;

        }

        private void TheOutfit_Load(object sender, EventArgs e)
        {
            Random rand = new Random();

            foreach (ChosenCategory category in chcateg)
            {
                if (category.imageFiles.Count > 0)
                {
                    string randomImagePath = category.imageFiles[rand.Next(category.imageFiles.Count)];

                    if (category.name == "tops")
                    {
                        label_top.Visible = true;
                        pictureBox_Tops.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox_Tops.ImageLocation = randomImagePath;
                    }
                    else if (category.name == "pants")
                    {
                        label_pants.Visible = true;
                        pictureBox_Pants.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox_Pants.ImageLocation = randomImagePath;
                    }
                    else if (category.name == "shoes")
                    {
                        label_shoes.Visible = true;
                        pictureBox_Shoes.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox_Shoes.ImageLocation = randomImagePath;
                    }
                    else if (category.name == "skirt")
                    {
                        label_skirt.Visible = true;
                        pictureBox_Skirt.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox_Skirt.ImageLocation = randomImagePath;
                    }
                    else if (category.name == "dresses")
                    {
                        label_dress.Visible = true;
                        pictureBox_Dress.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox_Dress.ImageLocation = randomImagePath;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
