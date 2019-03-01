using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            
            lbCount.Text = "попыток 0";
            RNumber.Number = rnd.Next(0, 100);
        
        }

        Random rnd = new Random();
        

        private void butEnter_Click(object sender, EventArgs e)
        {
            RNumber.Temp = Convert.ToInt32(tbNum.Text);
            this.lbT2.Text = $"Вы ввели число {RNumber.Temp}";
            //RNumber.Count;
            lbCount.Text = $"попыток {RNumber.Count}";
            if (RNumber.Temp == RNumber.Number)
            {
                this.lbT2.Text = "Вы угадали!";
                MessageBox.Show ("Вы угадали!");
                this.Close();
            }
            else
            {
                this.lbT2.Text = $"продолжаем!";
                RNumber.Count++;
            }


        }

    }
}
