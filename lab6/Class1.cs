using System;

public class Program()
{
     static void Main(string[] args) {
        ShipHold<string> fruitHold = new ShipHold<string>();
        fruitHold.AddItem("Apple");
        fruitHold.AddItem("Banana");
        fruitHold.AddItem("Orange");

        // Створення трюму для контейнерів
        ShipHold<Container> containerHold = new ShipHold<Container>();
        containerHold.AddItem(new Container("Container 1", 1000));
        containerHold.AddItem(new Container("Container 2", 1500));
    }
    
}
