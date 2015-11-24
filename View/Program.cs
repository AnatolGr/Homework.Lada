using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework2;


namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Lada",'D');
            car.Color = Color.DarkRed;
            Driver driver = new Driver("Вольдемар", DateTime.Parse("10.12.2012"));
            driver.Category = "BC";
            car.ChangeOwner("о777оо", driver);
            driver.OwnCar(car);
            driver.Category = "BCD";
            car.ChangeOwner("о777оо", driver);
            driver.OwnCar(car);
            Console.WriteLine(driver.Car.CarNumber);
            Console.WriteLine(car.CarPassport.Owner.Name);
            Console.ReadKey();

        }
    }
}
