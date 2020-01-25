using System;
using System.Collections.Generic;
using System.IO;
using System.Media;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Game
{
    /// <summary>
    /// Klasa ta jest odpowiedzialna za pierwszy poziom gry
    /// </summary>
    public partial class Level_One : Window
    {
        private SoundPlayer Button_Sound = new SoundPlayer();
        Random random = new Random();
        private Sound my_sound = null;
        private P_counter my_P_counter1 = null;
        private Game_Info my_Game_Info = null;
        private string random_sound = String.Empty;
        List<string> sound_list = null;
        private string Game_Info_Text = String.Empty;

        /// <summary>
        /// Konstruktor klasy Level_One, wywoływana jest w nim funkcja InitSounds()
        /// </summary>
        public Level_One()
        {
            InitializeComponent();
            InitSounds();
        }
        /// <summary>
        /// Metoda ta jest odpowiedzialna za zainicjowanie i wylosowanie nuty, tworzy obiekty typu Sound, P_counter oraz ustawia konteksty do zbindowania ich.
        /// </summary>
        private void InitSounds()
            {
               
           sound_list = new List<string>
            {
                "E2","F2","Fis2", "G2","Gis2","A2","B2","H2","C3","Cis3","D3","Dis3","E3","F3","Fis3","G3","Gis3","A3",
                "B3","H3","C4","Cis4","D4","Dis4","E4","F4","Fis4","G4","Gis4","A4","B4","H4","C5","Cis5","D5","Dis5","E5"
            };
          
            random_sound = sound_list[random.Next(sound_list.Count)];
            my_sound = new Sound(random_sound);
            myForm.DataContext = my_sound;

            my_Game_Info = new Game_Info(Game_Info_Text);
            Game_Info.DataContext = my_Game_Info;
            my_P_counter1 = new P_counter(0);
            texBox_points_counter.DataContext = my_P_counter1;
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
        /// Metoda odpowiedzialna za otwarcie okna z pomocą do gry
        /// </summary>
        /// <param name="e">RoutedEventArgs</param> 
        /// <param name="sender">sender</param> 
        private void Help_Button_CLick(object sender, RoutedEventArgs e)
        {
            HelpInfo my_Help_Info = new HelpInfo();
            my_Help_Info.Show();
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
        /// Sprawdza także, czy kliknięty przycisk jest poprawny, czy błędny, powodując odpowiednie wyświetlenie komunikatu.
        /// Następnie losuje kolejny dźwięk. Sprawdza także czy mamy już wystarczającą liczbę punktów, aby przejść do poziomu 
        /// drugiego, lub też, jeśli jest za mała - kończy grę.
        /// </summary>
        /// <param name="e">RoutedEventArgs</param> 
        /// <param name="sender">sender</param> 
        private void MyClickFunction(object sender, RoutedEventArgs e)
        {
            var tag = ((Button)sender).Tag;
            string location = Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString() + "\\Sounds\\" + tag.ToString() + ".wav";
            Button_Sound.SoundLocation = location;
            Button_Sound.Play();

            string sound_to_check = (sender as Button).Tag.ToString();
            if (random_sound == sound_to_check)
            {
                Game_Info.Foreground = new SolidColorBrush(Colors.Green);
                my_Game_Info.Override_String("DOBRZE!");
                my_P_counter1.Increase_counter();
            }
            else
            {
                Game_Info.Foreground = new SolidColorBrush(Colors.Red);
                my_Game_Info.Override_String("ŹLE!");
                my_P_counter1.Decrease_counter();
            }
            random_sound = sound_list[random.Next(sound_list.Count)];
            my_sound = new Sound(random_sound);
            myForm.DataContext = my_sound;

            if (my_P_counter1.ToInt() <= -5)
            {
                MyMessageBox2 MyMsBox_Defeat = new MyMessageBox2("PRZEGRAŁEŚ GRĘ, SPRÓBUJ JESZCZE RAZ :)");
                MyMsBox_Defeat.Show();
                MainWindow main_window = new MainWindow();
                main_window.Show();
                this.Close();
            }
            else if (my_P_counter1.ToInt() >=5)
            {
                MyMessageBox2 MyMsBox_Win = new MyMessageBox2("PRZECHODZISZ DO POZIOMU DRUGIEGO");
                MyMsBox_Win.Show();
                Level_Two game_level_two = new Level_Two();
                game_level_two.Show();
                this.Close();
            }
        }
    }
}
