using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace NotifyPropertyChanged_traning_ex5._4
{
    class Book : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private static int counter;
        private int _id;
        private string _name;
        private string _publisher;
        private List<Author> _authors = new List<Author>();

        #region Constructor
        public Book(string name)
            : this(name, "Not specified", new Author[] { new Author("Not specified") })
        {
        }

        public Book(string name, string publisher)
            : this(name, publisher, new Author[] { new Author("Not specified")})
        {
        }

        public Book(string name, Author[] authors)
            : this(name, "Not specified", authors)
        {
        }

        public Book(string name, string publisher, Author[] authors)
        {
            _id = ++counter;
            if (string.IsNullOrWhiteSpace(name))
                Exep("Wrong name.");
            _name = name;
            if (string.IsNullOrWhiteSpace(publisher))
                Exep("Wrong publisher.");
            _publisher = publisher;
            foreach(var el in authors)
            {
                if (string.IsNullOrWhiteSpace(el.Name))
                    Exep("Wrong authors list.");
            }
            _authors.AddRange(authors);
        }

        #endregion

        #region Property

        public int Id
        {
            get { return _id; }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    Exep("Wrong name.");
                if (value != _name)
                {
                    _name = value;
                    NotifyPropertyChanged(value);
                }
            }
        }

        public string Publisher
        {
            get { return _publisher; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    Exep("Wrong publisher.");
                if(value != _publisher)
                {
                    _publisher = value;
                    NotifyPropertyChanged(value);
                }
            }
        }

        public Author[] Authors
        {
            get { return _authors.ToArray(); }
            set
            {
                Author[] tmp = _authors.ToArray();
                bool eql = false;
                foreach(var el in value)
                {
                    if (string.IsNullOrWhiteSpace(el.Name))
                        Exep("Wrong authors list.");
                }
                if(value.Length == tmp.Length)
                {
                    for(int i =0; i < tmp.Length; ++i)
                    {
                        if(tmp[i] != value[i])
                        {
                            eql = true;
                        }
                    }
                }
                else { eql = true; }
                if(eql)
                {
                    _authors.Clear();
                    _authors.AddRange(value);
                    NotifyPropertyChanged("Authors");
                }

            }
        }

        #endregion

        private void NotifyPropertyChanged(string property)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
        private void Exep(string mess)
        {
            throw new ArgumentException(mess);
        }
    }
}
