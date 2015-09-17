using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RateInterest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        RateInterest rinterest = new RateInterest();

        private void calculate_Click(object sender, EventArgs e)
        {
            MessageBox.Show(System.Convert.ToString(rinterest.calculateRate(System.Convert.ToDouble(annualRate.Text), false, 28, System.Convert.ToDouble(creditAmount.Text))));
        }

        private void amountRB_CheckedChanged(object sender, EventArgs e)
        {
            periodTermPanel.Visible = !amountRB.Checked;
            amountDaysLabel.Visible = amountRB.Checked;
            amountOfDays.Visible = amountRB.Checked;
        }

        private void fromDate_ValueChanged(object sender, EventArgs e)
        {
            toTime.MinDate = fromDate.Value;
        }
    }
}
