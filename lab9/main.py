from computer import Computer
from laptop import Laptop

def main():
    computer = Computer("ABC", "123")
    laptop = Laptop("XYZ", "456", 15.6)

    print("Computer:")
    computer.display_info()

    print("\nLaptop:")
    laptop.display_info()

if __name__ == "__main__":
    main()