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
using System.Windows.Shapes;

namespace PracticeSulemanov7_2
{
    /// <summary>
    /// Логика взаимодействия для Input.xaml
    /// </summary>
    public partial class Input : Window
    {
        public Input()
        {
            InitializeComponent();
        }

        private void SqCh(object sender, DependencyPropertyChangedEventArgs e)
        {

        }

        private void LeCh(object sender, DependencyPropertyChangedEventArgs e)
        {

        }

        private void SACh(object sender, DependencyPropertyChangedEventArgs e)
        {

        }

        private void TBInput(object sender, DependencyPropertyChangedEventArgs e)
        {
            
        }

        private void Calculate_btn_Click(object sender, RoutedEventArgs e)
        {
            Calc.GetInstance().square = SqR.IsChecked.Value;
            Calc.GetInstance().lenght = LeR.IsChecked.Value;
            Calc.GetInstance().sectorArea = SAR.IsChecked.Value;
            try
            {
                if (Convert.ToInt32(TextBoxR.Text) > 0)
                {
                    if (Convert.ToInt32(TextBoxR.Text) > 0)
                    {
                        Calc.GetInstance().radius = Convert.ToInt32(TextBoxR.Text);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("The radius cannot be less than zero!", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("The radius cannot be zero!", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void SizeControl(object sender, SizeChangedEventArgs e)
        {
            this.Height = 190;
            this.Width = 280;
        }

        private void Close(object sender, EventArgs e)
        {
            Calc.GetInstance().WindowInput = false;
        }
    }
}
