using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlyWeightPattern
{
    class PassportFactory
    {
        public HashSet<BuildingPassport> _passports = new HashSet<BuildingPassport>();
        BuildingPassport bp = new BuildingPassport();
        private static PassportFactory _passportInstance;

        private PassportFactory()
        {
            
        }

        public static PassportFactory GetInstance()
        {
            if(_passportInstance == null)
            {
                _passportInstance = new PassportFactory();
            }
            return _passportInstance;
        }
       

        public BuildingPassport GetPassport(int levels, int appartments, string buildingType)
        {

            bp.SetParam(levels, appartments, buildingType);
         
            if (_passports.Contains(bp))
            {
                return _passports.First(p => p.GetHashCode() == bp.GetHashCode());
            }
            else
            {
                _passports.Add(bp);
                return bp;
            }
        }
    }
}
