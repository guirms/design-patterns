namespace design_patterns
{
    public interface IUIFactory
    {
        IButton CreateButton();
        ILayout CreateLayout();
    }

    public interface IButton
    {
        void Render();
    }

    public interface ILayout
    {
        void Render();
    }

    public class PassengerUIFactory : IUIFactory
    {
        public IButton CreateButton() => new PassengerButton();
        public ILayout CreateLayout() => new PassengerLayout();
    }

    public class PassengerButton : IButton
    {
        public void Render() => Console.WriteLine("[UI Passageiro] Botão exibido.");
    }

    public class PassengerLayout : ILayout
    {
        public void Render() => Console.WriteLine("[UI Passageiro] Layout exibido.");
    }

    public class DriverUIFactory : IUIFactory
    {
        public IButton CreateButton() => new DriverButton();
        public ILayout CreateLayout() => new DriverLayout();
    }

    public class DriverButton : IButton
    {
        public void Render() => Console.WriteLine("[UI Motorista] Botão exibido.");
    }

    public class DriverLayout : ILayout
    {
        public void Render() => Console.WriteLine("[UI Motorista] Layout exibido.");
    }

    public class AdminUIFactory : IUIFactory
    {
        public IButton CreateButton() => new AdminButton();
        public ILayout CreateLayout() => new AdminLayout();
    }

    public class AdminButton : IButton
    {
        public void Render() => Console.WriteLine("[UI Admin] Botão exibido.");
    }

    public class AdminLayout : ILayout
    {
        public void Render() => Console.WriteLine("[UI Admin] Layout exibido.");
    }
}
