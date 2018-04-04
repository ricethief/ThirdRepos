using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ticketing
{
    public partial class TicketsForm : Form
    {
        TicketPrice mTicketPrice;
        int mSection = 2;
        int mQuantity = 0;
        int mDiscount = 0;
        public decimal discountb;

        public TicketsForm()
        {
            InitializeComponent();
        }

        private void TicketsForm_Load(object sender, EventArgs e)
        {
            
        }
        //private void chkDiscount_CheckStateChanged(object sender, EventArgs e)
        //{
        //    if (chkDiscount.Checked)
        //    { txtDiscount.Enabled = true; }
        //    else { txtDiscount.Enabled = false; }
        //}

        private void cmdCalculate_Click(object sender, EventArgs e)
        {
            mQuantity = int.Parse(txtQuantity.Text);

            if (chkDiscount.Checked)
            {
                mDiscount = 1;
                txtDiscount.Enabled = true;
            }
            else if (ckbChild.Checked)
            {
                mDiscount = 2;
                txtDiscount.Enabled = true;
            }
            else if (!ckbChild.Checked && !chkDiscount.Checked)
            { mDiscount = 0; }

            if (radBalcony.Checked)
                { mSection = 1;}
            if (radGeneral.Checked)
                { mSection = 2;}
            if (radBox.Checked)
                { mSection = 3; }

            ///discountb = decimal.Parse(txtDiscount.Text);
            


            mTicketPrice = new TicketPrice(mSection, mQuantity, mDiscount, discountb);

            mTicketPrice.calculatePrice();
            lblAmount.Text = System.Convert.ToString(mTicketPrice.AmountDue);
        }

      
    }
}
