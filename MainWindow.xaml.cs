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

namespace LancioDado
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(RoutedEventArgs e, object sender)
        {
            double a = double.Parse(txtNumero.Text);
            if (a > 6 || a < 1)
            {
                MessageBox.Show("il numero inserito non è corretto, "Errore", MessageBoxButton.OK, MessageBox.Error);
                    txt.Numero.Clear()
            }

            
            
        }

        
        

        
    }
}
