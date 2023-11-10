def generate_array(size, fill_char):
    jagged_array = [[' ' for _ in range(size)] for _ in range(size)]

    for i in range(size):
        for j in range(size):
            if j <= i and j <= (size - 1 - i):
                jagged_array[i][j] = fill_char
            else:
                jagged_array[i][j] = ' '
    return jagged_array

def main():
    file_path = "C:\\Users\\xalva\\OneDrive - lpnu.ua\\Документи\\Dev\\лаби\\laba1.txt"
    print("Введiть розмiр квадратної матрицi: ")
    matrix_size = int(input())
    
    if matrix_size > 0:
        print("Введiть символ заповнювач: ")
        fill_char = input()[0]
        jagged_array = generate_array(matrix_size, fill_char)

        print("\nСформований зубчатий масив:")

        for row in jagged_array:
            print(''.join(row))
    else:
        print("Невiрний ввiд. Розмiр квадратної матрицi повинен бути цiлим додатнiм числом.")

if __name__ == "__main__":
    main()