namespace lab6 {
    public class MainClass {
        public static void Main() {
            ShipHold<string> fruitHold = new ShipHold<string>();
            fruitHold.AddItem("Apple");
            fruitHold.AddItem("Banana");
            fruitHold.AddItem("Orange");

            foreach (var item in fruitHold.GetItems()) {
                Console.WriteLine(item);
            }
            fruitHold.RemoveItem("Apple");
            var isContains = fruitHold.ContainsItem("Apple");
            Console.WriteLine(isContains);

        }
    }
}
