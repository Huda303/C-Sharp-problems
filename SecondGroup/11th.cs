 class Probl11{
    public static void Real(){
      Console.WriteLine("enter number 1");
      int a = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("enter number 2");
      int b = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("enter number 3");
      int c = Convert.ToInt32(Console.ReadLine());
      double res1;
      double res2;
      double res3;
    //تمهيد العمليات
    res1 =(b*b) - (4*a*c);
    res2 = b + Math.Sqrt(res1) / 2*a;
    res3 = b - Math.Sqrt(res1) / 2*a;
    // نتأكد ان المقام لايساوي صفراَ
    if (a != 0)
    {
            if (res2 < 0)
        {
                  Console.WriteLine("Root are imaginary");
        }
        else if (res3 < 0){
                          Console.WriteLine("Root are imaginary");
        }
        else
        {
                          Console.WriteLine("Root are real");
        }
    }
    else
    {
         Console.WriteLine("Error");
       
    }
    
    }
}