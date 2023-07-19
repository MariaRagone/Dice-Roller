////DICE ROLLER


//Objective: Random Numbers

//Task: Create an application that simulates dice rolling.

//What will the application do?
//The application asks the user to enter the number of sides for a pair of dice. 
using System.Xml.Schema;

Console.WriteLine("Enter the number of sides for a pair of dice from 3-20 \nHint: choosing 3 or 6 is more fun!");
int numberOfSides = 0;
// keeps asking infinately if the user types numbers outside the range of 4-20
while (int.TryParse(Console.ReadLine(), out numberOfSides) == false || numberOfSides < 3 || numberOfSides > 20)

{
    Console.WriteLine("Invalid response. Try again"); //error message
}
Console.WriteLine($"Great your 2 dice are {numberOfSides} sided!");


//The application prompts the user to roll the dice.
{ while (true) 
    {
        //The application asks the user if he/she wants to roll the dice again.
        Console.WriteLine("Do you want to roll the dice? y/n");
        string rollChoice = Console.ReadLine().ToLower().Trim(); 
        if ("yes".Contains(rollChoice)) 
        { //The application “rolls” two n-sided dice, displaying the results of each along with a total
            //CALL THE METHOD
            int randomDice1 = CreateRandomNumbers(numberOfSides);
            int randomDice2 = CreateRandomNumbers(numberOfSides);


            Console.WriteLine($"The first dice rolled: {randomDice1}");
            Console.WriteLine($"The second dice rolled: {randomDice2}");
            
            Console.WriteLine($"The total of the dice rolled is: {randomDice1 + randomDice2}");
            //For 6-sided dice, the application recognizes the following dice combinations and displays a message for each.
            //It should not output this for any other size of dice.
            if (numberOfSides == 6)
            {
                Console.WriteLine(RollSixSidedMatching(randomDice1, randomDice2));
                Console.WriteLine(RollSixSidedTotal(randomDice1, randomDice2));
                //if (randomDice1 == 1 && randomDice2 == 1) //Snake Eyes: Two 1s
                //{
                //    Console.WriteLine($"You rolled a {randomDice1} and {randomDice2}: Snake Eyes!");
                //}
                //else if (randomDice1 + randomDice2 == 3) //Ace Deuce: A 1 and 2
                //{
                //    Console.WriteLine($"Ace Deuce");
                //                    }
                //else if (randomDice1 == 6 && randomDice2 == 6) //Box Cars: Two 6s
                //{
                //    Console.WriteLine($"Box Cars!");
                //}
                //else if ((randomDice1 + randomDice2 == 7) || (randomDice1 + randomDice2 == 11)) //Win: A total of 7 or 11
                //{
                //    Console.WriteLine($"You win!");
                //}
                //if (sumOfDice == 2 || sumOfDice == 3 || sumOfDice == 12)//Craps: A total of 2, 3, or 12 (will also generate another message!)
                //{
                //    Console.WriteLine($"CRAPS!!!!");
                //}
            }
            
            else if (numberOfSides == 3)
            {
                Console.WriteLine(RollThreeSidedMatching(randomDice1, randomDice2));
            }
        }
        else if ("no".Contains(rollChoice)) 
        {
            Console.WriteLine("Bye!");
            break; 
        } 
        else 
        {
            Console.WriteLine("Invalid response. Please try again. y/n"); 
        } 
    }
}

//--------METHODS--------
//Create a static method to generate the random numbers.
static int CreateRandomNumbers(int numberOfSides)
{
    Random dice = new Random();
    int roll = dice.Next(1, numberOfSides + 1);
    return roll;
}






//Create a static method for six - sided dice that takes two dice values as parameters,
//and returns a string for one of the valid combinations(e.g.Snake Eyes, etc.)
//or an empty string if the dice don’t match one of the combinations.
//Snake Eyes: Two 1s
//Ace Deuce: A 1 and 2
//Box Cars: Two 6s
static string RollSixSidedMatching(int randomDice1, int randomDice2)
{
    if (randomDice1 == 1 && randomDice2 == 1) //Snake Eyes: Two 1s
    {
        return "Snake Eyes!";
    }
    else if (randomDice1 + randomDice2 == 3) //Ace Deuce: A 1 and 2
    {
        return "Ace Deuce";
    }
    else if (randomDice1 == 6 && randomDice2 == 6) //Box Cars: Two 6s
    {
        return "Box Cars!";
    }
    else
    {
        return "";//Or empty string if no matching combos

    }
}







//Extra Challenges:
//Come up with a set of winning combinations for other dice sizes besides 6.
static string RollThreeSidedMatching(int randomDice1, int randomDice2)
{
    if (randomDice1 == 3 && randomDice2 == 3) //Monster Eyes: Two 3s
    {
        return "Monster Eyes!";
    }
    else if (randomDice1== 1 && randomDice2 == 1) //Aces: Two 1s
    {
        return "Aces!";
    }
    else if (randomDice1 == 2 && randomDice2 == 2) //You lose! Two 2s
    {
        return "You Lose!";
    }
    else
    {
        return "";//Or empty string if no matching combos
    }
}







//Create a static method for six - sided dice that takes two dice values as parameters,
//and returns a string for one of the valid totals(e.g.Win, etc.)
//or an empty string if the dice don’t match one of the totals.
//Win: A total of 7 or 11
//Craps: A total of 2, 3, or 12

static string RollSixSidedTotal(int randomDice1, int randomDice2)
{
    int sumOfDice = randomDice1 + randomDice2;
    if ((randomDice1 + randomDice2 == 7) || (randomDice1 + randomDice2 == 11)) //Win: A total of 7 or 11
    {
        return "You win!";
    }
    
    else if (sumOfDice == 2 || sumOfDice == 3 || sumOfDice == 12) //Craps: A total of 2, 3, or 12 (will also generate another message!)
        {
        return "CRAPS!!!!";
        }
    else
    {
        return "";//Or empty string if no matching combos
    }
}

//Application takes all user input correctly: 1 point
//Application loops properly: 1 point

//Hints:
//Use the Random class to generate a random number.








