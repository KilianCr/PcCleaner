using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace PcCleaner
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

        private void clean_Click(object sender, RoutedEventArgs e)
        {

        }

        private void historic_Click(object sender, RoutedEventArgs e)
        {

        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("TODO","Mise à jour",MessageBoxButton.OK,MessageBoxImage.Information);
        }

        private void website_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo("https://www.youtube.com/watch?v=XqZsoesa55w")
                {
                    UseShellExecute = true
                });
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Impossible d'ouvrir le navigateur par defaut\n - "+ ex.Message,"Erreur",MessageBoxButton.OK, MessageBoxImage.Error);
            }
               
            
        }
        private void analyse_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
