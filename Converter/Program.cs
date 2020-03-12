using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    class BaseConverter
    {
        public int temp = 25;
        public BaseConverter(int temp) 
        {
            this.temp = temp;
        }
        public BaseConverter() { }

        public void KelvinToCelcius()
        {
            Console.WriteLine($"Kelvins: {temp}\nCelcius: {temp-273}\n---------");
        }
        public void FahrenheitToCelcius()
        {
            Console.WriteLine($"Fahrenheits: {temp}\nCelcius: {(temp-32) * 5/9}\n---------");
        }
        public void CelciusToKelvin()
        {
            Console.WriteLine($"Celcius: {temp}\nKelvins: {temp + 273}\n---------");
        }
        public void FahrenheitToKelvin()
        {
            Console.WriteLine($"Fahrenheits: {temp}\nKelvins: {((temp - 32) * 5 / 9) - 273}\n---------");
        }
        public void CelciusToFahrenheit()
        {
            Console.WriteLine($"Celcius: {temp}\nFahrenheits: {(temp * 9 / 5) + 32}\n---------");
        }

        public void KelvinsToFahrenheit()
        {
            Console.WriteLine($"Kelvins: {temp}\nFahrenheits: {((temp-273) * 9 / 5) + 32}\n---------");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Temperature: ");
            int temp = Convert.ToInt32(Console.ReadLine());
            BaseConverter cnv = new BaseConverter(temp);
            cnv.KelvinToCelcius();
            cnv.KelvinsToFahrenheit();
            cnv.CelciusToKelvin();
            cnv.FahrenheitToKelvin();
            cnv.CelciusToFahrenheit();
            cnv.KelvinsToFahrenheit();
            Console.ReadKey();
        }
    }
}
