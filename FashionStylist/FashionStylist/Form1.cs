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
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_new_outfit_Click(object sender, EventArgs e)
        {
            NewOutfitForm secondForm = new NewOutfitForm();
            secondForm.Show();

         
        }

       
    }
}
