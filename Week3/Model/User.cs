using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Week3.Model
{
    public class User : INotifyPropertyChanged
    {

        private string name;

        public string Name
        {
            get { return name; }
            set 
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
