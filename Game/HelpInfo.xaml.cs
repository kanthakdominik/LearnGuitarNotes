using System;
using System.IO;
using System.Media;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace Game
{
    /// <summary>
    /// Klasa ta jest pomocniczym oknem, który można włączyć podczas gry, jeśli okaże się, że dany poziom jest za trudny dla użytkownika
    /// </summary>
    public partial class HelpInfo : Window
    {
        private SoundPlayer Button_Sound = new SoundPlayer();

        /// <summary>
        /// Konstruktor klasy HelpInfo
        /// </summary>
        public HelpInfo()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metoda odpowiedzialna za cofnięcie użytkownika z powrotem do gry, zamyka to okno
        /// </summary>
        /// <param name="e">RoutedEventArgs</param> 
        /// <param name="sender">sender</param> 
        private void Back_to_Game_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Metoda umożliwia zmianę położenia okna gry
        /// </summary>
        /// <param name="e">RoutedEventArgs</param> 
        /// <param name="sender">sender</param> 
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
        /// <summary>
        /// Metoda odpowiedialna za odtworzenie dźwięku po kliknięciu danego przycisku na gryfie. Wykorzystuje 
        /// obiekt klasy SoundPlayer oraz używane w kodzie XAML Tagi, które informują, jaki przycisk został kliknięty.
        /// </summary>
        /// <param name="e">RoutedEventArgs</param> 
        /// <param name="sender">sender</param> 
        private void MyClickFunction(object sender, RoutedEventArgs e)
        {
            var tag = ((Button)sender).Tag;
            string location = Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString() + "\\Sounds\\" + tag.ToString() + ".wav";
            Button_Sound.SoundLocation = location;
            Button_Sound.Play();
        }
    }
}
