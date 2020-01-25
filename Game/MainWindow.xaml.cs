using System.Windows;
using System.Windows.Input;


namespace Game
{
    /// <summary>
    /// Klasa ta to  główna klasa gry, uruchamiana po starcie programu.
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Konstruktor klasy MainWindow
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metoda odpowiedzialna za rozpoczęcie nowej gry, otwiera okno pierwszego poziomu
        /// </summary>
        private void Button_New_Game_Click(object sender, RoutedEventArgs e)
        {
            Level_One game_level_one = new Level_One();
            game_level_one.Show();
            this.Hide();
        }
        /// <summary>
        /// Metoda odpowiedzialna otwarcie okna Info, służącego do nauki
        /// </summary>
        private void Button_Info_Click(object sender, RoutedEventArgs e)
        {
            Info game_info = new Info();
            game_info.Show();
            this.Hide();
        }
        /// <summary>
        /// Metoda odpowiedzialna za zamknięcie gry, wykorzystuje obiekt klasy MyMessageBox1
        /// </summary>
        private void Exit_button_Click(object sender, RoutedEventArgs e)
        {
            MyMessageBox1 msBox = new MyMessageBox1();
            msBox.Show();
        }
        /// <summary>
        /// Metoda odpowiedzialna za minimalizowanie gry
        /// </summary>
        private void Minimize_button_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        /// <summary>
        /// Metoda umożliwia zmianę położenia okna gry
        /// </summary>
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
