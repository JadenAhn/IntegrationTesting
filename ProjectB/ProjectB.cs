/* ProjectB.cs
 * 
 * Project for integration testing
 * 
 * Revision History
 *      Jaden Ahn, 2018-03-21: Created
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment03
{
    public partial class ProjectB : Form
    {
        public ProjectB()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            double value = 0.0;
            lblResult.Text = "0";
            try
            {
                value = double.Parse(txtValue.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid value");
                
            }
            string convertFrom = txtConvertFrom.Text;
            string convertTo = txtConvertTo.Text;

            try
            {
                lblResult.Text = TimeConversion.Convert(value, convertFrom, convertTo).ToString();
            }
            catch (ArgumentException ex)
            {
                lblResult.Text = ex.Message;
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
