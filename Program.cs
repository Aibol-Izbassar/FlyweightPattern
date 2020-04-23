using System;

namespace FlyWeightPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            PassportFactory p = PassportFactory.GetInstance();

            Building b = new Building(p, 1, 5, 5, "Brick");
            Building b1 = new Building(p, 2, 5, 5, "concrete ");
            Building b2= new Building(p, 3, 5, 5, "concrete ");
            Building b3 = new Building(p, 4, 5, 5, "Brick");
            Building b4 = new Building(p, 5, 5, 5, "concrete ");
            Building b5 = new Building(p, 6, 5, 5, "Brick");
            Building b6 = new Building(p, 7, 5, 5, "concrete ");
            Building b7 = new Building(p, 8, 5, 5, "Brick");
            Building b8 = new Building(p, 9, 5, 5, "Brick");


        }
    }
}
