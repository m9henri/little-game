namespace Commands;

class Language
{
    public static string overlayLanguage = "english";
    public static void language() {
        switch (overlayLanguage) {
            case "Deutsch":
                Console.WriteLine("Zu welcher Sprache möchtest du wechseln?\nEnglisch");
                string? germanLanguageInput = Console.ReadLine();
                switch (germanLanguageInput) {
                    case "Englisch":
                        overlayLanguage = "english";
                        Console.WriteLine("--Language successfully switched to English--");
                        Console.WriteLine("Type 'help' for help.");
                        break;
                }
                break;
            case "english":
                Console.WriteLine("What language do you want to switch to?\ngerman");
                string? englishLanguageInput = Console.ReadLine();
                switch (englishLanguageInput) {
                    case "german":
                        overlayLanguage = "Deutsch";
                        Console.WriteLine("--Sprache erfolgreich zu Deutsch gewechselt--");
                        Console.WriteLine("Schreibe 'Hilfe' für Hilfe");
                        break;
                }
                break;
        }
    }
}

class Deutsch
{
    public static void Taschenrechner() {
        Console.WriteLine("Gebe 2 Nummern ein:");
        double num01 = Convert.ToDouble(Console.ReadLine());
        double num02 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Gebe jetzt einen Operator ein: \n + (addition),\n - (subtraktion),\n * (multiplikation),\n / (division),\n zur Potenz von,\n zur Quadratwurzel (nur die erste Zahl)");
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
            case "zur Potenz von":
                double answerpow = Math.Pow(num01, num02);
                Console.WriteLine(answerpow);
                break;
            case "zur Quadratwurzel":
                double answerroot = Math.Sqrt(num01);
                Console.WriteLine(answerroot);
                break;
            default:
                Console.WriteLine("ungültig");
                break;
        }
        Console.WriteLine("--Taschenrechner ist beendet--");
    }

    private static string bgColor = "black";
    public static void Hintergrundfarbenänderer() {
        Console.WriteLine("Welche Farbe möchstest du haben?");
        Console.WriteLine("schwarz\nblau\ntürkis\ngrau\ngrün\nmagenta\nrot\nweiß\ngelb");
        string? bgColorInput = Console.ReadLine();
        switch (bgColorInput) {
            case "schwarz":
                bgColor = "black";
                if(txtColor != "black") {
                    Console.BackgroundColor = ConsoleColor.Black;
                } else {
                    Console.WriteLine("Deine Text- und Hintergrundfarbe würden die gleichen sein.");
                }
                break;
            case "blau":
                bgColor = "blue";
                if(txtColor != "blue") {
                    Console.BackgroundColor = ConsoleColor.Blue;
                } else {
                    Console.WriteLine("Deine Text- und Hintergrundfarbe würden die gleichen sein.");
                }
                break;
            case "türkis":
                bgColor = "cyan";
                if (txtColor != "cyan") {
                    Console.BackgroundColor = ConsoleColor.Cyan;
                } else {
                    Console.WriteLine("Deine Text- und Hintergrundfarbe würden die gleichen sein.");
                }
                break;
            case "grau":
                bgColor = "grey";
                if (txtColor != "grey") {
                    Console.BackgroundColor = ConsoleColor.Gray;
                } else {
                    Console.WriteLine("Deine Text- und Hintergrundfarbe würden die gleichen sein.");
                }
                break;
            case "grün":
                bgColor = "green";
                if (txtColor != "green") {
                    Console.BackgroundColor = ConsoleColor.Green;
                } else {
                    Console.WriteLine("Deine Text- und Hintergrundfarbe würden die gleichen sein.");
                }
                break;
            case "magenta":
                bgColor = "magenta";
                if (txtColor != "magenta") {
                    Console.BackgroundColor = ConsoleColor.Magenta;
                } else {
                    Console.WriteLine("Deine Text- und Hintergrundfarbe würden die gleichen sein.");
                }
                break;
            case "rot":
                bgColor = "red";
                if (txtColor != "red") {
                    Console.BackgroundColor = ConsoleColor.Red;
                } else {
                    Console.WriteLine("Deine Text- und Hintergrundfarbe würden die gleichen sein.");
                }
                break;
            case "weiß":
                bgColor = "white";
                if (txtColor != "white") {
                    Console.BackgroundColor = ConsoleColor.White;
                } else {
                    Console.WriteLine("Deine Text- und Hintergrundfarbe würden die gleichen sein.");
                }
                break;
            case "gelb":
                bgColor = "yellow";
                if (txtColor != "yellow") {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                } else {
                    Console.WriteLine("Deine Text- und Hintergrundfarbe würden die gleichen sein.");
                }
                break;
            default:
                Console.WriteLine("ungültig");
                break;
        }
        Console.WriteLine("--Farbenänderer ist beendet--");
    }

    private static string txtColor = "white";
    public static void Textfarbenänderer() {
        Console.WriteLine("Welche Farbe möchtest du haben?");
        Console.WriteLine("schwarz\nblau\ntürkis\ngrau\ngrün\nmagenta\nrot\nweiß\ngelb");
        string? txtColorInput = Console.ReadLine();
        switch (txtColorInput) {
            case "schwarz":
                txtColor = "black";
                if (bgColor != "black") {
                    Console.ForegroundColor = ConsoleColor.Black;
                } else {
                    Console.WriteLine("Deine Text- und Hintergrundfarbe würden die gleichen sein.");
                }
                break;
            case "blau":
                txtColor = "blue";
                if (bgColor != "blue") {
                    Console.ForegroundColor = ConsoleColor.Blue;
                } else {
                    Console.WriteLine("Deine Text- und Hintergrundfarbe würden die gleichen sein.");
                }
                break;
            case "türkis":
                txtColor = "cyan";
                if (bgColor != "cyan") {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                } else {
                    Console.WriteLine("Deine Text- und Hintergrundfarbe würden die gleichen sein.");
                }
                break;
            case "grau":
                txtColor = "grey";
                if (bgColor != "grey") {
                    Console.ForegroundColor = ConsoleColor.Gray;
                } else {
                    Console.WriteLine("Deine Text- und Hintergrundfarbe würden die gleichen sein.");
                }
                break;
            case "grün":
                txtColor = "green";
                if (bgColor != "green") {
                    Console.ForegroundColor = ConsoleColor.Green;
                } else {
                    Console.WriteLine("Deine Text- und Hintergrundfarbe würden die gleichen sein.");
                }
                break;
            case "magenta":
                txtColor = "magenta";
                if (bgColor != "magenta") {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                } else {
                    Console.WriteLine("Deine Text- und Hintergrundfarbe würden die gleichen sein.");
                }
                break;
            case "rot":
                txtColor = "red";
                if (bgColor != "red") {
                    Console.ForegroundColor = ConsoleColor.Red;
                } else {
                    Console.WriteLine("Deine Text- und Hintergrundfarbe würden die gleichen sein.");
                }
                break;
            case "weiß":
                txtColor = "white";
                if (bgColor != "white") {
                    Console.ForegroundColor = ConsoleColor.White;
                } else {
                    Console.WriteLine("Deine Text- und Hintergrundfarbe würden die gleichen sein.");
                }
                break;
            case "gelb":
                txtColor = "yellow";
                if (bgColor != "yellow") {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                } else {
                    Console.WriteLine("Deine Text- und Hintergrundfarbe würden die gleichen sein.");
                }
                break;
            default:
                Console.WriteLine("ungültig");
                break;
        }
        Console.WriteLine("--Farbenänderer ist beendet--");
    }

        public static void Titeländerer() {
        string? newTitle;
        Console.WriteLine("Zu was willst du den Titel ändern?");
        newTitle = Console.ReadLine();
        if (String.IsNullOrEmpty(newTitle) == true) {
            Console.WriteLine("Versuchs nochmal.");
            Console.ReadKey();
            Deutsch.Titeländerer();
        } else {
            Console.Title = newTitle;
        }
    }

    public static void ZahlenRaten() {
        Console.WriteLine("Zwischen welchen Nummern möchtest du die Zahl raten.");
        Random numberGen = new Random();
        int gNInput = 0;
        int attempts = 0;
        int gNum1 = Convert.ToInt32(Console.ReadLine());
        int gNum2beta = Convert.ToInt32(Console.ReadLine());
        int gNum2 = gNum2beta - 1;
        int randNum = numberGen.Next(gNum1, gNum2);
        while (gNInput != randNum) {
            Console.WriteLine("Gebe eine Zahl ein: ");
            gNInput = Convert.ToInt32(Console.ReadLine());
            if (gNInput < randNum) {
                Console.WriteLine("Deine Nummer ist kleiner als die Nummer die du erraten sollst.");
            }
            if (gNInput > randNum) {
                Console.WriteLine("Deine Nummer ist größer als die Nummer die du erraten sollst.");
            }
            attempts++;
        }
        Console.WriteLine("Glückwunsch!\nDie Nummer war " + randNum + " und du brauchtest " + attempts + " Versuche.\nNochmal spielen?");
        string? gNpa = Console.ReadLine();
        if (gNpa == "ja") {
            Deutsch.ZahlenRaten();
        }
        if (gNpa == "nein") {
            Console.WriteLine("ok");
            Console.WriteLine("--Zahlen Raten ist beendet--");
        }
    }

    public static void KopfOderZahl() {
        int hotNum = 0;
        Random numberGen = new Random();
        Console.WriteLine("Kopf oder Zahl?.");
        string? hdsOrTls = Console.ReadLine();
        if (hdsOrTls == "Kopf") {
            hotNum = 1;
        }
        if (hdsOrTls == "Zahl") {
            hotNum = 2;
        }
        int hotChn = numberGen.Next(1, 3);
        if (hotChn == hotNum) {
            Console.WriteLine("Glückwunsch, du hast gewonnen.");
            if (hotChn == 1) {
                Console.WriteLine("Es war Kopf.");
                Console.WriteLine("--Kopf oder Zahl ist beendet--");
            }
            if (hotChn == 2) {
                Console.WriteLine("Es war Zahl.");
                Console.WriteLine("--Kopf oder Zahl ist beendet--");
            }
        }
        if (hotChn != hotNum) {
            Console.WriteLine("Du hast nicht gewonnen.");
            if (hotChn == 1) {
                Console.WriteLine("Es war Kopf.\nNochmal spielen?\nja\nnein");
                string? hotpa = Console.ReadLine();
                if (hotpa == "ja") {
                    English.HeadsOrTails();
                }
                if (hotpa == "nein") {
                    Console.WriteLine("ok.");
                    Console.WriteLine("--Kopf oder Zahl ist beendet--");
                }
            }
            if (hotChn == 2) {
                Console.WriteLine("Es war Zahl.\nNochmal spielen?\nja\nnein");
                string? hotpa = Console.ReadLine();
                if (hotpa == "ja") {
                    English.HeadsOrTails();
                }
                if (hotpa == "nein") {
                    Console.WriteLine("ok.");
                    Console.WriteLine("--Kopf oder Zahl ist beendet--");
                }
            }
        }
    }

    public static void Hilfe() {
        Console.WriteLine("'Hilfe' = zeigt alle Möglichkeiten");
        Console.WriteLine("'Stopp' = stoppt das Programm");
        Console.WriteLine("'Farbenveränderer' = verändert die Farben");
        Console.WriteLine("'Titelveränderer' = Ändert den Titel des Fensters.");
        Console.WriteLine("'Taschenrechner' = öffnet den Taschenrechner");
        Console.WriteLine("'Schließen' = schließt das Fenster");
        Console.WriteLine("'Kopf oder Zahl' = lässt dich Kopf oder Zahl spielen");
        Console.WriteLine("'Zahlen raten' = lässt dich ein Spiel spielen, wo du eine bestimmte Zahl erraten musst");
        Console.WriteLine("'Sprache' = lässt dich die Sprache einstellen");
        Console.WriteLine("'Zurücksetzen' = Setzt das Fenster zurück");
        Console.WriteLine("'Timer' = erschafft einen Timer, mit so viel Zeit, wie du eingegeben hast");
    }

    public static async void Timer() {
        Console.WriteLine("In welcher Zeit möchtest du den Timer einstellen?\nMillisekunden\nSekunden\nMinuten");
        string? tMes = Console.ReadLine();
        switch (tMes) {
            case "Millisekunden":
                Console.WriteLine("Zu wie vielen Millisekunden möchtest du den Timer einstellen?");
                int msTimer = Convert.ToInt32(Console.ReadLine());
                await Task.Delay(msTimer);
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Dein Timer ist vorüber.");
                }
                break;
            case "Sekunden":
                Console.WriteLine("Zu wie vielen Sekunden möchtest du den Timer einstellen?");
                int sTimer = Convert.ToInt32(Console.ReadLine());
                await Task.Delay(sTimer * 1000);
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Dein Timer ist vorüber.");
                }
                break;
            case "Minuten":
                Console.WriteLine("Zu wie vielen Minuten möchtest du den Timer einstellen?");
                int minTimer = Convert.ToInt32(Console.ReadLine());
                await Task.Delay(minTimer * 60000);
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Dein Timer ist vorüber.");
                }
                break;
        }
    }
}

