namespace design_patterns
{
    public interface IMap
    {
        string GetRoute(string origin, string destination);
    }

    public class GoogleMaps
    {
        public string GetRoute(string start, string end)
        {
            return $"Rota do Google Maps de {start} para {end}";
        }
    }

    public class Mapbox
    {
        public string FindRoute(string pointA, string pointB)
        {
            return $"Rota do Mapbox de {pointA} para {pointB}";
        }
    }

    public class GoogleMapsAdapter : IMap
    {
        private readonly GoogleMaps _googleMaps = new();

        public string GetRoute(string origin, string destination)
        {
            return _googleMaps.GetRoute(origin, destination);
        }
    }

    public class MapboxAdapter : IMap
    {
        private readonly Mapbox _mapbox = new();

        public string GetRoute(string origin, string destination)
        {
            return _mapbox.FindRoute(origin, destination);
        }
    }
}
