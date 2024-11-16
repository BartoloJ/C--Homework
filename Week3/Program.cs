double number = 16;
double guess = number / 2;
double nextGuess = (guess + number / guess) / 2;
    while (Math.Abs(nextGuess - guess) > 1e-4) {
        Console.Write("{0:R}", nextGuess);
        guess = nextGuess;
        nextGuess = (guess + number / guess) / 2;
        Console.ReadLine();
    }
Console.WriteLine($"The aproximate square root of {number} is {nextGuess}");


