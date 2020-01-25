using System.ComponentModel;


namespace Game
{
    /// <summary>
    /// Klasa Sound to klasa odpowiedzialna za wyświetlane informacje w grze. Obiekt tej klasy jest potrzebny do bindingu z textbockem wyświetlającym 
    /// wylosowaną nutę, dźwięk, któy mamy wskazać. Klasa ta dziedziczy z interfejsu INotifyPropertyChanged oraz korzysta z PropertyChangedEventHandler, co umożliwia nam automatyczną zmianę wyświetlanej wartości.
    /// </summary>
    public class Sound : INotifyPropertyChanged
    {
        /// <summary> 
        /// publiczny Event PropertyChangedEventHandler, wymagany przez interfejs INotifyPropertyChanged
        /// </summary> 
        public event PropertyChangedEventHandler PropertyChanged;
        
        private string _Name_of_sound;
        /// <summary> 
        /// Dostęp do prywatnego pola _Name_of_sound
        /// </summary> 
        public string Name_of_sound
        {
            get { return _Name_of_sound; }
            set { _Name_of_sound = value;
                RaisePropertyChanged("Name_of_sound");
                }
        }
        /// <summary> 
        /// Metoda odpowiedzialna za automatyczną zmianę wartości
        /// </summary> 
        /// <param name="propertion_name">wartość(nuta), która się zmienia</param> 
        private void RaisePropertyChanged(string propertion_name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertion_name));
        }
        /// <summary> 
        /// Konstruktor klasy Sound
        /// </summary> 
        public Sound(string Name_of_sound)
        {
            this.Name_of_sound = Name_of_sound;
        }
        

    }
}
