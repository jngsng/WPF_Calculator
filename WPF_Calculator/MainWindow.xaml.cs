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

namespace WPF_Calculator
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        double saved = 0;
        string op = string.Empty;
        bool opFlag = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnNum_Click(object sender, RoutedEventArgs e)
        {
            // 숫자 클릭 이벤트
            Button btn = sender as Button;
            if(txtResult.Text == "0" || opFlag == true)
            {
                txtResult.Text = btn.Content.ToString();
                opFlag = false;
            }
                
            else
                txtResult.Text += btn.Content.ToString();


        }

        private void op_Click(object sender, RoutedEventArgs e)
        {
            opFlag = true;
            saved = double.Parse(txtResult.Text);
            Button btn = sender as Button;
            op = btn.Content.ToString();
            txtExp.Text = saved + " " + op;
        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            // 사칙연산
            double v = double.Parse(txtResult.Text);
            switch(op)
            {
                case "+":
                    txtResult.Text = (saved + v).ToString();
                    break;
                case "-":
                    txtResult.Text = (saved + v).ToString();
                    break;
                case "X":
                    txtResult.Text = (saved + v).ToString();
                    break;
                case "÷":
                    txtResult.Text = (saved + v).ToString();
                    break;
            }
            txtExp.Text = saved + " " + op + " " + v + " = ";
        }

        private void btnPlusMinus(object sender, RoutedEventArgs e)
        {
            // ± 버튼
            txtResult.Text = (-double.Parse(txtResult.Text)).ToString();
        }

        private void btnDot_Click(object sender, RoutedEventArgs e)
        {
            // . 버튼
            if (txtResult.Text.Contains("."))
                return;
            else
                txtResult.Text += ".";
        }

        private void btnCE_Click(object sender, RoutedEventArgs e)
        {
            // CE (clear) 버튼
            txtResult.Text = "0";
        }
    }
}
