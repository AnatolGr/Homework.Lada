using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    public class Car
    {
        public readonly CarPassport CarPassport = new CarPassport();

        public Car(string model, char category)
        {
            Model = model;
            Category = category;
            //_name = name;
        }

        public readonly char Category;

        public Color Color { get; set; } = Color.CornflowerBlue;

        //public string Name
        //{
        //    get { return _name; }
            
        //}

        public string CarNumber { get; private set; }

       // private string _name;

        

        public readonly string Model;

        public void ChangeOwner(string newNomber, Driver driver )
        {
            CarPassport.Owner = driver;
            CarNumber = newNomber;
        }
    }
}
