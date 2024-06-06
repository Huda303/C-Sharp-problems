class Probl14{
    public static void Triangles()
    {
        Console.WriteLine("enter first side of the triangle");
      int a = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("enter second side of the triangle");
      int b = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("enter third side of the triangle");
      int c = Convert.ToInt32(Console.ReadLine());
        
        if (a == b && a == c )
        {
             Console.WriteLine("Equilateral");
        }
        else if(a == b || a == c || b == c)
        {
            Console.WriteLine("Isosceles");
        }
        else
        {
            Console.WriteLine("Scalene");
        }
    }
        }
        