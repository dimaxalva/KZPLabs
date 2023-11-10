import math
import struct

def compute_expression(x):
    try:
        result = (1 / math.tan(x)) / math.sin(7 * x - 1)
        return result
    except ZeroDivisionError:
        return None

def read_text_file(file_path):
    with open(file_path, 'r') as file:
        lines = file.readlines()
        return [float(line.strip()) for line in lines]

def write_text_file(file_path, data):
    with open(file_path, 'w') as file:
        for item in data:
            file.write(f'{item}\n')

def read_binary_file(file_path):
    with open(file_path, 'rb') as file:
        data = file.read()
        # Assuming the data is a sequence of double-precision floating-point numbers
        return struct.unpack(f'{len(data) // struct.calcsize("d")}d', data)

def write_binary_file(file_path, data):
    with open(file_path, 'wb') as file:
        # Convert the list of doubles to a binary string
        binary_data = struct.pack(f'{len(data)}d', *data)
        file.write(binary_data)

if __name__ == "__main__":
    # Приклад використання
    x_values = [0.1, 0.2, 0.3, 0.4, 0.5]
    
    # Обчислюємо значення виразу для кожного x
    y_values = [compute_expression(x) for x in x_values]

    # Записуємо дані у текстовий файл
    text_file_path = 'output.txt'
    write_text_file(text_file_path, y_values)

    # Зчитуємо дані з текстового файлу
    read_data_text = read_text_file(text_file_path)
    print(f'Read from text file: {read_data_text}')

    # Записуємо дані у двійковий файл
    binary_file_path = 'output.bin'
    write_binary_file(binary_file_path, y_values)

    # Зчитуємо дані з двійкового файлу
    read_data_binary = read_binary_file(binary_file_path)
    print(f'Read from binary file: {read_data_binary}')