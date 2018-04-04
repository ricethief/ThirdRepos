using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ticketing
{
    public class TicketPrice
    {
        private int section;
        private int quantity;
        private int discount;
        private decimal amountDue;
        private decimal mPrice;
        /// private decimal discountb;

        const decimal mdecBalcony = 35.5m;
        const decimal mdecGeneral = 28.75m;
        const decimal mdecBox = 62.0m;
        const decimal mdecBack = 15.0m;
        const decimal mdecDiscounts = 5.0m;
        const decimal mdecDiscountc = 10.0m;


        /// decimal changedDiscount 



        private int Section
        {
            get { return section; }
            set { section = value; }
        }

        private int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        private int Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        public decimal AmountDue
        {
            get { return amountDue; }
            set { amountDue = value; }
        }

        //private decimal DiscountB
        //{
        //    get { return discountb; }
        //    set { discountb = value; }
        //}



        // Constructor for TcicketPrice
        public TicketPrice(int section, int quantity, int discount)
        {
            Section = section;
            Quantity = quantity;
            Discount = discount;
            AmountDue = amountDue;
            /// DiscountB = discountb;
        }

        public void calculatePrice()
        {
            switch (section)
            {
                case 1:
                    mPrice = mdecBalcony;
                    break;
                case 2:
                    mPrice = mdecGeneral;
                    break;
                case 3:
                    mPrice = mdecBox;
                    break;
                case 4:
                    mPrice = mdecBack;
                    break;
            }
            if (discount == 1)
            { mPrice -= mdecDiscounts; }
            else if (discount == 2)
            { mPrice -= mdecDiscountc; }



            AmountDue = mPrice * quantity;

        }
    }
}
