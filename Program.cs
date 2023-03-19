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
        }
    }
}
// ideas:
// 