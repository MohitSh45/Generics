using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _301297059_Sharma__Lab_1
{
    internal class Medals
    {
       
        public string Athlete { get;}
        public string Year { get;}
        public string Gold_Medals { get; }
        public string Silver_Medals { get;}
        public string Bronze_Medals {  get;}
        
        public Medals(string athlete,string year,string gold,string silver,string bronze)
        {
            Athlete = athlete;
            Year = year;
            Gold_Medals = gold;
            Silver_Medals = silver;
            Bronze_Medals = bronze;
        }
        public override string ToString()
        {
            return $" \nAthlete: {Athlete},\nYear: {Year} \nGold Medals: {Gold_Medals},Silver Medals: {Silver_Medals}, Bronze Medals: {Bronze_Medals}";
        }
        public static Medals Parse(string line)
        {
            var parts = line.Split(',');


            return new Medals(parts[0], parts[1], parts[2], parts[3], parts[4]);
        }
    }
}
