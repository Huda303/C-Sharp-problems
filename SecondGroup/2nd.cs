 class Probl2{
    public static void CheckEven(){
      Console.WriteLine("Enter x value");
      int x = Convert.ToInt32(Console.ReadLine());
     if (x%2 == 0)
     {
         Console.WriteLine(x + " " + " is even number");
     } 
     else{
         Console.WriteLine(x + " " + " is odd number");
     }
        
    }
}