using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CollectionsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            run();
            //run1(); Collections lab problem one
        }
        public void run()
        {
            Dictionary<string, Product> catalogDictionary = new Dictionary<string, Product>();
            Product p1 = new Product("Breakfast food", 10, "Kellogs");
            Product p2 = new Product("Bathroom Hygiene", 5, "Loreal");
            Product p3 = new Product("Dinner Utensil", 13, "Ginsu Knives");
            catalogDictionary.Add("Cereal", p1);
            catalogDictionary.Add("Shampoo", p2);
            catalogDictionary.Add("Knives", p3);

            foreach (KeyValuePair<string, Product> s in catalogDictionary)
            {
                s.Value.Print();
            }
        }
        public void run1()
        {
            List<Person> PeopleList = new List<Person>();
            string[] FullName = new string[2];
            StreamReader inFile = new StreamReader("PersonFile.txt");
            string line = "";
            char[] deliminatingChars = { ' ' };
            do
            {
                line = inFile.ReadLine();
                PeopleList.Add(new Person(line));
            } while ((inFile.Peek()) != -1);

            foreach (Person p in PeopleList)
            {
                p.Print();

            }
        }
    }
}
