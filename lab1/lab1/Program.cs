class Lab1Kekosh301 {
    static void Main(string[] args) {
        string filePath = "C:\\Users\\xalva\\OneDrive - lpnu.ua\\Документи\\Dev\\лаби\\laba1.txt";
        Console.Write("Введiть розмiр квадратної матрицi: ");
        if (int.TryParse(Console.ReadLine(), out int matrixSize) && matrixSize > 0) {
            Console.Write("Введiть символ заповнювач: ");
            char fillChar = Console.ReadKey().KeyChar;
            char[][] jaggedArray = GenerateArray(matrixSize, fillChar);

            Console.WriteLine("\nСформований зубчатий масив:");

            for (int i = 0; i < jaggedArray.Length; i++) {
                for (int j = 0; j < jaggedArray[i].Length; j++) {
                    Console.Write(jaggedArray[i][j]);
                }
                Console.WriteLine();
            }
            using (StreamWriter sr = new StreamWriter(filePath)) {
                foreach (var item in jaggedArray) {
                    sr.WriteLine(item);
                }
            }
        }
        else {
            Console.WriteLine("Невiрний ввiд. Розмiр квадратної матрицi повинен бути цiлим додатнiм числом.");
        }
    }

    static char[][] GenerateArray(int size, char fillChar) {
        char[][] jaggedArray = new char[size][];

        for (int i = 0; i < size; i++) {
            jaggedArray[i] = new char[size];

            for (int j = 0; j < size; j++) {
                if (j <= i && j <= (size - 1 - i)) {
                    jaggedArray[i][j] = fillChar;
                }
                else {
                    jaggedArray[i][j] = ' ';
                }
            }
        }
        return jaggedArray;
    }
}
