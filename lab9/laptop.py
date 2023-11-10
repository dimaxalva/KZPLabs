from computer import Computer

class Laptop(Computer):
    def __init__(self, brand, model, screen_size):
        super().__init__(brand, model)
        self.screen_size = screen_size

    def display_info(self):
        super().display_info()
        print(f"Screen Size: {self.screen_size}")