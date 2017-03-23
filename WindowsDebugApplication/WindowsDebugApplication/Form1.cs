using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
namespace WindowsDebugApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double c = 0;
        private void Plus(double a, double b)
        {
            c = a + b;
        }
        private void Minus(double a, double b)
        {
            c = a - b;
        }
        private void Multiply(double a, double b)
        {
            c = a * b;
        }
        private void Split(double a, double b)
        {
            c = a / b;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            string symbol = (string)SymbolcomboBox.SelectedItem;
            ArrayList arraysymbol = new ArrayList();
            foreach (var s in SymbolcomboBox.Items)
            {
                arraysymbol.Add(s);
            }
            double var1 = Convert.ToDouble(FirstVariable.Text);
            double var2 = Convert.ToDouble(SecondVariable.Text);
            switch (symbol)
            {
                case "+": Plus(var1, var1); break;
                case "-": Minus(var1, var1); break;
                case "*": Multiply(var1, var1); break;
                case "/": Split(var1, var1); break;
            }
            MessageBox.Show("Результат: " + c);
            MessageBox.Show("Количество символов в коллекции: " + arraysymbol.Count);
        }
    }
}
