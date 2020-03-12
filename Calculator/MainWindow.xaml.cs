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
    public partial class App : Window
    {
        private Operator currentOperator;
        private double firstNumber;
        private double secondNumber;


        public App()
        {
            InitializeComponent();
        }

        private void Button_Click_AC(Object sender, RoutedEventArgs e)
        {
            firstNumber = 0;
            secondNumber = 0;
            currentOperator = 0;
            txtResult.Text = "0";
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
