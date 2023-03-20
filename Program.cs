namespace Command;
class Commands
{
    public static void calc() {
        Console.WriteLine("Input 2 numbers:");
        double num01 = Convert.ToDouble(Console.ReadLine());
        double num02 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Finally, input an operator:");
        string op = Console.ReadLine();
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
    }

    public static void help() {
        Console.WriteLine("'help' = shows all commands");
        Console.WriteLine("'stop' = stop the program");
        Console.WriteLine("'change color' = changes the color");
        Console.WriteLine("'calc' = opens a calucator");
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
        }
    }
}
