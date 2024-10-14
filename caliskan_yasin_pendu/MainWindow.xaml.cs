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

namespace caliskan_yasin_pendu
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            startGame();
        }
        string guessword;
        int vie = 5;

        public void startGame()
        {
            List<string> ListWord = new List<string> { "SALUT", "", "CHINE", "CRABE", "ECART", "PIANO", "KAYAK", "HERBE", "RADIS", "BOCAL" };
        }

        private void BTN_Click(object sender, RoutedEventArgs e)
        {
            guessword.ToUpper();
            Button btn = sender as Button;
            string btnCont = btn.Content.ToString();
        }

        private void BT_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            string btnContent = btn.Content.ToString();
            btn.IsEnabled = false;
            //votre function
        }
    }
}



