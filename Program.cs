namespace Command;
class Commands
{
    public static void help() {
        Console.WriteLine("'help' = shows all commands");
        Console.WriteLine("'stop' = stop the program");
    }
}

class Program
{
    static void Main(string[] args)
    {
        int while0 = 1; //won't work w/o var. (idk why)
        int while1 = 1;
        
        string? input = "a";

        while (while0 == while1) //infinite amount of commands
        {
            input = Console.ReadLine();
            if (input == "help") {
                Commands.help();
            }
            if (input == "stop") {
                while1 = 0;
            }
        }
    }
}
// Make an if-statement for your command then create a method for this command. There are 2 examples.