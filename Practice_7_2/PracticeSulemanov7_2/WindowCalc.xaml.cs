using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PracticeSulemanov7_2
{
    /// <summary>
    /// Логика взаимодействия для WindowCalc.xaml
    /// </summary>
    public partial class WindowCalc : Window
    {
        public WindowCalc()
        {
            InitializeComponent();
        }

        private void Calculate_btn_Click(object sender, RoutedEventArgs e)
        {
            TextBoxA.Text = Calc.GetInstance().GetAnswer();
        }

        private void SizeControl(object sender, SizeChangedEventArgs e)
        {
                this.Height = 400;
                this.Width = 400;
        }

        private void Close(object sender, EventArgs e)
        {
            Calc.GetInstance().WindowCalc = false;
        }
    }
}
