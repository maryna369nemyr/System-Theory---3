using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        
        
        
        void Form2_Load(object sender, EventArgs e)
        {

        }

        public void textBox_output_TextChanged()
        {
            string message = " k\r\t\r\t   x0\r\t\r\t  x1\r\t\r\t  x2\r\t\r\t  u\r\t\r\n";

            int k = (int)Math.Log10(Program.x.Count) - 1;
            for (int i = 0; i < Program.x.Count; i = i + (int)(10 * (k > 0 ? k : 0.1)))
            {
                string temp = i.ToString(); message += temp + " \r\t\r\t";
                for (int j = 0; j < Program.x[i].M.Length; j++)
                {
                    for (int l = 0; l < Program.x[i].M[j].Length; l++)
                    {
                        message += Math.Round(Program.x[i].M[j][l], 5).ToString() + " \r\t\r\t";

                    }
                    
                }
                if( i<= Processing.k0-1) message += Math.Round(Program.u[i], 2).ToString();
                message += "\r\n\r ";
            }
            textBox_output.Text = message;
        }
    }
}