class English
{
    public static void Calc() {
        Console.WriteLine("Input 2 numbers:");
        double num01 = Convert.ToDouble(Console.ReadLine());
        double num02 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Finally, input an operator: \n + (addition),\n - (subtraction),\n * (multiplication),\n / (division),\n to the power of,\n square root (only 1st number)");
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
            case "square root":
                double answerroot = Math.Sqrt(num01);
                Console.WriteLine(answerroot);
                break;
            default:
                Console.WriteLine("invalid");
                break;
        }
        Console.WriteLine("--Calculator ended--");
    }

    private static string bgColor = "black";
    public static void ChangeBGColor() {
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

    private static string txtColor = "white";
    public static void ChangeTextColor() {
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

    public static void ChangeTitle() {
        string? newTitle;
        Console.WriteLine("What do you want to change the title to?");
        newTitle = Console.ReadLine();
        if (String.IsNullOrEmpty(newTitle) == true) {
            Console.WriteLine("You failed. Start again.");
            Console.ReadKey();
            English.ChangeTitle();
        } else {
            Console.Title = newTitle;
        }
    }

    public static void GuessingNumbers() {
        Console.WriteLine("Between what two numbers do you want to guess?");
        Random numberGen = new Random();
        int gNInput = 0;
        int attempts = 0;
        int gNum1 = Convert.ToInt32(Console.ReadLine());
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
        Console.WriteLine("Congrats!\nThe number was " + randNum + " and you needed " + attempts + " attempts.\nWanna play again?");
        string? gNpa = Console.ReadLine();
        if (gNpa == "yes") {
            English.GuessingNumbers();
        }
        if (gNpa == "no") {
            Console.WriteLine("ok");
            Console.WriteLine("--Number Guessing ended--");
        }
    }

    public static void HeadsOrTails() {
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
                    English.HeadsOrTails();
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
                    English.HeadsOrTails();
                }
                if (hotpa == "no") {
                    Console.WriteLine("ok.");
                    Console.WriteLine("--Heads or Tails ended--");
                }
            }
        }
    }

    public static void Help() {
        Console.WriteLine("'help' = shows all commands");
        Console.WriteLine("'stop' = stop the program");
        Console.WriteLine("'change color' = changes the color");
        Console.WriteLine("'change title' = change the title of the terminal window");
        Console.WriteLine("'calc' = opens a calucator");
        Console.WriteLine("'exit' = exits out of the window");
        Console.WriteLine("'heads or tails' = play heads or tails");
        Console.WriteLine("'guessing numbers' = play a game where you guess specific numbers");
        Console.WriteLine("'language' = changes the language");
        Console.WriteLine("'reset' = reset the terminal window");
        Console.WriteLine("'timer' = creates a timer with the amount of time you typed in");
    }

    public static async void Timer() {
        Console.WriteLine("In what time measurement do you want to set the timer?\nmilliseconds\nseconds\nminutes");
        string? tMes = Console.ReadLine();
        switch (tMes) {
            case "milliseconds":
                Console.WriteLine("How many milliseconds do you want to set the timer?");
                int msTimer = Convert.ToInt32(Console.ReadLine());
                await Task.Delay(msTimer);
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Your timer is over.");
                }
                break;
            case "seconds":
                Console.WriteLine("How many seconds do you want to set the timer?");
                int sTimer = Convert.ToInt32(Console.ReadLine());
                await Task.Delay(sTimer * 1000);
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Your timer is over.");
                }
                break;
            case "minutes":
                Console.WriteLine("How many minutes do you want to set the timer?");
                int minTimer = Convert.ToInt32(Console.ReadLine());
                await Task.Delay(minTimer * 60000);
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Your timer is over.");
                }
                break;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        int while0 = 1;
        int while1 = 1;
        string? input;

        Console.WriteLine("Type 'help' for help");

        while (while0 == while1)
        {
            input = Console.ReadLine();
            if (Language.overlayLanguage == "english") {
                switch (input) {
                    case "calc":
                        English.Calc();
                        break;
                    case "change color":
                        Console.WriteLine("What do you want to change?\nbackground color\ntext color");
                        string? bgOrTxt = Console.ReadLine();
                        switch (bgOrTxt) {
                            case "background color":
                                English.ChangeBGColor();
                                break;
                            case "text color":
                                English.ChangeTextColor();
                                break;
                        }
                        break;
                    case "change title":
                        English.ChangeTitle();
                        break;
                    case "exit":
                        Environment.Exit(0);
                        break;
                    case "guessing numbers":
                        English.GuessingNumbers();
                        break;
                    case "heads or tails":
                        English.HeadsOrTails();
                        break;
                    case "help":
                        English.Help();
                        break;
                    case "language":
                        Language.language();
                        break;
                    case "reset":
                        Console.Clear();
                        break;
                    case "secret":
                        Console.WriteLine("This is a secret");
                        break;
                    case "stop":
                        while1 = 0;
                        break;
                    case "timer":
                        English.Timer();
                        break;
                }
            }
            if (Language.overlayLanguage == "Deutsch") {
                switch (input) {
                    case "Farbenveränderer":
                        Console.WriteLine("Was möchtest du verändern?\nHintergrundfarbe\nTextfarbe");
                        string? bgOrTxt = Console.ReadLine();
                        switch (bgOrTxt) {
                            case "Hintergrundfarbe":
                                Deutsch.Hintergrundfarbenänderer();
                                break;
                            case "Textfarbe":
                                Deutsch.Textfarbenänderer();
                                break;
                        }
                        break;
                    case "Geheimnis":
                        Console.WriteLine("Dies ist ein Geheimnis.");
                        break;
                    case "Hilfe":
                        Deutsch.Hilfe();
                        break;
                    case "Kopf oder Zahl":
                        Deutsch.KopfOderZahl();
                        break;
                    case "Schließen":
                        Environment.Exit(0);
                        break;
                    case "Sprache":
                        Language.language();
                        break;
                    case "Stopp":
                        while1 = 0;
                        break;
                    case "Taschenrechner":
                        Deutsch.Taschenrechner();
                        break;
                    case "Timer":
                        Deutsch.Timer();
                        break;
                    case "Titelveränderer":
                        Deutsch.Titeländerer();
                        break;
                    case "Zahlen raten":
                        Deutsch.ZahlenRaten();
                        break;
                    case "Zurücksetzen":
                        Console.Clear();
                        break;
                }
            }
        }
    }
}