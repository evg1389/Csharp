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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            butClose.Click += butClose_Click;
            //butGame.Click += butGame_Click;
        }

        private void butGame_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
