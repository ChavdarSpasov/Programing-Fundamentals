using System;

public class Program
{
    public static void Main()
    {
        var num = int.Parse(Console.ReadLine());



        for (int i = 0; i < num; i++)
        {
            var currString = Console.ReadLine();

            if (currString == "success")
            {
                var operation = Console.ReadLine();
                var message = Console.ReadLine();

                ShowSuccess(operation, message);

            }
            else if (currString == "error")
            {
                var operation = Console.ReadLine();
                var code = int.Parse(Console.ReadLine());

                ShowError(operation, code);

            }
            else
            {
                continue;
            }
        }

    }

    public static void ShowSuccess(string operation, string message)
    {
        Console.WriteLine("Successfully executed {0}.", operation);
        Console.WriteLine(new string('=', 30));
        Console.WriteLine("Message: {0}.", message);

    }

    public static void ShowError(string operation, int code)
    {
        Console.WriteLine("Error: Failed to execute {0}.", operation);
        Console.WriteLine(new string('=', 30));
        Console.WriteLine("Error Code: {0}.", code);

        var reason = string.Empty;

        if (code > 0)
        {
            reason = "Invalid Client Data.";
        }
        else if (code < 0)
        {
            reason = "Internal System Failure.";
        }
        Console.WriteLine("Reason: {0}", reason);

    }


}