public abstract class Computer {
    private string processor;
    private int ramSize;
    private string hardDrive;

    public Computer(string processor, int ramSize, string hardDrive) {
        this.processor = processor;
        this.ramSize = ramSize;
        this.hardDrive = hardDrive;
    }

    public Computer(string processor, int ramSize) {
        this.processor = processor;
        this.ramSize = ramSize;
        this.hardDrive = "SSD";
    }

    public void TurnOn() {
        Console.WriteLine("Комп'ютер увiмкнено.");
        LogActivity("Комп'ютер увiмкнено.");
    }

    public void TurnOff() {
        Console.WriteLine("Комп'ютер вимкнено.");
        LogActivity("Комп'ютер вимкнено.");
    }

    public void UpgradeRAM(int additionalRAM) {
        ramSize += additionalRAM;
        Console.WriteLine($"Оновлено оперативну пам'ять до {ramSize} ГБ.");
        LogActivity($"Оновлено оперативну пам'ять до {ramSize} ГБ.");
    }

    public void InstallSoftware(string softwareName) {
        Console.WriteLine($"Встановлено програмне забезпечення: {softwareName}");
        LogActivity($"Встановлено програмне забезпечення: {softwareName}");
    }

    public void PrintComputerSpecs() {
        Console.WriteLine($"Процесор: {processor}");
        Console.WriteLine($"Оперативна пам'ять: {ramSize} ГБ");
        Console.WriteLine($"Жорсткий диск: {hardDrive}");
    }

    public void LogActivity(string activity) {
        using (StreamWriter writer = new StreamWriter("C:\\Users\\xalva\\OneDrive - lpnu.ua\\Документи\\Dev\\лаби\\lab2.txt", true)) {
            writer.WriteLine($"{DateTime.Now}: {activity}");
        }
    }
}



