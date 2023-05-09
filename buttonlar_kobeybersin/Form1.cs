using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buttonlar_kobeybersin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int count = 1;

        private void button1_Click(object sender, EventArgs e)
        {

            for(int i = count; i <count+5; i++)
            {
                Button newBtn = new Button();
                newBtn.Text ="men "+ i.ToString();
                newBtn.Click += new System.EventHandler(this.button1_Click);
               flowLayoutPanel1.Controls.Add(newBtn);
            }
            count += 5;
        }

       
    }
}
