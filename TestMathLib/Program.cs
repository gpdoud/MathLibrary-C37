
using MathLibrary;
using StringLibrary;

Console.WriteLine(MathLib.About);

Console.WriteLine($"Inverse: 5 = {MathLib.Inverse(5)}");
Console.WriteLine($"Modulo : 5 mod 2 = {MathLib.Modulo(5, 2)}");
Console.WriteLine($"Cubed  : 3 = {MathLib.Cubed(3)}");

Console.WriteLine($"Reverse: ABCD is {StringLib.Reverse("ABCD")}");
Console.WriteLine($"Rotate : ABCD is {StringLib.Rotate("ABCD")}");
Console.WriteLine($"RmVowel: ABCDEFG is {StringLib.RemoveVowels("ABCDEFG")}");