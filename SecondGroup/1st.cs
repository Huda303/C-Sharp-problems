 class Probl1{
    public static void Entering(){
      Console.WriteLine("Enter x value");
      int x = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter y value");
     int y = Convert.ToInt32(Console.ReadLine());
     if (x == y)
     {
         Console.WriteLine(x + " " + "is equal to" + " " + y);
     } 
     else{
         Console.WriteLine(x + " " + "is not equal to" + " " + y);
     }
        
    }
}