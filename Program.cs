using System;
//MAIN-----

int userChoice = GetUserChoice();
while(userChoice != 3) {
    routeAnswer(userChoice);
    userChoice = GetUserChoice();
}

//END OF MAIN-----

//DISPLAY MENU
static void DisplayMenu() {
    Console.Clear();
    Console.WriteLine("Enter 1 to display full triangle\nEnter 2 to display partial triangle\nEnter 3 to exit");
}

//GETTING USER CHOICE
static int GetUserChoice() {
    DisplayMenu();
    String choice = Console.ReadLine();
    if(IsValidChoice(choice)) {
        return int.Parse(choice);
    } else return 0;
}

//ROUTING ANSWER TO RESPECTIVE ACTIONS
static void routeAnswer(int userChoice) {
    if(userChoice == 1) {
        GetFullTriangle();
    }
    else if(userChoice == 2) {
        GetPartialTriangle();
    }
    else if(userChoice != 3) {
        Console.WriteLine("Invalid input!");
        Pause();
    }
}

//PRINTING FULL TRIANGLE
static void GetFullTriangle() {

    Random rand = new Random();
    int rowNum = rand.Next(3,10);
    
    for(int row = 1; row <= rowNum; row++) {
        for(int col = 1; col <= row; col++) {
            Console.Write("0");
        }
        Console.WriteLine();
    }
Pause();  
}

//PRINTING PARTIAL TRIANGLE
static void GetPartialTriangle() {

    Random rand = new Random();
    int rowNum = rand.Next(3,10);
    int print;
    
    for(int row = 1; row <= rowNum; row++) {
        for(int col = 1; col <= row; col++) {
            print = rand.Next(1,3);
            if (print == 1) {
                Console.Write("0");
            }
            else {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
Pause();
}

//TESTING IF CHOICE IS VALID
static bool IsValidChoice(string userInput) {
    if (userInput == "1" || userInput == "2" || userInput == "3") {
        return true;
    }
    else {
        return false;
    }
}

//PAUSES THING SO THING CAN DO THING AND USER CAN SEE THING BEFORE DISAPPEARING
static void Pause() {
    Console.WriteLine("Enter a key to continue...");
    Console.ReadLine();
}
