using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    public class Driver
    {
        public readonly DateTime LicenceDate;

        public readonly string Name;

        public Driver(String name, DateTime time)
        {
            Name = name;
            LicenceDate = time;

        }
    
        public int Experience
        {
            get
            {

                return (int) ((DateTime.Now - LicenceDate).TotalDays/365);
            }
        }

        private bool[] _arrayOfCategory = new bool[6] {false, false, false, false, false, false};

        private string _categ = "ABCDEF";

        private string _category;

        private Car _car;

        public string Category
        {
            get
            {
                _category = "";
                for (var i = 0; i < 6; i++)
                {
                    if (_arrayOfCategory[i] == true)
                    {
                        _category += (char) (i + 65);
                    }
                }
                return _category;

            }
            set
            {
                for (var i = 0; i < value.Length; i++)
                {
                    if (_categ.IndexOf(value[i]) != -1)
                    {
                        _arrayOfCategory[(int) (value[i]) - 65] = true;
                        //_category = value;
                    }
                }

            }
        }

        public void OwnCar(Car car)
        {
            try
            {
                if (_arrayOfCategory[(int)(car.Category)-65]==true)
                    _car = car;
                else
                    throw new Exception();
            }
            catch (Exception) 
            {
                Console.WriteLine("Водитель не имеет нужной категории!");
            }
            
        }

        public Car Car
        {
            get { return _car; }
        }
    }
}
