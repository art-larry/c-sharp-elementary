using System;
using System.ComponentModel;


namespace NotifyPropertyChanged_traning_ex5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = new Author("Add");
            n.PropertyChanged += Signal;
            Console.WriteLine(n.ToString());

            n.Name = "EEE";

            Console.WriteLine(n.ToString());


            var n1 = new Author("bbb");
            n1.PropertyChanged += Signal;
            Console.WriteLine(n1.ToString());

            n1.Name = "DDDDDDD";

            Console.WriteLine(n1.ToString());

            var ttt = new Book("Book");
            ttt.PropertyChanged += Signal;
            ttt.Authors = new Author[] { new Author("FFF") };
        }

        static void Signal(object sender, PropertyChangedEventArgs e)
        {
            Console.WriteLine("Sender: {0}; Arg: {1}", sender.ToString(), e.PropertyName);
        }
    }
}
