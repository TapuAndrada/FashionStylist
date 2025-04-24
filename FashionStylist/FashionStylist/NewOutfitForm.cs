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
    public partial class NewOutfitForm: Form
    {
        public NewOutfitForm()
        {
            InitializeComponent();
        }

        private void button_Done_Click(object sender, EventArgs e)
        {
            var categ = new Categories
            {
                tops = checkBox_Tops.Checked,
                pants = checkBox_Pants.Checked,
                dresses = checkBox_Dresses.Checked,
                skirts=checkBox_Skirts.Checked,
                shoes=checkBox_Shoes.Checked,
             
            };

            OutfitSelect outfit = new OutfitSelect(categ);
            outfit.Show();
            this.Close();
        }

    }
}
