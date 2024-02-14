using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _301297059_Sharma__Lab_1
{
    internal static class MedalManager
    {
        private static List<Medals> Medal = new List<Medals>();
        private static string filename = "Medals - Greatest Gold Medalist.csv";


        static MedalManager() {
            if (File.Exists(filename))
            {
                foreach (var line in File.ReadLines(filename))
                {
                    Medals Medals= Medals.Parse(line);
                    Medal.Add(Medals);
                }

            }

        }
        public static void show()
        {
            foreach(var medals in Medal)
            {
                Console.WriteLine(medals);
            }
        }
        public static void add()
        {
            Medal.Add(new Medals("Mohit Sharma", "2020", "3", "2", "2"));
            Medal.Add(new Medals("Rahul Dravid", "2020", "5", "2", "2"));

        }
        public static void delete()
        {
            Medal.RemoveAt(181);
        }
        public static IEnumerable<Medals> Search<T>(Func<Medals, T> keySelector, T searchKey)
        {
            foreach (var medalist in Medal)
            {
                if (EqualityComparer<T>.Default.Equals(keySelector(medalist), searchKey))
                {
                    yield return medalist;
                }
            }
        }
    }
}
