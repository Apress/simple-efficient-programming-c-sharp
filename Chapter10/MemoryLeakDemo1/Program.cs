using System;

namespace MemoryLeakDemo1
{
    delegate void IdChangedHandler(object sender, IdChangedEventArgs eventArgs);

    class IdChangedEventArgs : EventArgs
    {
        public int IdNumber { get; set; }
    }
    class Sender
    {
        public event IdChangedHandler IdChanged;

        private int Id;
        public int ID
        {
            get
            {
                return Id;
            }
            set
            {
                Id = value;
                //Raise the event
                OnMyIntChanged(Id);
            }
        }

        protected void OnMyIntChanged(int id)
        {
            if (IdChanged != null)
            {
                //As suggested by compiler:
                //It is the simplified form of the following lines:
                //IdChangedEventArgs idChangedEventArgs = new IdChangedEventArgs();
                //idChangedEventArgs.IdNumber = id;

                IdChangedEventArgs idChangedEventArgs =
                new IdChangedEventArgs
                {
                    IdNumber = id
                };

                IdChanged(this, idChangedEventArgs);
            }
        }
    }
    class Receiver
    {
        public void GetNotification(object sender, IdChangedEventArgs e)
        {
            Console.WriteLine($"Sender changed the id to:{e.IdNumber}");
        }
    }
    class Program
    {

        static void Main()
        {
            Console.WriteLine("***Creating custom events and analyzing memory leaks.***");
            Sender sender = new Sender();
            Receiver receiver = new Receiver();
            RegisterNotifications(sender, receiver);
            UnRegisterNotification(sender, receiver);
            Console.ReadKey();
        }

        private static void RegisterNotifications(Sender sender, Receiver receiver)
        {
            for (int count = 0; count < 10000; count++)
            {
                //Registering too many events.
                sender.IdChanged += receiver.GetNotification;
                sender.ID = count;
            }
        }
        private static void UnRegisterNotification(Sender sender, Receiver receiver)
        {
            //Unregistering only one event.
            sender.IdChanged -= receiver.GetNotification;
        }
    }
}

