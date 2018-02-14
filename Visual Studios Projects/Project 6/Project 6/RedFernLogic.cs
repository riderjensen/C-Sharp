using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_6
{
    class RedFernLogic
    {
        //declare variables
        private string shippingMethod;
        private string category;
        private double numberOfItemsLbs;
        private bool surchargeButton;
        
        //bring in data for surcharge
        public RedFernLogic(string sM, string c, double nOI, bool sB)
        {
            shippingMethod = sM;
            category = c;
            numberOfItemsLbs = nOI;
            surchargeButton = sB;
        }
        //bring in data for non-surcharge
        public RedFernLogic(string sM, string c, double nOI)
        {
            shippingMethod = sM;
            category = c;
            numberOfItemsLbs = nOI;
        }

        //Decides what shipping method and how much everything will cost WITH A SURCHARGE
        //This method takes in 3 variables
        //Input: shipping method, category, number of items or pounds
        //Output: amount of shipping
        public double setShippingSurcharge()
        {
            if (surchargeButton == true)
            {
                double setShipping;
                double surchargeButtonDouble;
                if (shippingMethod == "Standard")
                {
                    surchargeButtonDouble = 2.5;
                    if (category == "Per Lb")
                    {
                        const double CAT_B_PER_LB = 1.45;
                        setShipping = CAT_B_PER_LB * numberOfItemsLbs + surchargeButtonDouble;
                        return setShipping;
                    }
                    if (category == "Per Item")
                    {
                        const double CAT_A_PER_ITEM = 3.00;
                        setShipping = CAT_A_PER_ITEM * numberOfItemsLbs + surchargeButtonDouble;
                        return setShipping;
                    }
                }
                if (shippingMethod == "Express")
                {
                    surchargeButtonDouble = 5;
                    if (category == "Per Lb")
                    {
                        const double CAT_B_PER_LB = 2.50;
                        setShipping = CAT_B_PER_LB * numberOfItemsLbs + surchargeButtonDouble;
                        return setShipping;
                    }
                    if (category == "Per Item")
                    {
                        const double CAT_A_PER_ITEM = 4.00;
                        setShipping = CAT_A_PER_ITEM * numberOfItemsLbs + surchargeButtonDouble;
                        return setShipping;
                    }
                }
                if (shippingMethod == "Same Day")
                {
                    surchargeButtonDouble = 8;
                    if (category == "Per Lb")
                    {
                        const double CAT_B_PER_LB = 3.00;
                        setShipping = CAT_B_PER_LB * numberOfItemsLbs + surchargeButtonDouble;
                        return setShipping;
                    }
                    if (category == "Per Item")
                    {
                        const double CAT_A_PER_ITEM = 5.50;
                        setShipping = CAT_A_PER_ITEM * numberOfItemsLbs + surchargeButtonDouble;
                        return setShipping;
                    }
                }
                return 1;
            }
            return 2;
        }


        //Decides what shipping method and how much everything will cost WITHOUT A SURCHARGE
        //This method takes in 3 variables
        //Input: shipping method, category, number of items or pounds
        //Output: amount of shipping
        public double setShipping()
        {
            if (surchargeButton == false)
            {
                double setShipping;
                if (shippingMethod == "Standard")
                {
                    if (category == "Per Lb")
                    {
                        const double CAT_B_PER_LB = 1.45;
                        setShipping = CAT_B_PER_LB * numberOfItemsLbs;
                        return setShipping;
                    }
                    if (category == "Per Item")
                    {
                        const double CAT_A_PER_ITEM = 3.00;
                        setShipping = CAT_A_PER_ITEM * numberOfItemsLbs;
                        return setShipping;
                    }
                }
                if (shippingMethod == "Express")
                {
                    if (category == "Per Lb")
                    {
                        const double CAT_B_PER_LB = 2.50;
                        setShipping = CAT_B_PER_LB * numberOfItemsLbs;
                        return setShipping;
                    }
                    if (category == "Per Item")
                    {
                        const double CAT_A_PER_ITEM = 4.00;
                        setShipping = CAT_A_PER_ITEM * numberOfItemsLbs;
                        return setShipping;
                    }
                }
                if (shippingMethod == "Same Day")
                {
                    if (category == "Per Lb")
                    {
                        const double CAT_B_PER_LB = 3.00;
                        setShipping = CAT_B_PER_LB * numberOfItemsLbs;
                        return setShipping;
                    }
                    if (category == "Per Item")
                    {
                        const double CAT_A_PER_ITEM = 5.50;
                        setShipping = CAT_A_PER_ITEM * numberOfItemsLbs;
                        return setShipping;
                    }
                }
                return 1;
            }
            return 2;
        }

    }
}

