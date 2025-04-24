using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FashionStylist
{
    public partial class OutfitSelect: Form
    {
        private Categories categ;
        private List<ChosenCategory> chcateg=new List<ChosenCategory>();

        public OutfitSelect(Categories cat)
        {
            InitializeComponent();
            this.categ = cat;
            
        }

        private void OutfitSelect_Load(object sender, EventArgs e)
        {
            var properties = categ.GetType().GetProperties();
            foreach (var prop in properties)
            {
                bool valoare = (bool)prop.GetValue(categ);
                if (valoare)
                {
                    ChosenCategory categ = new ChosenCategory(prop.Name);
                    chcateg.Add(categ);
                    listBox_Sel_Categ.Items.Add(prop.Name);

                    categ.LoadImages();
                }
            }
           
        }

        private void listBox_Sel_Categ_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Sel_Categ.SelectedItem != null)
            {
                button_Select.Visible = true;
                button_Select.Text = "Choose the folder for "+ listBox_Sel_Categ.SelectedItem;
                button_GenOutfit.Visible = true;

            }
        }

        private void button_Select_Click(object sender, EventArgs e)
        {
            string selectedCategory = listBox_Sel_Categ.SelectedItem.ToString();

            ChosenCategory selectedChosenCategory = chcateg.FirstOrDefault(c => c.name == selectedCategory);

            if (selectedChosenCategory != null)
            {
                using (folderBrowserDialog)
                {
                    folderBrowserDialog.Description = "Choose the folder for "+selectedChosenCategory.name;

                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        selectedChosenCategory.path = folderBrowserDialog.SelectedPath;
                        selectedChosenCategory.LoadImages();
                    }
                }
            }
        }

        private void button_GenOutfit_Click_1(object sender, EventArgs e)
        {
            bool allFoldersSelected = true;

            foreach (ChosenCategory c in chcateg)
            {
                if (string.IsNullOrEmpty(c.path) || !Directory.Exists(c.path))
                {
                    allFoldersSelected = false;
                    break;
                }
            }
            if (allFoldersSelected) {
                Loading loading = new Loading(chcateg);
                loading.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select the folder corresponding to each item in the outfit!");
            }
        }
    }
}
