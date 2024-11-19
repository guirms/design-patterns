namespace design_patterns
{
    public interface IObserver
    {
        void Update(string status);
    }

    public class Passenger : IObserver
    {
        public void Update(string status)
        {
            Console.WriteLine($"[Passageiro] Notificação recebida: {status}");
        }
    }

    public class Driver : IObserver
    {
        public void Update(string status)
        {
            Console.WriteLine($"[Motorista] Notificação recebida: {status}");
        }
    }

    public class Ride
    {
        private readonly List<IObserver> _observers = [];
        private string _status = "";

        public void AddObserver(IObserver observer) => _observers.Add(observer);

        public void ChangeStatus(string newStatus)
        {
            _status = newStatus;
            NotifyObservers();
        }

        private void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_status);
            }
        }
    }
}
