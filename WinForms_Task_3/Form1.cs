using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Task_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                result.Text = Convert.ToString((Math.Pow(Convert.ToDouble((operand1.Text)), (Convert.ToDouble(operand2.Text)))));
            }
            if (radioButton2.Checked == true)
            {
                if ((Convert.ToDouble(operand2.Text) == 0))
                {
                    result.Text = ("Деление на 0 недопустимо");
                }

                else
                {
                    result.Text = Convert.ToString((Convert.ToDouble(operand1.Text)) / (Convert.ToDouble(operand2.Text)));
                }
            }

            if (radioButton3.Checked == true)
            {
                if ((Convert.ToDouble(operand2.Text) == 0))
                {
                    result.Text = ("Деление на 0 недопустимо");
                }

                else
                {
                    result.Text = Convert.ToString(Convert.ToDouble(operand1.Text) % Convert.ToDouble(operand2.Text));
                }
            }
            if (radioButton4.Checked == true)
            {
                result.Text = Convert.ToString((operand1.Text) + (operand2.Text));
            }
        }
    }
}
