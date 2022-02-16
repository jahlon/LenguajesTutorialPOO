using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialPOO
{
    class EjemploDiccionario
    {
        static void Main(string[] args)
        {
            IDictionary<int, string> numberNames = new Dictionary<int, string>();
            numberNames.Add(1, "One"); //adding a key/value using the Add() method
            numberNames.Add(2, "Two");
            numberNames.Add(3, "Three");

            foreach(KeyValuePair<int, string> kvp in numberNames)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }

            var cities = new Dictionary<string, string>(){
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"}
            };

            foreach (var kvp in cities)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

            Console.WriteLine(cities["UK"]); //prints value of UK key
            Console.WriteLine(cities["USA"]);//prints value of USA key

            if( cities.ContainsKey("France"))
                Console.WriteLine(cities["France"]);

            string result;

            if (cities.TryGetValue("France", out result))
            {
                Console.WriteLine(result);
            }

            cities["UK"] = "Nuevo valor";
            cities.Remove("USA");


            Console.ReadLine();
        }
        
    }
}
