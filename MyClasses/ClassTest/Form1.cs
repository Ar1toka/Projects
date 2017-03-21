using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyClasses;

namespace ClassTest
{
    public partial class Form1 : Form
    {
        MyClasses.clsFraction obj1 = new MyClasses.clsFraction(); MyClasses.clsFraction obj2 = new MyClasses.clsFraction();
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //объект obj1 подписывается на обработку ошибки DataErrorEvent //в случае её возникновения будет вызван метод ErrorMessage, //который описан в конце класса

            obj1.DataErrorEvent += new DataErrorDelegat(ErrorMessage);
            //объект obj2 подписывается на обработку ошибки DataErrorEvent //в случае её возникновения будет вызван метод ErrorMessage, //который описан в конце класса

            obj2.DataErrorEvent += new DataErrorDelegat(ErrorMessage);

            obj1.Numerator = Int32.Parse(txtNumerator1.Text); obj1.Denominator = Int32.Parse(txtDenominator1.Text); obj2.Numerator = Int32.Parse(txtNumerator2.Text); obj2.Denominator = Int32.Parse(txtDenominator2.Text); obj1.See(obj2);

            txtNumerator.Text = obj1.Numerator.ToString(); txtDenominator.Text = obj1.Denominator.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //объект obj1 подписывается на обработку ошибки DataErrorEvent //в случае её возникновения будет вызван метод ErrorMessage, //который описан в конце класса

            obj1.DataErrorEvent += new DataErrorDelegat(ErrorMessage);
            //объект obj2 подписывается на обработку ошибки DataErrorEvent //в случае её возникновения будет вызван метод ErrorMessage, //который описан в конце класса

            obj2.DataErrorEvent += new DataErrorDelegat(ErrorMessage);

            obj1.Numerator = Int32.Parse(txtNumerator1.Text); obj1.Denominator = Int32.Parse(txtDenominator1.Text); obj2.Numerator = Int32.Parse(txtNumerator2.Text); obj2.Denominator = Int32.Parse(txtDenominator2.Text); obj1.Mult(obj2);

            txtNumerator.Text = obj1.Numerator.ToString(); txtDenominator.Text = obj1.Denominator.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //объект obj1 подписывается на обработку ошибки DataErrorEvent //в случае её возникновения будет вызван метод ErrorMessage, //который описан в конце класса

            obj1.DataErrorEvent += new DataErrorDelegat(ErrorMessage);
            //объект obj2 подписывается на обработку ошибки DataErrorEvent //в случае её возникновения будет вызван метод ErrorMessage, //который описан в конце класса

            obj2.DataErrorEvent += new DataErrorDelegat(ErrorMessage);

            obj1.Numerator = Int32.Parse(txtNumerator1.Text); obj1.Denominator = Int32.Parse(txtDenominator1.Text); obj2.Numerator = Int32.Parse(txtNumerator2.Text); obj2.Denominator = Int32.Parse(txtDenominator2.Text); obj1.Div(obj2);

            txtNumerator.Text = obj1.Numerator.ToString(); txtDenominator.Text = obj1.Denominator.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ErrorMessage()
        {
            MessageBox.Show("В знаменателе нуль! Операция не корректна!!!");
        }

    }
}
