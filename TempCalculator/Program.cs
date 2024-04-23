


Console.WriteLine("If you want to transfer Fahrenheit to Celsius type 1");

Console.WriteLine("If you want to transfer Celsius to Fahrenheit type 2");

int way = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter the temperature you want to convert: ");

int sum = Int32.Parse(Console.ReadLine());


switch (way)
{
    case 1:
        ConverToCelcius(sum);
        break;

    case 2:
        ConverToFahrenheit(sum);
        break;

    default:
        Console.WriteLine("Invalid amount");
        break;
}


static void ConverToCelcius(int sum)
{
    Console.WriteLine($"{sum} °F = {(sum - 32) * 5 / 9} °C");
}

static void ConverToFahrenheit(int sum)
{
    Console.WriteLine($"{sum} °C = {(sum * 9) / 5 + 32} °F");
}