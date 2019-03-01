using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            btnCommand1.Text = "+1";
            btnCommand2.Text = "x2";
            btnReset.Text = "Сброс";
            lblNumber.Text = Convert.ToString(Udvoitel.Number);
            lbcout.Text = Convert.ToString(Udvoitel.Number);
            this.Text = "Удвоитель";
            
        }

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (Udvoitel.Sum()).ToString();
            lbcout.Text = (Udvoitel.Count).ToString();
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (Udvoitel.Multi()).ToString();
            lbcout.Text = (Udvoitel.Count).ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "1";
            Udvoitel.Number = 1;
            lbcout.Text = "0";
            Udvoitel.Count = 0;
        }

        private void lblNumber_Click(object sender, EventArgs e)
        {

        }


    }
}
