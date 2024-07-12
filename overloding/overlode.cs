using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloding
{
    public class overlode
    {
      
      public List<string> cities = new List<string>();

        public void addcity(string name)
        {
            cities.Add(name);
   
        }
        public void addcity(List<string> name)
        {
            cities.AddRange(name);
        }
        public void find(string city)
        {
            Console.WriteLine("enter one city name: ");
            
            foreach (string n in cities)
            {
                if (city == n)
                {
                    Console.WriteLine(city);
                }
            }
        }
        public void find(string city, string city1)
        {
            foreach (string n in cities)
            {
                if(city == n || city1 == n)
                {
                    Console.WriteLine(city);
                }
            }
        }
        public void find(List<string> city)
        {
            foreach(string name in cities)
            {
                if(city.Contains(name))
                {
                    Console.WriteLine($"{name}");
                }
            }
        }
    }
}
