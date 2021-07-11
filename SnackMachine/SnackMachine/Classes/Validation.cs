using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackMachine.Classes
{
   public class Validation 
    {
       //I used this method to validate nullable text box
        public bool isValid(string val)
        {
            if(val != "") { return true; }
            return false;
        }
        //I used this method to valdate coins text box 
        public bool textBoxCoinsValidation(string coins ,double balance)
        {
            if (coins == "10" || coins == "20" || coins == "50" || coins == "1" || balance > 0) { return true; }
            
                return false;
        }
        //I used this method to valdate Cash text box 
        public bool textBoxCashValidation(string cash, double balance)
        {
            if (cash == "20" || cash == "50" || balance > 0){ return true; }

            return false;
        }
        public bool visaCardNumber(string cardNumber)
        {
            if (isValid(cardNumber) || cardNumber.Length == 15)
            {
                return true;
            }
            return false;
        }
        public bool MasterCardNumber(string cardNumber)
        {
            if (isValid(cardNumber) || cardNumber.Length == 13)
            {
                return true;
            }
            return false;
        }
        public bool CVVNumber(string cardNumber)
        {
            if (isValid(cardNumber) || cardNumber.Length == 2)
            {
                return true;
            }
            return false;
        }

    }

}

