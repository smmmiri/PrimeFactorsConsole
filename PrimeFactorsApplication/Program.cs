using PrimeFactorsLibrary;

string? continueInput;

do
{
    Console.Write("Please enter a number between 2 and 1000 to displays its prime factors: ");
    var input = Console.ReadLine();
    Console.WriteLine();

    try
    {
        var number = int.Parse(input);
        if (number <= 1 || number > 1000)
            throw new OverflowException();

        PrimeFactorsCalculator.Calculate(number);
        Console.WriteLine($"Prime factors of {number} are: {PrimeFactorsCalculator.Result}");
    }
    catch (OverflowException)
    {
        Console.WriteLine("The entered number must be between 2 and 1000.");
    }
    catch (FormatException)
    {
        Console.WriteLine("Please enter number correctly.");
    }
    finally
    {
        Console.WriteLine("\nDo you want to continue? (Y/N)");
        continueInput = Console.ReadLine();
        Console.WriteLine();
    }
} while (continueInput.ToLower() != "n");