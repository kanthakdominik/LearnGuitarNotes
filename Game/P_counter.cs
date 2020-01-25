using System.ComponentModel;


namespace Game
{
    /// <summary>
    /// Klasa P_counter to klasa tworząca licznik w grze. Obiekt tej klasy jest potrzebny do bindingu z textbockem wyświetlającym 
    /// akutalną punktację w grze. Klasa ta dziedziczy z interfejsu INotifyPropertyChanged oraz korzysta z PropertyChangedEventHandler, co umożliwia nam automatyczną zmianę wyświetlanej wartości.
    /// </summary>
    public class P_counter : INotifyPropertyChanged
    {
        /// <summary> 
        /// publiczny Event PropertyChangedEventHandler, wymagany przez interfejs INotifyPropertyChanged
        /// </summary> 
        public event PropertyChangedEventHandler PropertyChanged;

        private int _Points_counter;
        /// <summary> 
        /// Dostęp do prywatnego pola _Points_counter
        /// </summary> 
        public int Points_counter
        {
            get { return _Points_counter; }
            set
            {
                _Points_counter = value;
                RaisePropertyChanged("Points_counter");
            }
        }
        /// <summary> 
        /// Metoda odpowiedzialna za automatyczną zmianę wartości
        /// </summary> 
        /// <param name="propertion_name">wartość(licznik), która się zmienia</param> 
        private void RaisePropertyChanged(string propertion_name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertion_name));
        }
        /// <summary> 
        /// Konstruktor klasy P_Counter
        /// </summary> 
        public P_counter(int Points_counter)
        {
            this.Points_counter = Points_counter;
        }
        /// <summary> 
        /// Metoda zwiększająca nasz licznik punktów. 
        /// </summary> 
        public void Increase_counter()
        {
            Points_counter++;
        }
        /// <summary> 
        /// Metoda zmniejszająca nasz licznik punktów. 
        /// </summary> 
        public void Decrease_counter()
        {
            Points_counter--;
        }
        /// <summary> 
        /// Metoda zwracająca licznik jako ciąg znaków.
        /// </summary> 
        public int ToInt()
        {
            return Points_counter;
        }
    }
}
