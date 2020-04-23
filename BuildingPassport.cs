using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeightPattern
{
    class BuildingPassport
    {
        public int Levels { get; set; }
        public int Appartments { get; set; }
        public string BuildingType { get; set; }
        public override int GetHashCode()
        {
            string str = BuildingType + "|" 
                + Levels + "|" 
                + Appartments;
            return str.GetHashCode();
        }

        public void SetParam(int levels, int appartments, string buildingType)
        {
            Levels = levels;
            Appartments = appartments;
            BuildingType = buildingType;
        }
    }
}
