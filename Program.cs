// Configuração do sistema
using design_patterns;

var ride = new Ride();
var passenger = new Passenger();
var driver = new Driver();

ride.AddObserver(passenger);
ride.AddObserver(driver);

// Pedido criado
Console.WriteLine("== Novo pedido criado! ==");
ride.ChangeStatus("Pedido em aberto");

// Motorista aceita o pedido
Console.WriteLine("\n== Motorista aceitou o pedido! ==");
ride.ChangeStatus("Pedido aceito");

// Integração com serviço de mapas
Console.WriteLine("\n== Obtendo rota para o destino... ==");
var map = new GoogleMapsAdapter();

var route = map.GetRoute("Origem XYZ", "Destino ABC");
Console.WriteLine($"Rota gerada: {route}");

// Gerar interface para passageiro e motorista
Console.WriteLine("\n== Gerando interface para Passageiro ==");
var passengerUI = new PassengerUIFactory();
passengerUI.CreateButton().Render();
passengerUI.CreateLayout().Render();

Console.WriteLine("\n== Gerando interface para Motorista ==");
var driverUI = new DriverUIFactory();
driverUI.CreateButton().Render();
driverUI.CreateLayout().Render();
