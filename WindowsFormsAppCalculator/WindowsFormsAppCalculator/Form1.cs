using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppCalculator
{
    public partial class s : Form
    {

        string numStr1, numStr2;
        int num1, num2;
        float result = 0;
        public s()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resultBox.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            getNumbers();
            result = num1 + num2;
            resultBox.Text = "" + result;
        }

        private void subtractionBtn_Click(object sender, EventArgs e)
        {
            getNumbers();
            result = num1 - num2;
            resultBox.Text = "" + result;
        }

        private void multiplicationBtn_Click(object sender, EventArgs e)
        {
            getNumbers();
            result = num1 * num2;
            resultBox.Text = "" + result;
        }

        private void divideBtn_Click(object sender, EventArgs e)
        {
            getNumbers();
            result = num1 / num2;
            resultBox.Text = "" + result;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {


        }
        private void getNumbers()
        {
            numStr1 = this.n1TxtBox.Text.ToString();
            numStr2 = this.n2TxtBox.Text.ToString();

            num1 = int.Parse(numStr1);
            num2 = int.Parse(numStr2);

        }
    }
}
