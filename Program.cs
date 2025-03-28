string paraCriptografar;
string criptografado;

Console.Clear();

Console.WriteLine("Qual frase você quer Criptografar?");
paraCriptografar = Console.ReadLine().ToUpper();

criptografado = paraCriptografar
            .Replace("A", "4")
            .Replace("E", "3")
            .Replace("I", "1")
            .Replace("O", "0")
            .Replace("T", "7")
            .Replace("S", "5");

Console.WriteLine(criptografado);