using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelperMethods
{    
    public partial class WebForm1 : System.Web.UI.Page        
    {

        /*
         * 
         * Simple program to give the user the amount of 150ml cups required for a user specified amount
         * of imperial pints\quarts or gallons.
         * 
         */

        const double cup = 150, pint = 568, quart = 1136, gallon = 4546;

        private double calculateCups()
        {            
            // If no quantity is entered, then return.
            if (quantityTextBox.Text.Trim().Length == 0)
            {
                return 0;
            }

            // Check that the input value is a 'double' type  ????
            double quantity = 0.0;
            if (!Double.TryParse(quantityTextBox.Text, out quantity))
            {
                return 0;
            }            

            // Calculate the number of cups needed for the amount of pints\quarts\gallons entered.
            if (frompintsRadio.Checked)
            {
                return (pint / cup) * Double.Parse(quantityTextBox.Text);
            }
            else if (fromquartsRadio.Checked)
            {
                return (quart / cup) * Double.Parse(quantityTextBox.Text);
            }
            else if (fromgallonsRadio.Checked)
            {
                return (gallon / cup) * Double.Parse(quantityTextBox.Text);
            }

            return 0; // If no result       
        }
        
        protected void frompintsRadio_TextChanged(object sender, EventArgs e)
        {
            resultLabel.Text = ""; result1Label.Text = "";
            result1Label.Text = string.Format("Number of cups required {0:N2}",calculateCups());
        }

        protected void fromquartsRadio_TextChanged(object sender, EventArgs e)
        {
            resultLabel.Text = ""; result1Label.Text = "";
            result1Label.Text = string.Format("Number of cups required {0:N2}", calculateCups());
        }

        protected void fromgallonsRadio_TextChanged(object sender, EventArgs e)
        {
            resultLabel.Text = ""; result1Label.Text = "";
            result1Label.Text = string.Format("Number of cups required {0:N2}", calculateCups());
        }        
    }
}