using System;

namespace PassordGenerator
{
    class Program
    {
        private static readonly Random Random = new Random();
        static void Main(string[] args)
        {
            if (!IsValid(args))
            {
                ShowHelpText();
                return;
            }

            string options = args[1];
            string password = string.Empty;
            options = options.PadRight(Convert.ToInt32(args[0]), 'l');
            while (options.Length > 0)
            {
                var randomIndex = Random.Next(0, options.Length);
                var currentChar = options[randomIndex];
                options = options.Remove(randomIndex, 1);
                if (currentChar == 'l')
                {
                    password += WriteRandomLowerCaseLetter();
                }
                else if (currentChar == 'L')
                {
                    password += WriteRandomUpperCaseLetter();
                }
                else if (currentChar == 'd')
                {
                    password += WriteRandomDigit();
                }
                else if (currentChar == 's')
                {
                    password += WriteRandomSpecialCharacter();
                }
            }

            Console.WriteLine(password);
        }

        private static char WriteRandomSpecialCharacter()
        {
            string symbols = "!\"#%&/()=?\\@£${}[]";
            var randomIndex = Random.Next(0, symbols.Length);
            return symbols[randomIndex];
        }

        private static int WriteRandomDigit()
        {
            return Random.Next(0, 10);
        }

        private static char WriteRandomUpperCaseLetter()
        {
            return GetRandomLetter('A', 'Z');
        }

        private static char WriteRandomLowerCaseLetter()
        {
            return GetRandomLetter('a', 'z');
        }
        static char GetRandomLetter(char min, char max)
        {
            return (char) Random.Next(min, max);
        }

        private static bool IsValid(string[] args)
        {
            if (args.Length != 2) return false;

            var strLength = args[0];
            var format = args[1];

            foreach (var c in format)
            {
                if (c != 'l' &&
                    c != 'L' &&
                    c != 'd' &&
                    c != 's')
                {
                    return false;
                }
            }

            foreach (var c in strLength)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private static void ShowHelpText()
        {
            Console.WriteLine("Options:");
            Console.WriteLine("- l = lower case letter");
            Console.WriteLine("- L = upper case letter");
            Console.WriteLine("- d = digit");
            Console.WriteLine("- s = special character (!\"#%&/()=?\\@£${}[])");
            Console.WriteLine("Example: PasswordGenerator 14 lLssdd");
            Console.WriteLine("\t Min. 1 lower case");
            Console.WriteLine("\t Min. 1 upper case");
            Console.WriteLine("\t Min. 2 special characters");
            Console.WriteLine("\t Min. 2 digits");
            Console.WriteLine("\t Min. 14 total characters");
        }
    }
}
