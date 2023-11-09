namespace Ki_301.Kekosh.Lab3 {
    public class Laptop : Computer {
        public string Battery { get; set; }
        public int ScreenSize { get; set; }
        public Laptop(string processor, int ramSize, string battery, int screenSize) : base(processor, ramSize) {
            Battery = battery;
            ScreenSize = screenSize;
        }
        public void ConnectToWiFi(string networkName) {
            Console.WriteLine($"Підключено до мережі Wi-Fi: {networkName}");
            LogActivity($"Підключено до мережі Wi-Fi: {networkName}");
        }

        public void Hibernate() {
            Console.WriteLine("Ноутбук перейшов у режим сну.");
            LogActivity("Ноутбук перейшов у режим сну.");
        }
    }
}
