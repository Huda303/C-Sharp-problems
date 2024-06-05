 class Probl10{
    public static void Admission(){
      Console.WriteLine("Input the marks obtained in Physics");
      int m = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Input the marks obtained in Chemistry");
      int n = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Input the marks obtained in Mathematics");
      int u = Convert.ToInt32(Console.ReadLine());
     if (m>=65 && n>=55 && u>=50 && m+n+u >= 140 || m+n+u >= 180 )
     {
        Console.WriteLine("The candidate is eligible for admission");
     } 
     else 
     {
        Console.WriteLine("The candidate is not eligible for admission.");
     }

    }
}