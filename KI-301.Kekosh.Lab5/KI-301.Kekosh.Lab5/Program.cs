class CalculationResult {
    public double X { get; set; }
    public double Y { get; set; }
}

class Program {
    static void Main() {
        try {
            Console.WriteLine("Введiть значення x:");
            double x = double.Parse(Console.ReadLine());

            double y = CalculateExpression(x);

            Console.WriteLine($"Результат обчислення: y = {y}");


            SaveResultToTextFile(x, y, "result.txt");
            SaveResultToBinaryFile(x, y, "result.dat");


            Console.WriteLine("Читання результату з бiнарного файлу:");
            var result = ReadResultFromBinaryFile("result.dat");
            Console.WriteLine($"x = {result.X}, y = {result.Y}");
            Console.WriteLine("Читання результату з текстового файлу:");
            var resultTxt = ReadResultFromTextFile("result.txt");
            Console.WriteLine($"x = {resultTxt.X}, y = {resultTxt.Y}");
        }
        catch (FormatException) {
            Console.WriteLine("Помилка: Невірний формат введеного значення x.");
        }
        catch (DivideByZeroException) {
            Console.WriteLine("Помилка: Ділення на нуль при обчисленні ctg(x) або sin(7x - 1).");
        }
        catch (Exception ex) {
            Console.WriteLine($"Помилка: {ex.Message}");
        }
    }

    static double CalculateExpression(double x) {
        if (x == 0) {
            throw new DivideByZeroException();
        }
        double ctgX = 1.0 / Math.Tan(x);
        double sin7xMinus1 = Math.Sin(7 * x - 1);

        if (sin7xMinus1 == 0) {
            throw new DivideByZeroException();
        }

        return ctgX / sin7xMinus1;
    }

    static void SaveResultToBinaryFile(double x, double y, string fileName) {
        using BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create));
        writer.Write(x);
        writer.Write(y);
    }

    static void SaveResultToTextFile(double x, double y, string fileName) {
        using StreamWriter writer = new(fileName);
        writer.WriteLine($"x = {x}");
        writer.WriteLine($"y = {y}");
    }

    static CalculationResult ReadResultFromBinaryFile(string fileName) {
        using BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open));
        double x = reader.ReadDouble();
        double y = reader.ReadDouble();
        return new CalculationResult { X = x, Y = y };
    }

    static CalculationResult ReadResultFromTextFile(string fileName) {
        using StreamReader reader = new(fileName);
        double x = double.Parse(reader.ReadLine()[4..]);
        double y = double.Parse(reader.ReadLine()[4..]);
        return new CalculationResult { X = x, Y = y };
    }
}
