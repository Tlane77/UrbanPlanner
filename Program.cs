using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            // Build this city
            City Nashville = new City("City of Nashville");
            Nashville.electMayor("Jackson");

            Building FiveOneTwoEighthTower = new Building("512 Eighth Avenue");
            FiveOneTwoEighthTower.Width = 3000;
            FiveOneTwoEighthTower.Depth = 1700;
            FiveOneTwoEighthTower.Stories = 77;
            FiveOneTwoEighthTower.Construct();
            FiveOneTwoEighthTower.Purchase("CryptoCurrency");
            Nashville.addBuilding(FiveOneTwoEighthTower);

            Building ONYX = new Building("777 Stone Ave");
            ONYX.Width = 300;
            ONYX.Depth = 700;
            ONYX.Stories = 77;
            ONYX.Construct();
            ONYX.Purchase("NanoBitcoin");
            ONYX.addBuilding(ONYX);

            Building Diamond = new Building("333 Sparkle Court");
            Diamond.Width = 1300;
            Diamond.Depth = 1777;
            Diamond.Stories = 200;
            Diamond.Construct();
            Diamond.Purchase("SolarTech");
            Diamond.addBuilding(Diamond);

            Building Topaz = new Building("333 Blue Lennox Ln");
            Diamond.Width = 1700;
            Diamond.Depth = 7000;
            Diamond.Stories = 300;
            Diamond.Construct();
            Diamond.Purchase("SolarTech");
            Diamond.addBuilding(Diamond);

            Nashville.Greeting();

            foreach (Building building in Nashville.allBuildings)
            {
                building.DisplayInformation();
                Console.WriteLine();
            }

        }
    }
}