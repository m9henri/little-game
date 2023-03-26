namespace Commands;
class Commands
{
    public static void calc() {
        Console.WriteLine("Input 2 numbers:");
        double num01 = Convert.ToDouble(Console.ReadLine());
        double num02 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Finally, input an operator: \n + (addition),\n - (subtraction),\n * (multiplication),\n / (division),\n to the power of,\n root of (only 1st number)");
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
                Console.WriteLine(answerdi);
                break;
            case "to the power of":
                double answerpow = Math.Pow(num01, num02);
                Console.WriteLine(answerpow);
                break;
            case "root of":
                double answerroot = Math.Sqrt(num01);
                Console.WriteLine(answerroot);
                break;
            default:
                Console.WriteLine("invalid");
                break;
        }
        Console.WriteLine("--Calculator ended--");
    }

    public static string bgColor = "black";
    public static void changeBGColor() {
        Console.WriteLine("What color do you want?");
        Console.WriteLine("black\nblue\ncyan\ngrey\ngreen\nmagenta\nred\nwhite\nyellow");
        string? bgColorInput = Console.ReadLine();
        switch (bgColorInput) {
            case "black":
                bgColor = "black";
                if(txtColor != "black") {
                    Console.BackgroundColor = ConsoleColor.Black;
                } else {
                    Console.WriteLine("Your text color and your background color would be the same.");
                }
                break;
            case "blue":
                bgColor = "blue";
                if(txtColor != "blue") {
                    Console.BackgroundColor = ConsoleColor.Blue;
                } else {
                    Console.WriteLine("Your text color and your background color would be the same.");
                }
                break;
            case "cyan":
                bgColor = "cyan";
                if (txtColor != "cyan") {
                    Console.BackgroundColor = ConsoleColor.Cyan;
                } else {
                    Console.WriteLine("Your text color and your background color would be the same.");
                }
                break;
            case "grey":
                bgColor = "grey";
                if (txtColor != "grey") {
                    Console.BackgroundColor = ConsoleColor.Gray;
                } else {
                    Console.WriteLine("Your text color and your background color would be the same.");
                }
                break;
            case "green":
                bgColor = "green";
                if (txtColor != "green") {
                    Console.BackgroundColor = ConsoleColor.Green;
                } else {
                    Console.WriteLine("Your text color and your background color would be the same.");
                }
                break;
            case "magenta":
                bgColor = "magenta";
                if (txtColor != "magenta") {
                    Console.BackgroundColor = ConsoleColor.Magenta;
                } else {
                    Console.WriteLine("Your text color and your background color would be the same.");
                }
                break;
            case "red":
                bgColor = "red";
                if (txtColor != "red") {
                    Console.BackgroundColor = ConsoleColor.Red;
                } else {
                    Console.WriteLine("Your text color and your background color would be the same.");
                }
                break;
            case "white":
                bgColor = "white";
                if (txtColor != "white") {
                    Console.BackgroundColor = ConsoleColor.White;
                } else {
                    Console.WriteLine("Your text color and your background color would be the same.");
                }
                break;
            case "yellow":
                bgColor = "yellow";
                if (txtColor != "yellow") {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                } else {
                    Console.WriteLine("Your text color and your background color would be the same.");
                }
                break;
            default:
                Console.WriteLine("invalid");
                break;
        }
        Console.WriteLine("--Color Change ended--");
    }

    public static string txtColor = "white";
    public static void changeTextColor() {
        Console.WriteLine("What color do you want?");
        Console.WriteLine("black\nblue\ncyan\ngrey\ngreen\nmagenta\nred\nwhite\nyellow");
        string? txtColorInput = Console.ReadLine();
        switch (txtColorInput) {
            case "black":
                txtColor = "black";
                if (bgColor != "black") {
                    Console.ForegroundColor = ConsoleColor.Black;
                } else {
                    Console.WriteLine("Your text color and your background color would be the same.");
                }
                break;
            case "blue":
                txtColor = "blue";
                if (bgColor != "blue") {
                    Console.ForegroundColor = ConsoleColor.Blue;
                } else {
                    Console.WriteLine("Your text color and your background color would be the same.");
                }
                break;
            case "cyan":
                txtColor = "cyan";
                if (bgColor != "cyan") {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                } else {
                    Console.WriteLine("Your text color and your background color would be the same.");
                }
                break;
            case "grey":
                txtColor = "grey";
                if (bgColor != "grey") {
                    Console.ForegroundColor = ConsoleColor.Gray;
                } else {
                    Console.WriteLine("Your text color and your background color would be the same.");
                }
                break;
            case "green":
                txtColor = "green";
                if (bgColor != "green") {
                    Console.ForegroundColor = ConsoleColor.Green;
                } else {
                    Console.WriteLine("Your text color and your background color would be the same.");
                }
                break;
            case "magenta":
                txtColor = "magenta";
                if (bgColor != "magenta") {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                } else {
                    Console.WriteLine("Your text color and your background color would be the same.");
                }
                break;
            case "red":
                txtColor = "red";
                if (bgColor != "red") {
                    Console.ForegroundColor = ConsoleColor.Red;
                } else {
                    Console.WriteLine("Your text color and your background color would be the same.");
                }
                break;
            case "white":
                txtColor = "white";
                if (bgColor != "white") {
                    Console.ForegroundColor = ConsoleColor.White;
                } else {
                    Console.WriteLine("Your text color and your background color would be the same.");
                }
                break;
            case "yellow":
                txtColor = "yellow";
                if (bgColor != "yellow") {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                } else {
                    Console.WriteLine("Your text color and your background color would be the same.");
                }
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
                Console.WriteLine("What do you want to change?\nbackground color\ntext color");
                string? bgOrTxt = Console.ReadLine();
                if (bgOrTxt == "background color") {
                    Commands.changeBGColor();
                }
                if (bgOrTxt == "text color") {
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
