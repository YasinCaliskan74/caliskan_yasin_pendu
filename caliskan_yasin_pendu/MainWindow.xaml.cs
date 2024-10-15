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
using System.Windows.Media;

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
        int vie;
        char[] displayedword;


        // Démarrage du jeu
        public void startGame()
        {
            // Liste de mots possibles à deviner
            List<string> ListWord = new List<string> { "SALUT", "", "CHINE", "CRABE", "ECART", "PIANO", "KAYAK", "HERBE", "RADIS", "BOCAL" };
            Random random = new Random();
            int num = random.Next(ListWord.Count);
            guessword = ListWord[num].ToUpper(); // Choisir un mot aléatoire

            vie = 5;


            displayedword = new string('*', guessword.Length).ToCharArray();
            TB_display.Text = new string(displayedword); // Afficher le mot masqué dans l'interface
        }


        private void BTN_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            string btnCont = btn.Content.ToString(); // Obtenir la lettre cliquée
            btn.IsEnabled = false; // Désactiver le bouton après le clic


            if (guessword.Contains(btnCont))
            {
                // Révéler la lettre dans le mot affiché
                for (int i = 0; i < guessword.Length; i++)
                {
                    if (guessword[i] == btnCont[0])
                    {
                        displayedword[i] = btnCont[0]; // Remplacer l'astérisque par la lettre correcte
                    }
                }

                // Mettre à jour l'affichage du mot dans l'interface
                TB_display.Text = new string(displayedword);

                // Vérifier si le mot est entièrement deviné
                TB_display.Text = new string(displayedword);
                if (!new string(displayedword).Contains('*'))
                {
                    MessageBox.Show("Félicitations ! Vous avez gagné !");
                    startGame();
                }
            }
            else
            {
                vie--;

                if (vie == 0)
                {
                    MessageBox.Show($"Vous avez perdu ! Le mot était : {guessword}");
                    startGame(); // Redémarrer le jeu après la défaite
                }
            }

            // Mettre à jour l'affichage des vies restantes dans l'interface
            TB_Lives.Text = $"Vies restantes : {vie}";
        }
    }
}
