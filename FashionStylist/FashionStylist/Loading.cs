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
    public partial class Loading: Form
    {
        private List<ChosenCategory> chcateg = new List<ChosenCategory>();

        public Loading(List<ChosenCategory> chcateg)
        {
            InitializeComponent();
            this.chcateg = chcateg;
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value < 100)
            {
                progressBar.Value += 1;
                percent.Text = progressBar.Value.ToString() + " %";
            }
            else if (progressBar.Value == 100)
            {
                timer.Stop();
                TheOutfit theOutfit = new TheOutfit(chcateg);
                theOutfit.Show();
                this.Close();
            }
        }

    }
}
