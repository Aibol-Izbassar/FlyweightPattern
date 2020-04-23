using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeightPattern
{
    class Building
    {
        BuildingPassport Passport;
        public int Id { get; set; }
        public void PrintPassport()
        {
            Console.WriteLine($"{Id}  " +
                $"\n  {Passport.Levels} " +
                $"\n  {Passport.Appartments} " +
                $"\n  {Passport.BuildingType} ");
        }

        public Building(PassportFactory pf, int id, int levels, int appartments, string buildingType)
        {
            Id = id;
            Passport = pf.GetPassport(levels, appartments, buildingType);
        }
    }
}
