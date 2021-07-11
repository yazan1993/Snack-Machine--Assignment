using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnackMachine.Classes
{
     public class Calculate : Validation
    {
       
        //this method for return product price
        public double calculatePrice(string z)
        {
            SnacksCost snacksCost = new SnacksCost();
            if (isValid(z)) { 
            

             var x = Int32.Parse(z);
                if (snacksCost.snackCost.ContainsKey(x))
                {

                    return snacksCost.snackCost[x];

                }
            }
            else
            {
                MessageBox.Show("Please choose the product");
            }

           

            return 0.0;
        }
        //this method for calculate rest money
        public double calculateRestPrice(string Meal, string Coins, string Cash, double Balance)
        {
            double price =  calculatePrice(Meal);
            double coins = 0;
            double cash = 0.0;
            double rest;
         
            if (Balance != 0) {
                rest = (Balance) - price;
            }
            else
            {
                if (isValid(Cash))
                {
                    cash = Convert.ToDouble(Cash);
                    coins = coinsConverter(Coins,Coins);
                }
                
              rest = (coins + cash) - price;
            }
            return rest;
        }
        //Text box Coins Converter
        public double coinsConverter(string Coins, string coinsValdiation)
        {
            double coins = 0;

            if (isValid(coinsValdiation))
            {
                if (Coins == "10")
                {
                    coins = 0.1;
                }
                else if (Coins == "20")
                {
                    coins = 0.2;
                }
                else if (Coins == "50")
                {
                    coins = 0.5;
                }
                else if (Coins == "1")
                {
                    coins = 1;
                }
                else
                {
                    coins = 0;
                }
            }
            return coins;
        }
    }
    
   
}
