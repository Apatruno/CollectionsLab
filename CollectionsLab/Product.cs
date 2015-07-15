using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsLab
{
    class Product
    {
      string description;
      int cost;
      string manufacturer;
   
    public Product()//default constructor
{
   
}
    public Product( string _description, int _cost ,string _manufacturer)
{
    description = _description;
    cost = _cost;
    manufacturer = _manufacturer;
}
    public void Print()
    {
        Console.WriteLine("Description: "+this.description + "Cost: \t" + this.cost.ToString("c2") + "Manufacturer: \t" + this.manufacturer);
    }
 }
}
