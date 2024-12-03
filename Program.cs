using design_patterns;

var ride = new Ride();
var passenger = new Passenger();
var driver = new Driver();
var admin = new Admin();

// Adiciona os observadores para a corrida
ride.AddObserver(passenger);
ride.AddObserver(driver);
ride.AddObserver(admin);

// Pedido criado
Console.WriteLine("== Novo pedido criado! ==");
ride.ChangeStatus("Pedido em aberto", "Origem XYZ", "Destino ABC");

Thread.Sleep(2000);

// Motorista aceita o pedido
Console.WriteLine("\n== Motorista aceitou o pedido! ==");
ride.ChangeStatus("Pedido aceito", "Origem XYZ", "Destino ABC");

Thread.Sleep(2000);

// Integração com serviço de mapas
Console.WriteLine("\n== Obtendo rota para o destino... ==");
var map = new GoogleMapsAdapter();
var route = map.GetRoute("Origem XYZ", "Destino ABC");
Console.WriteLine($"Rota gerada: {route}");

Thread.Sleep(2000);

// Gerar interface para passageiro e motorista
Console.WriteLine("\n== Gerando interface para Passageiro ==");
var passengerUI = new PassengerUIFactory();
passengerUI.CreateButton().Render();
passengerUI.CreateLayout().Render();

Console.WriteLine("\n== Gerando interface para Motorista ==");
var driverUI = new DriverUIFactory();
driverUI.CreateButton().Render();
driverUI.CreateLayout().Render();
