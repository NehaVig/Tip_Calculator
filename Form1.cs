using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Tip_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }
       

            private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(bill_textBox.Text))
                {
                    if (Convert.ToDouble(bill_textBox.Text) <= 0)
                        MessageBox.Show("Bill value can't be zero or below zero");
                    else
                        UpdateTotals();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        } // textbox ends here
    
            
      

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        private void tip_label_Click(object sender, EventArgs e)
        {

        }


        private void tip_percentage_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        private void UpdateTotals()
        {
            try
            {
                decimal perPersonBill = Convert.ToDecimal(bill_textBox.Text) / input_people.Value;
                decimal tip = perPersonBill * (tip_percentage.Value / 100);
                tip_per_person.Text = "$" + tip.ToString("N2");
                total_tip.Text = "$" + (tip + perPersonBill).ToString("N2");
            }
            catch (FormatException ex)
            {
               MessageBox.Show("Give appropriate amount");
             
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }
    }// public partial form 1
}// end of namespace


