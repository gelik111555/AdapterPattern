using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Interfaces;

/// <summary>
/// Интерфейс, ожидаемый клиентом.
/// </summary>
internal interface ITarget
{
    (double Feet, double Pounds) GetMeasurementsInImperial();
}
