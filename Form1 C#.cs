using System.Text.RegularExpressions;

namespace Form_validation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
         
            string nameEnter = textBox1.Text;
            string emailEnter = textBox2.Text;
            string ccEnter = textBox3.Text;

            // if any feild is empty it returns an error
            if (nameEnter == "" || emailEnter == "" || ccEnter == "")
            {
                MessageBox.Show("Please fill all fields");
            }
            // if the word INSERT is included then it will not be accepted. (SQL function)
           if (nameEnter.Contains("INSERT") == true)
            {
                MessageBox.Show("Invalid text");
            }


            // if a number or special character is entered it returns an error
            string namePattern = @"^[a-zA-Z\s]+$";
            bool isNameValid = Regex.IsMatch(textBox1.Text, namePattern);
            if (!isNameValid)
            {
                MessageBox.Show("This name is not valid, please only use letters");
            }

            // cheks if email follows REGEX pattern 
            string emailPattern = @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$";
            bool isEmailValid = Regex.IsMatch(textBox2.Text, emailPattern);
            if (!isEmailValid)
            {
                MessageBox.Show("Enter a valid Email");
            }
            // numbers only validation 
            string numbersOnly = @"^-?[0-9][0-9,\.]+$"; //doesnt work 
            bool isCCNumber = Regex.IsMatch(textBox3.Text, numbersOnly);
            if (!isCCNumber)
            {
                MessageBox.Show("Only numbers allowed");
           }
            // checks there is only 16 characters
            string ccPattern = @"^[1-15]\d{15}$";
            bool isCCValid = Regex.IsMatch(textBox3.Text, ccPattern);
            if (!isCCValid)
            {
                MessageBox.Show("Enter a valid Credit Card number");
            }

            else if (isCCValid & isCCNumber & isEmailValid & isNameValid)

            {
                MessageBox.Show("Validated");
            }



        }
    }
    }