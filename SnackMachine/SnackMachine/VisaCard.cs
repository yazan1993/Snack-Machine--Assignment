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
    public partial class VisaCard : Form
    {
        public VisaCard()
        {
            InitializeComponent();
        }
        public Validation _Validation;
      
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Done");
            this.Close();

        }
    }
}

