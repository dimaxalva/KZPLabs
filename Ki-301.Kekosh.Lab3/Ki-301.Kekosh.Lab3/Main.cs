namespace Ki_301.Kekosh.Lab3 {
    public class MainClass {
        public static void Main() {
            var laptop = new Laptop("Intel", 32, "5000M/h", 15);
            laptop.Battery = "rfverver";
            laptop.ConnectToWiFi("network1");
            laptop.TurnOn();
            laptop.TurnOff();
            laptop.Hibernate();
        }
    }
}
