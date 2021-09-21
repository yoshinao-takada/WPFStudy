using System.ComponentModel;

namespace UserControlTest
{
    public class UserControlTestData : INotifyPropertyChanged
    {
        private string text0;
        private string text1;

        public string Text0
        {
            get { return text0; }
            set { text0 = value; OnPropertyChanged("Text0"); }
        }

        public string Text1
        {
            get { return text1; }
            set { text1 = value; OnPropertyChanged("Text1"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
