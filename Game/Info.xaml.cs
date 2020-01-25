using System;
using System.IO;
using System.Media;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace Game
{
    /// <summary>
    /// Interaction logic for Info.xaml
    /// </summary>
    public partial class Info : Window
    {
        private SoundPlayer Button_Sound = new SoundPlayer();

        /// <summary>
        /// Konstruktor klasy Info
        /// </summary>
        public Info()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metoda odpowiedzialna za zamknięcie gry, wykorzystuje obiekt klasy MyMessageBox1
        /// </summary>
        /// <param name="e">RoutedEventArgs</param> 
        /// <param name="sender">sender</param> 
        private void Exit_button_Click(object sender, RoutedEventArgs e)
        {
            MyMessageBox1 msBox = new MyMessageBox1();
            msBox.Show();
        }
        /// <summary>
        /// Metoda odpowiedzialna za minimalizowanie gry
        /// </summary>
        /// <param name="e">RoutedEventArgs</param> 
        /// <param name="sender">sender</param> 
        private void Minimize_button_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        /// <summary>
        /// Metoda odpowiedzialna za powrót do Menu głównego
        /// </summary>
        /// <param name="e">RoutedEventArgs</param> 
        /// <param name="sender">sender</param> 
        private void Return_button_CLick(object sender, RoutedEventArgs e)
        {
            MainWindow main_window = new MainWindow();
            main_window.Show();
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
