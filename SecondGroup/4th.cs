 class Probl4{
    public static void Leap(){
      Console.WriteLine("Enter a year to check its leap or not");
      int x = Convert.ToInt32(Console.ReadLine());

     if (x%4 == 0)
     {
         Console.WriteLine(x + " " + " is leap year");
     } 
     else{
         Console.WriteLine(x + " " + " is not a leap year");
     }
        
    }
}