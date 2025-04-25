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

namespace PracticeSulemanov7_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Exit_Btn_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Input_Btn_Click(object sender, RoutedEventArgs e)
        {
            if (Calc.GetInstance().WindowInput == false)
            {
                Input input = new Input();
                input.Show();
                Calc.GetInstance().WindowInput = true;
            }
            else
            {
                MessageBox.Show("Окно уже открыто!", "Не состыковка!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Calc_Btn_Click(object sender, RoutedEventArgs e)
        {
            if (Calc.GetInstance().WindowCalc == false)
            {
                WindowCalc calc = new WindowCalc();
                calc.Show();
                Calc.GetInstance().WindowCalc = true;
            }
            else
            {
                MessageBox.Show("Окно уже открыто!", "Не состыковка!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void AboutProgram_Btn_Click(object sender, RoutedEventArgs e)
        {
            if (Calc.GetInstance().WindowAbout == false)
            {
                AboutProgram aboutProgram = new AboutProgram();
                aboutProgram.Show();
                Calc.GetInstance().WindowAbout = true;
            }
            else
            {
                MessageBox.Show("Окно уже открыто!", "Не состыковка!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Close(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void SizeControl(object sender, SizeChangedEventArgs e)
        {
            if (Width < 500)
            {
                Width = 500;
            }
            if (Height < 500)
            {
                Height = 500;
            }
        }
    }
}
