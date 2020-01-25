using System.ComponentModel;


namespace Game
{
    /// <summary>
    /// Klasa Game_Info to klasa odpowiedzialna za wyświetlane informacje w grze. Obiekt tej klasy jest potrzebny do bindingu z textbockem wyświetlającym 
    /// czy dany ruch w grze był prawidłowy czy błędny. Klasa ta dziedziczy z interfejsu INotifyPropertyChanged oraz korzysta z PropertyChangedEventHandler, co umożliwia nam automatyczną zmianę wyświetlanej wartości.
    /// </summary>
    public class Game_Info : INotifyPropertyChanged
    {
        /// <summary> 
        /// publiczny Event PropertyChangedEventHandler, wymagany przez interfejs INotifyPropertyChanged
        /// </summary> 
        public event PropertyChangedEventHandler PropertyChanged;

        private string _Text_to_display;
        /// <summary> 
        /// Dostęp do prywatnego pola _Text_to_display
        /// </summary> 
        public string Text_to_display
        {
            get { return _Text_to_display; }
            set
            {
                _Text_to_display = value;
                RaisePropertyChanged("Text_to_display");
            }
        }
        /// <summary> 
        /// Metoda odpowiedzialna za automatyczną zmianę wartości
        /// </summary> 
        /// <param name="text">wartość(tekst), która się zmienia</param> 
        private void RaisePropertyChanged(string text)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(text));
        }
        /// <summary> 
        /// Konstruktor klasy Game_Info
        /// </summary> 
        public Game_Info(string Text_to_display)
        {
            this.Text_to_display = Text_to_display;
        }
        /// <summary> 
        /// Metoda przekazująca ciąg znaków z klas gry do klasy Game_Info
        /// </summary> 
        /// <param name="text_to_override">wartość(tekst), którą przekazujemy</param>  
        public void Override_String(string text_to_override)
        {
            Text_to_display = text_to_override;
        }
    }

}
