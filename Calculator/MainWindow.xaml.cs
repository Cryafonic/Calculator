using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Operator currentOperator;
        private double firstNumber;
        private double secondNumber;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextBox Text = new TextBox();
            var btn = sender as Button;
            if (txtResult.Text != "0")
            {
                txtResult.Text = $"{txtResult.Text}{btn.Content}";
            }
            else
            {
                txtResult.Text = btn.Content.ToString();
            }
        }

        // The all clear button
        private void Button_Click_AC(Object sender, RoutedEventArgs e)
        {
            firstNumber = 0;
            secondNumber = 0;
            currentOperator = 0;
            txtResult.Text = "0";
        }

        //The Add button
        private void Button_Click_Plus(object sender, RoutedEventArgs e)
        {
            currentOperator = Operator.Add;
            firstNumber = double.Parse(txtResult.Text);
            txtResult.Text = "0";
        }

        // Calculate the end result
        private void Button_Click_Equal(object sender, RoutedEventArgs e)
        {
            secondNumber = double.Parse(txtResult.Text);
            txtResult.Text = GetResult(firstNumber, currentOperator, secondNumber);
        }

        // Subtract the values
        private void Button_Click_Minus(object sender , RoutedEventArgs e)
        {
            currentOperator = Operator.Substract;
            firstNumber = double.Parse(txtResult.Text);
            txtResult.Text = "0";
        }

        // Multiplay the values
        private void Button_Click_Multiply(object sender, RoutedEventArgs e)
        {
            currentOperator = Operator.Multiply;
            firstNumber = double.Parse(txtResult.Text);
            txtResult.Text = "0";
        }

        // Divides the values 
        private void Button_Click_divide(object sender, RoutedEventArgs e)
        {
            currentOperator = Operator.Divide;
            firstNumber = double.Parse(txtResult.Text);
            txtResult.Text = "0";
        }

        private void Button_Click_div(object sender, RoutedEventArgs e)
        {
            txtResult.Text = (double.Parse(txtResult.Text) * -1).ToString();
        }

        private void Button_Click_Point(object sender, RoutedEventArgs e)
        {
            if (txtResult.Text.IndexOf(".") < 0)
            {
                txtResult.Text += ".";
            }
        }

        private void Button_Click_percentage(object sender, RoutedEventArgs e)
        {

        }

        //Logic for the calculations
        private string GetResult(double firstNumber, Operator currentOperator, double secondNumber) 
        {
            if (currentOperator == Operator.Add)
            {
                return (firstNumber + secondNumber).ToString();
            }
            else if (currentOperator == Operator.Substract)
            {
                return (firstNumber - secondNumber).ToString();
            }
            else if (currentOperator == Operator.Multiply)
            {
                return (firstNumber * secondNumber).ToString();
            }
            else if (currentOperator == Operator.Divide)
            {
                return (firstNumber / secondNumber).ToString();
            }
            else
            {
                return "0";
            }
        }

        public enum Operator
        { 
            Add,
            Substract,
            Multiply,
            Divide
        }
    }
}