using System;
// using VendingMachine.Interfaces

namespace VendingMachine.Models
{
  abstract class FoodItem //: IBuyable
  {
    public string Name { get; set; }
    public bool isEdible { get; set; }
    public FoodItem(string name)
    {
      Name = name;
      isEdible = true;
    }
  }
}
