# Паттерн Адаптер (Adapter) — Пример на C#

## Описание

Этот проект демонстрирует использование паттерна "Адаптер" для преобразования данных из одной системы измерений в другую. В данном примере у нас есть класс, работающий в **метрической системе измерений** (метры и килограммы), и клиент, который ожидает данные в **британской системе** (футы и фунты). 

Паттерн "Адаптер" позволяет объединить их, создавая единый интерфейс для клиента.

## Структура

1. **ITarget**: Интерфейс, который ожидает клиент. Определяет метод `GetMeasurementsInImperial()`, возвращающий данные в британской системе.
2. **Adaptee**: Класс, работающий в метрической системе, возвращает данные в метрах и килограммах.
3. **Adapter**: Класс, адаптирующий интерфейс `Adaptee` под интерфейс `ITarget`. Преобразует метрические значения в британские.
4. **Client**: Клиентский код, который работает с `ITarget`, ожидая данные в британской системе (футы и фунты).

## Как это работает

1. **Adaptee** предоставляет данные в метрах и килограммах.
2. **Adapter** конвертирует данные из метрической системы в британскую, используя формулы преобразования (1 метр = 3.28084 футов, 1 килограмм = 2.20462 фунтов).
3. **Client** запрашивает данные у `ITarget` и получает их в нужной системе, не зная о существовании `Adaptee`.