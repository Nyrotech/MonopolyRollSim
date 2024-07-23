using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningC_
{
    internal class Program
    {
        enum Properties
        {
            Go = 1,
            MediterraneanAvenue,
            CommunityChest1,
            BalticAvenue,
            IncomeTax,
            ReadingRailroad,
            OrientalAvenue,
            Chance1,
            VermontAvenue,
            ConnecticutAvenue,
            Jail = 11,
            StCharlesPlace,
            ElectricCompany,
            StatesAvenue,
            VirginiaAvenue,
            PennsylvaniaRailroad,
            StJamesPlace,
            CommunityChest2,
            TennesseeAvenue,
            NewYorkAvenue,
            FreeParking,
            KentuckyAvenue,
            Chance2,
            IndianaAvenue,
            IllinoisAvenue,
            B_OStation,
            AtlanticAvenue,
            VentnorAvenue,
            WaterWorks,
            MarvinGardens,
            GoToJail,
            PacificAvenue,
            NorthCarolinaAvenue,
            CommunityChest3,
            PennsylvaniaAvenue,
            ShortLine,
            Chance3,
            ParkPlace,
            LuxuryTax,
            Boardwalk
        }
        static void Main(string[] args)
        {
            //Create a dictionary to keep track of counts 
            var Counts = new Dictionary<Properties, int>();
            //Create Random object to simulate dice throw
            Random Dice = new Random();
            int roll = Dice.Next(2, 13);

            //Assign all the counts for properties to Zero
            foreach (Properties property in Enum.GetValues(typeof(Properties)))
            {
               Counts[property] = 0;
            }


            //Ask User for the Number of times they want to simulate a Dice roll.
            Console.WriteLine("Monopoly Roll Simulator");
            Console.WriteLine("Please Enter the number of times you wish to simulate a dice roll");
            int Sim_Rolls = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < Sim_Rolls; i++) { 
                
                roll = Dice.Next(2, 13);
                int position = (i % 40 + roll) % 40;

                Properties Landed = (Properties)(position + 1);

                if (Counts.ContainsKey(Landed))
                {
                    Counts[Landed] += 1;
                }
            }

            foreach (var kvp in Counts)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            var MostLanded = Counts.FirstOrDefault(x => x.Value == Counts.Values.Max());
            Console.WriteLine($"Rolls simulated {Sim_Rolls} of times");
            Console.WriteLine($"The most rolled property was {MostLanded}");
            Console.ReadLine();
        }
    }
}
