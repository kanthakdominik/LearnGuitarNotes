using System;
using System.Windows;


namespace Game
{
    /// <summary>
    /// Klasa ta używana jest do wyświetlania różnych komunikatów z gry.
    /// </summary>
    public partial class MyMessageBox2 : Window
    {
        private string Text=String.Empty;
        private Game_Info text_g_info = null;
        /// <summary>
        /// Konstruktor klasy MyMessageBox2, tworzy on nowy obiekt klasy Game_Info, aby wyświetlany tekst był zmieniany automatycznie
        /// </summary>
        /// <param name="Text_from_game">przesłany tekst, który ma zostać wyświetlony w okienku</param> 
        public MyMessageBox2(string Text_from_game)
        {
            InitializeComponent();
            text_g_info = new Game_Info(Text);
            Text = Text_from_game;
            text_g_info.Override_String(Text_from_game);
            myTextBlock.DataContext = text_g_info;
        }
        /// <summary>
        /// Metoda wywoływana po naciśnięciu przycisku OK, zamyka okienko informacyjne
        /// </summary>
        /// <param name="e">RoutedEventArgs</param> 
        /// <param name="sender">sender</param> 
        private void Button_Click_OK(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
