using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsLab
{
    class Person
    {
        String name;
        int id;
        int numberOfPeople;

        public Person()
        {

        }
       public Person(string _Name)
        {
            name = _Name;
            id = numberOfPeople++;
        }
        public void Print()
        {
            string[] s = name.Split(' ');
            Console.WriteLine("FirstName:{0}  LastName:{1}",s[0],s[1]);
        }
    }
}
