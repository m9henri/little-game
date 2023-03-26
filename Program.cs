namespace Commands;
class Commands
{
    public static void calc() {
        Console.WriteLine("Input 2 numbers:");
        double num01 = Convert.ToDouble(Console.ReadLine());
        double num02 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Finally, input an operator:");
        string? op = Console.ReadLine();
        switch (op) {
            case "+":
                double answerpl = num01 + num02;
                Console.WriteLine(answerpl);
                break;
            case "-":
                double answermi = num01 - num02;
                Console.WriteLine(answermi);
                break;
            case "*":
                double answerti = num01 * num02;
                Console.WriteLine(answerti);
                break;
            case "/":
                double answerdi = num01 / num02;
                break;
            default:
                Console.WriteLine("invalid");
                break;
        }
        Console.WriteLine("--Calculator ended--");
    }
    
    public static void changeBGColor() {
        Console.WriteLine("What color do you want?");
        Console.WriteLine("black\nblue\ncyan\ngray\ngreen\nmagenta\nred\nwhite\nyellow");
        string? txtColor = Console.ReadLine();
        switch (txtColor) {
            case "black":
                Console.BackgroundColor = ConsoleColor.Black;
                break;
            case "blue":
                Console.BackgroundColor = ConsoleColor.Blue;
                break;
            case "cyan":
                Console.BackgroundColor = ConsoleColor.Cyan;
                break;
            case "gray":
                Console.BackgroundColor = ConsoleColor.Gray;
                break;
            case "green":
                Console.BackgroundColor = ConsoleColor.Green;
                break;
            case "magenta":
                Console.BackgroundColor = ConsoleColor.Magenta;
                break;
            case "red":
                Console.BackgroundColor = ConsoleColor.Red;
                break;
            case "white":
                Console.BackgroundColor = ConsoleColor.White;
                break;
            case "yellow":
                Console.BackgroundColor = ConsoleColor.Yellow;
                break;
            default:
                Console.WriteLine("invalid");
                break;
        }
        Console.WriteLine("--Color Change ended--");
    }

    public static void changeTextColor() {
        Console.WriteLine("What color do you want?");
        Console.WriteLine("black\nblue\ncyan\ngray\ngreen\nmagenta\nred\nwhite\nyellow");
        string? txtColor = Console.ReadLine();
        switch (txtColor) {
            case "black":
                Console.ForegroundColor = ConsoleColor.Black;
                break;
            case "blue":
                Console.ForegroundColor = ConsoleColor.Blue;
                break;
            case "cyan":
                Console.ForegroundColor = ConsoleColor.Cyan;
                break;
            case "gray":
                Console.ForegroundColor = ConsoleColor.Gray;
                break;
            case "green":
                Console.ForegroundColor = ConsoleColor.Green;
                break;
            case "magenta":
                Console.ForegroundColor = ConsoleColor.Magenta;
                break;
            case "red":
                Console.ForegroundColor = ConsoleColor.Red;
                break;
            case "white":
                Console.ForegroundColor = ConsoleColor.White;
                break;
            case "yellow":
                Console.ForegroundColor = ConsoleColor.Yellow;
                break;
            default:
                Console.WriteLine("invalid");
                break;
        }
        Console.WriteLine("--Color Change ended--");
    }

    public static void guessingNumbers() {
        Console.WriteLine("Between what two numbers do you want to guess?");
        Random numberGen = new Random();
        int gNInput = 0;
        int attempts = 0;
        int gNum1beta = Convert.ToInt32(Console.ReadLine());
        int gNum1 = gNum1beta + 1;
        int gNum2beta = Convert.ToInt32(Console.ReadLine());
        int gNum2 = gNum2beta - 1;
        int randNum = numberGen.Next(gNum1, gNum2);
        while (gNInput != randNum) {
            Console.WriteLine("Input a number: ");
            gNInput = Convert.ToInt32(Console.ReadLine());
            if (gNInput < randNum) {
                Console.WriteLine("Your number is smaller than the number you're guessing.");
            }
            if (gNInput > randNum) {
                Console.WriteLine("Your number is higher than the number you're guessing.");
            }
            attempts++;
        }
        Console.WriteLine("Congrats!\nThe number was " + randNum + ".\nWanna play again?");
        string? gNpa = Console.ReadLine();
        if (gNpa == "yes") {
            Commands.guessingNumbers();
        }
        if (gNpa == "no") {
            Console.WriteLine("ok");
        }
    }

    public static void headsOrTails() {
        int hotNum = 0;
        Random numberGen = new Random();
        Console.WriteLine("Type in 'heads' or 'tails'.");
        string? hdsOrTls = Console.ReadLine();
        if (hdsOrTls == "heads") {
            hotNum = 1;
        }
        if (hdsOrTls == "tails") {
            hotNum = 2;
        }
        int hotChn = numberGen.Next(1, 3);
        if (hotChn == hotNum) {
            Console.WriteLine("Congrats you win.");
            if (hotChn == 1) {
                Console.WriteLine("It was heads.");
                Console.WriteLine("--Heads or Tails ended--");
            }
            if (hotChn == 2) {
                Console.WriteLine("It was tails.");
                Console.WriteLine("--Heads or Tails ended--");
            }
        }
        if (hotChn != hotNum) {
            Console.WriteLine("Sorry, you didn't win.");
            if (hotChn == 1) {
                Console.WriteLine("It was heads.\nWanna play again?\nyes\nno");
                string? hotpa = Console.ReadLine();
                if (hotpa == "yes") {
                    Commands.headsOrTails();
                }
                if (hotpa == "no") {
                    Console.WriteLine("ok.");
                    Console.WriteLine("--Heads or Tails ended--");
                }
            }
            if (hotChn == 2) {
                Console.WriteLine("It was Tails.\nWanna play again?\nyes\nno");
                string? hotpa = Console.ReadLine();
                if (hotpa == "yes") {
                    Commands.headsOrTails();
                }
                if (hotpa == "no") {
                    Console.WriteLine("ok. we won't play again. :(");
                    Console.WriteLine("--Heads or Tails ended--");
                }
            }
        }
    }

    public static void help() {
        Console.WriteLine("'help' = shows all commands");
        Console.WriteLine("'stop' = stop the program");
        Console.WriteLine("'change color' = changes the color");
        Console.WriteLine("'calc' = opens a calucator");
        Console.WriteLine("'heads or tails' = play heads or tails");
        Console.WriteLine("'guessing numbers' = play a game where you guess specific numbers");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "little game";
        
        int while0 = 1;
        int while1 = 1;
        string? input = "a";

        Console.WriteLine("Type 'help' for help");

        while (while0 == while1)
        {
            input = Console.ReadLine();
            if (input == "help") {
                Commands.help();
            }
            if (input == "stop") {
                while1 = 0;
            }
            if (input == "change color") {
                Console.WriteLine("What do you want to change?");
                Console.WriteLine("background color\ntext color");
                string? colorChange = Console.ReadLine();
                if (colorChange == "background color") {
                    Commands.changeBGColor();
                }
                if (colorChange == "text color") {
                    Commands.changeTextColor();
                }
            }
            if (input == "secret") {
                Console.WriteLine("This is a secret");
            }
            if (input == "calc") {
                Commands.calc();
            }
            if (input == "heads or tails") {
                Commands.headsOrTails();
            }
            if (input == "guessing numbers") {
                Commands.guessingNumbers();
            }
        }
    }
}
