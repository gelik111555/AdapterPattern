using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern;

/// <summary>
/// Класс с несовместимым интерфейсом, который требуется адаптировать.
/// </summary>
internal class Adaptee
{
    public (double Meters, double Kilograms) GetMeasurementsInMetric()
    {
        // Пример данных в метрах и килограммах
        return (10, 70);  // 10 метров и 70 килограммов
    }
}
