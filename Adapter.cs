using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdapterPattern.Interfaces;

namespace AdapterPattern;

/// <summary>
/// Класс, реализующий Target, который оборачивает Adaptee, адаптируя его интерфейс под нужды клиента.
/// </summary>
internal class Adapter : ITarget
{
    private readonly Adaptee _adaptee;

    public Adapter(Adaptee adaptee)
    {
        _adaptee = adaptee;
    }

    public (double Feet, double Pounds) GetMeasurementsInImperial()
    {
        var (meters, kilograms) = _adaptee.GetMeasurementsInMetric();

        // Преобразование метров в футы (1 метр = 3.28084 фута)
        double feet = meters * 3.28084;

        // Преобразование килограммов в фунты (1 килограмм = 2.20462 фунта)
        double pounds = kilograms * 2.20462;

        return (feet, pounds);
    }
}
