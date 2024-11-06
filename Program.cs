using AdapterPattern;
using AdapterPattern.Interfaces;

class Program
{
    static void Main()
    {
        // Инициализируем метрическую систему (старый код)
        Adaptee adaptee = new Adaptee();

        // Создаем адаптер, чтобы преобразовать данные для клиента
        ITarget adapter = new Adapter(adaptee);

        // Клиентский код работает с интерфейсом ITarget и получает данные в футам и фунтах
        Client client = new Client();
        client.DisplayMeasurements(adapter);
    }
}
