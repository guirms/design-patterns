namespace design_patterns
{
    public interface IObserver
    {
        void Update(string status, string origin, string destination);
    }

    public class Passenger : IObserver
    {
        public void Update(string status, string origin, string destination)
        {
            Console.WriteLine($"[Passageiro] Notificação recebida: {status} de {origin} para {destination}");
        }
    }

    public class Driver : IObserver
    {
        public void Update(string status, string origin, string destination)
        {
            Console.WriteLine($"[Motorista] Notificação recebida: {status} de {origin} para {destination}");
        }
    }

    public class Admin : IObserver
    {
        public void Update(string status, string origin, string destination)
        {
            Console.WriteLine($"[Admin] Acompanhando status da corrida: {status} de {origin} para {destination}");
        }
    }

    public class Ride
    {
        private readonly List<IObserver> _observers = new();
        private string _status;
        private string _origin;
        private string _destination;

        public void AddObserver(IObserver observer) => _observers.Add(observer);

        public void ChangeStatus(string newStatus, string origin, string destination)
        {
            _status = newStatus;
            _origin = origin;
            _destination = destination;
            NotifyObservers();
        }

        private void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_status, _origin, _destination);
            }
        }
    }
}
