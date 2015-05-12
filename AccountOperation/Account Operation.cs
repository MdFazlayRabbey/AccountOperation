using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
        

        Account account=new Account();
        private void createButton_Click(object sender, EventArgs e)
        {
            

            //aCustomer.customerName=accountNumberTextBox.Text;
            //aCustomer.accountNumber = customerNameTextBox.Text;

            account.customerName = customerNameTextBox.Text;
            account.accountNumber = accountNumberTextBox.Text;
            MessageBox.Show("Account Created");

            ClearText();

            //accountNumberTextBox.Text = String.Empty;
            //customerNameTextBox.Text = String.Empty;
        }

        public void ClearText()
        {
            accountNumberTextBox.Text = String.Empty;
            customerNameTextBox.Text = String.Empty;
        }

        private void reportButton_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Customer Name"+ account.customerName +"\nAccount Number"+ account.accountNumber+"\nBalance"+ account.balance);
            //MessageBox.Show("Customer Current Balance"+ amount);
        }

        

        private void depositButton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(amountTextBox.Text);
            if (amount>0)
            {
                account.Diposit(amount);
                MessageBox.Show("Diposited");
            }
            else
            {
                MessageBox.Show("Not Possible");
            }

            //aCustomer.deposit();
            ////aCustomer.
            //// amount+= Convert.ToDouble(amountTextBox.Text.ToString());
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(amountTextBox.Text);
            if (account.balance-amount>0 && amount>0)
            {
                account.withdraw(amount);
                MessageBox.Show("Withdrawn");
            }
            else
            {
                MessageBox.Show("Not enough memory");
            }
            
            
            //aCustomer.withdraw();
            ////amount-=Convert.ToDouble(amountTextBox.Text.ToString());
        }


    }
}
