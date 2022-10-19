using Task_DiamondKata;

if (Environment.GetCommandLineArgs().Length < 2) throw new ArgumentException("Input must be letter");

var letter = Convert.ToChar(Environment.GetCommandLineArgs()[1].ToUpper());
if (!char.IsLetter(letter)) throw new ArgumentException("Input is not a letter");

Console.WriteLine(DiamondKata.Generate(Convert.ToChar(letter)));

Console.ReadKey();
