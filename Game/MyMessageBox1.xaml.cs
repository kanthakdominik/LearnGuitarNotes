using System.Windows;


namespace Game
{
    /// <summary>
    /// Klasa ta używania jest do upewnienia się, czy użytkownik na pewno chce zamknąć grę.
    /// </summary>
    public partial class MyMessageBox1 : Window
    {
        /// <summary> 
        /// Konstruktor klasy MyMessageBox1Sound
        /// </summary> 
        public MyMessageBox1()
        {
            InitializeComponent();
        }
        /// <summary> 
        /// Metoda wywoływana po naciśnięciu przycisku OK, zamyka program
        /// </summary> 
        /// <param name="e">RoutedEventArgs</param> 
        /// <param name="sender">sender</param> 
        private void Button_Click_OK(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        /// <summary> 
        /// Metoda wywoływana po naciśnięciu przycisku Anuluj, anuluje zamykanie programu(wyłącza okienko z zapytaniem)
        /// </summary> 
        /// <param name="e">RoutedEventArgs</param> 
        /// <param name="sender">sender</param> 
        private void Button_Click_Anuluj(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
