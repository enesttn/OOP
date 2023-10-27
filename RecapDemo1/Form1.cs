using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[,] bt = new Button[8, 8];
            int top = 0;
            int left = 0;




            for (int i = 0; i < bt.GetUpperBound(0); i++)
            {

                for (int j = 0; j < bt.GetUpperBound(1); j++)
                {




                    bt[i, j] = new Button();
                    bt[i, j].Width = 50;
                    bt[i, j].Height = 50;
                    bt[i, j].Left = left;
                    left = left + 50;
                    if ((i + j) % 2 == 0)
                    {
                        bt[i, j].BackColor = Color.Black;

                    }
                    else
                    {
                        bt[i, j].BackColor = Color.White;
                    }

                    bt[i, j].Top = top;
                    this.Controls.Add(bt[i, j]);
                }
                left = 0;
                top = top + 50;

            }
        }
    }
}
