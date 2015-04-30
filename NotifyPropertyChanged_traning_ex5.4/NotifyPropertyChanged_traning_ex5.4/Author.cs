using System;
using System.ComponentModel;

namespace NotifyPropertyChanged_traning_ex5._4
{
    class Author : INotifyPropertyChanged
    {
        static int counter;
        private int _id;
        private string _name;

        public Author(string name)
        {
            _name = name;
            _id = ++counter;
        }

        public int Id
        {
            get { return _id; }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException();
                if(value != _name)
                {
                    _name = value;
                    NotifyPropertyChanged(value);
                }
            }
        }

        private void NotifyPropertyChanged(string property)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public override string ToString()
        {
            return String.Format("ID: {0}, Name: {1}", Id, Name);
        }
    }
}
