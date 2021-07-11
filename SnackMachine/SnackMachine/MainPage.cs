using SnackMachine.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnackMachine
{
    public partial class MainPage : Form
    {
        public Validation _validation = new Validation();
        public Calculate _calculate=new Calculate();

        public MainPage(Validation val, Calculate calculate)
        {
            _validation = val;
            _calculate = calculate;
        }
        public bool boolCoins = false;
        public bool boolCash = false;
        public bool boolAddCoins = false;
        public bool boolAddCash = false;
        //I used this variable to change between text boxes
        public int count = 0;
        //I used this variable to add money if costumer put more coins
        public double Balance = 0;
        //I used this variable to save rest of money and show it to custmer
        public double rest;
        public MainPage()
        {
            InitializeComponent();
        }
        //keyPad
        //Button 1
        public void btn1_Click(object sender, EventArgs e)
        {
       
           if (count == 0)
            {
                if(txtMeal.Text.Length < 2)
                {

                txtMeal.Text += "1";
                }
                else
                {
                    MessageBox.Show("Can not enter more than two digits !!");
                }

                

            }
            else if (count == 1)
            {
                    txtCoins.Text += "1";

            }
            else
            {
                txtCash.Text += "1";
            }
       


        }
        //Button 2
        public void btn2_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                if (txtMeal.Text.Length < 2)
                {

                    txtMeal.Text += "2";
                }
                else
                {
                    MessageBox.Show("Can not enter more than two digits !!");
                }



            }
            else if (count == 1)
            {
                txtCoins.Text += "2";

            }
            else
            {
                txtCash.Text += "2";
            }

        }
        //Button 3
        public void btn3_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                if (txtMeal.Text.Length < 2)
                {

                    txtMeal.Text += "3";
                }
                else
                {
                    MessageBox.Show("Can not enter more than two digits !!");
                }



            }
            else if (count == 1)
            {
                txtCoins.Text += "3";

            }
            else
            {
                txtCash.Text += "3";
            }

        }
        //Button 4
        public void btn4_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                if (txtMeal.Text.Length < 2)
                {

                    txtMeal.Text += "4";
                }
                else
                {
                    MessageBox.Show("Can not enter more than two digits !!");
                }



            }
            else if (count == 1)
            {
                txtCoins.Text += "4";

            }
            else
            {
                txtCash.Text += "4";
            }
        }
        //Button 5
        public void btn5_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                if (txtMeal.Text.Length < 2)
                {

                    txtMeal.Text += "5";
                }
                else
                {
                    MessageBox.Show("Can not enter more than two digits !!");
                }



            }
            else if (count == 1)
            {
                txtCoins.Text += "5";

            }
            else
            {
                txtCash.Text += "5";
            }
        }
        //Button 6
        public void btn6_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                if (txtMeal.Text.Length < 2)
                {

                    txtMeal.Text += "6";
                }
                else
                {
                    MessageBox.Show("Can not enter more than two digits !!");
                }



            }
            else if (count == 1)
            {
                txtCoins.Text += "6";

            }
            else
            {
                txtCash.Text += "6";
            }

        }
        //Button 7
        public void btn7_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                if (txtMeal.Text.Length < 2)
                {

                    txtMeal.Text += "7";
                }
                else
                {
                    MessageBox.Show("Can not enter more than two digits !!");
                }



            }
            else if (count == 1)
            {
                txtCoins.Text += "7";

            }
            else
            {
                txtCash.Text += "7";
            }
        }
        //Button 8
        public void btn8_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                if (txtMeal.Text.Length < 2)
                {

                    txtMeal.Text += "8";
                }
                else
                {
                    MessageBox.Show("Can not enter more than two digits !!");
                }



            }
            else if (count == 1)
            {
                txtCoins.Text += "8";

            }
            else
            {
                txtCash.Text += "8";
            }

        }
        //Button 9
        public void btn9_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                if (txtMeal.Text.Length < 2)
                {

                    txtMeal.Text += "9";
                }
                else
                {
                    MessageBox.Show("Can not enter more than two digits !!");
                }



            }
            else if (count == 1)
            {
                txtCoins.Text += "9";

            }
            else
            {
                txtCash.Text += "9";
            }
        }
        //Button Dot
        public void btnDot_Click(object sender, EventArgs e)
        {
            if (!txtCoins.Text.Contains("."))
            {
                txtCoins.Focus();
                txtCoins.Text += ".";
            }
           
                
            
            

        }
        //Button 0
        public void btn0_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                if (txtMeal.Text.Length < 2)
                {

                    txtMeal.Text += "0";
                }
                else
                {
                    MessageBox.Show("Can not enter more than two digits !!");
                }



            }
            else if (count == 1)
            {
                
                    txtCoins.Text += "0";
               

            }
            else
            {
                txtCash.Text += "0";
            }

        }
        //Button Delete
        public void btnDelete_Click(object sender, EventArgs e)
        {
           
            txtMeal.Text = "";
            txtCoins.Text = "";
            txtCash.Text = "";


        }
        //End KeyPad

        //Button Ok Event
        //Claculate Product Price && Change Welcome Screen
        public void btnOK_Click(object sender, EventArgs e)
        {
            Calculate calculate = new Calculate();
            var c = calculate.calculatePrice(txtMeal.Text);
            if(c != 0.0)
            {

            WelcomeScreen.Text = "Your order price " + c + " $ " + Environment.NewLine +
                "-Money Slots: the machine accepts money of the following types:" + Environment.NewLine+
                "-Coin slot: There are four denominations:10c,20c,50c,$1 " + Environment.NewLine +
                "-Machine only accepts USD currency" + Environment.NewLine +
                "-Notes Slot :20$ and 50$ only";
            }
            else
            {
                WelcomeScreen.Text = "You have entered the wrong number";

            }
        }


        //Page on load
        public void MainPage_Load(object sender, EventArgs e)
        {
            WelcomeScreen.Text = "Welcome to snacks machine , please enter your meal number";
        }
        //Button next to change foucas between text boxes to use keypad and change background text box color to know which box fouced
        private void btnNext_Click(object sender, EventArgs e)
        {
             count++;
            if(count > 2)
            {
                count = 0;
            }
            if (count == 0)
            {
                txtMeal.BackColor = Color.Aqua;
                txtCoins.BackColor = Color.White;
                txtCash.BackColor = Color.White;
            }
            else if(count==1){
                txtMeal.BackColor = Color.White;
                txtCoins.BackColor = Color.Aqua;
                txtCash.BackColor = Color.White;
            }
            else
            {
                txtCash.BackColor =Color.White;
                txtCoins.BackColor = Color.White;
                txtCash.BackColor = Color.Aqua;

            }

        }
       

        //This method to buy snck
        private void buy_Click(object sender, EventArgs e)
        {
            if(_validation.isValid(txtMeal.Text)) {
             if (_validation.isValid(txtCoins.Text)) { 
                if (_validation.textBoxCoinsValidation(txtCoins.Text,Balance))
                  {
                   boolCoins = true;
                    
                  }else
                    {
                   
                        MessageBox.Show("Please enter coins just 10,20,50,1");

                        
                    }
                }
                if (_validation.isValid(txtCash.Text))
                {
                    if (_validation.textBoxCashValidation(txtCash.Text, Balance))
                    {
                        boolCash = true;

                    }
                    else
                    {
                        MessageBox.Show("Please enter cash just 20 or 50");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter snack");

            }
            if(boolCash || boolCoins || Balance > 0)
            {
                this.rest = _calculate.calculateRestPrice(txtMeal.Text, txtCoins.Text, txtCash.Text, Balance);
                if(rest > 0)
                {
                    txtRest.Text = rest.ToString();
                    txtCash.Text = "";
                    txtCoins.Text = "";
                    txtMeal.Text = "";
                    txtBalance.Text = "";
                    Balance = 0;
                    WelcomeScreen.Text = "Welcome to snacks machine , please enter your snack number";
                    txtMeal.Focus();
                    count = 0;
                }
                else
                {
                    MessageBox.Show("No money enough");
                }
               
            }
            else
            {
                
                MessageBox.Show("Pleas put money");
            }
           

        }
        public double cash = 0;
        //This method to add balance
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (_validation.isValid(txtCash.Text))
            {
                if (txtCash.Text == "20" || txtCash.Text == "50")
                {
                    boolAddCash = true;
                    cash = double.Parse(txtCash.Text);


                }
                else
                {
                    MessageBox.Show("Please enter cash just 20 or 50");
                }

            }

            if (_validation.isValid(txtCoins.Text))
            {
                if (_validation.textBoxCoinsValidation(txtCoins.Text, Balance))
                {
                boolAddCoins = true;

                }else
                {
                    MessageBox.Show("Please enter coins just 10c,20c,50c,1$");

                }
               
              }
            
            if (boolAddCoins || boolAddCash)
            {
                double coins = _calculate.coinsConverter(txtCoins.Text, txtCoins.Text);
                Balance += coins+cash;
            }
            else
            {
                MessageBox.Show("Please fill th field");

            }





            txtBalance.Text = Balance.ToString();
            txtCash.Text = "";
            txtCoins.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            VisaCard visaCard = new VisaCard();
            visaCard.Show();
        }
    }
}
