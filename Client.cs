using AdapterPattern.Interfaces;

namespace AdapterPattern;

internal class Client
{
    public void DisplayMeasurements(ITarget target)
    {
        var (feet, pounds) = target.GetMeasurementsInImperial();
        Console.WriteLine($"Рост: {feet} футов, Вес: {pounds} фунтов");
    }
}
