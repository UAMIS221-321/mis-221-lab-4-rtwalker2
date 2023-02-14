using System;

GetFullTriangle();




static void DisplayMenu() {
    Console.Clear();
    Console.WriteLine("Enter 1 to display full triangle\nEnter 2 to display partial triangle\nEnter 3 to exit");
}

static void GetFullTriangle() {
    Random rand = new Random();
    int rowNum = rand.Next(3,10);
    
    for(int row = 1; row <= rowNum; row++) {
        for(int col = 1; col <= row; col++) {
            Console.Write("0");
        }
        Console.WriteLine();
    }
}

static void GetPartialTriangle() {
    
}
