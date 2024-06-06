class Probl15{
    public static void Angeks()
    {
        Console.WriteLine("enter first angle");
      int a = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("enter second angle");
      int b = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("enter third angle");
      int c = Convert.ToInt32(Console.ReadLine());
      int total = a + b + c;
        if (total == 180)
        {
            Console.WriteLine("The triangle is valid");
        }
        else
        {
            Console.WriteLine("The triangle is not valid");
        }
    }
        }