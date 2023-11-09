class Program {
    static void Main() {
        try {
            Console.WriteLine("Введiть значення x:");
            double x = double.Parse(Console.ReadLine());

            double y = CalculateExpression(x);

            Console.WriteLine($"Результат обчислення: y = {y}");

            using (StreamWriter writer = new StreamWriter("result.txt")) {
                writer.WriteLine($"x = {x}");
                writer.WriteLine($"y = {y}");
            }

            Console.WriteLine("Результати збережено у файлi 'result.txt'");
        }
        catch (FormatException) {
            Console.WriteLine("Помилка: Невiрний формат введеного значення x.");
        }
        catch (DivideByZeroException) {
            Console.WriteLine("Помилка: Дiлення на нуль при обчисленнi ctg(x) або sin(7x - 1).");
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
}