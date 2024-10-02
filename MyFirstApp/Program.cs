class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Enter first number:");
        if (!Int32.TryParse(Console.ReadLine(), out var a)) {
            Console.WriteLine("Not a number!");
            return;
        }
        Console.WriteLine("Enter second number:");
        if (!Int32.TryParse(Console.ReadLine(), out var b)) {
            Console.WriteLine("Not a number!");
            return;
        }

        Console.WriteLine("Enter operation (& or | or ^):");
        var znak = Console.ReadLine();

        if (znak.Length == 0 || znak.Length > 1) {
            Console.WriteLine("Incorrect operation");
            return;
        }

        switch (znak[0]) {
            case '&':
                Console.WriteLine("{0} & {1} = {2}", a, b, a&b);
                Console.WriteLine("{0} & {1} = {2}", Convert.ToString(a,2), Convert.ToString(b, 2), Convert.ToString(a&b, 2));
                Console.WriteLine("{0} & {1} = {2}", Convert.ToString(a, 16), Convert.ToString(b, 16), Convert.ToString(a&b, 16));
                break;
            case '|':
                Console.WriteLine("{0} | {1} = {2}", a, b, a|b);
                Console.WriteLine("{0} | {1} = {2}", Convert.ToString(a, 2), Convert.ToString(b, 2), Convert.ToString(a|b, 2));
                Console.WriteLine("{0} | {1} = {2}", Convert.ToString(a, 16), Convert.ToString(b, 16), Convert.ToString(a|b, 16));
                break;
            case '^':
                Console.WriteLine("{0} ^ {1} = {2}", a, b, a^b);
                Console.WriteLine("{0} ^ {1} = {2}", Convert.ToString(a, 2), Convert.ToString(b, 2), Convert.ToString(a^b, 2));
                Console.WriteLine("{0} ^ {1} = {2}", Convert.ToString(a, 16), Convert.ToString(b, 16), Convert.ToString(a^b, 16));
                break;
            default:
                Console.WriteLine("Incorrect operation");
                break;
        }
          
    }

}

