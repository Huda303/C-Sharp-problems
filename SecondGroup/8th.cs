 class Probl8{
    public static void Largest(){
      Console.WriteLine("Enter num 1");
      int m = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter num 2");
      int n = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter num 3");
      int u = Convert.ToInt32(Console.ReadLine());
     if (m>n && m>u)
     {
        Console.WriteLine("The 1st Number is the greatest among three");
     } 
     else if (n>m && n>u){
         Console.WriteLine("The 2nd Number is the greatest among three");
     }
     else 
     {
       Console.WriteLine("The 3rd Number is the greatest among three");
     }

    }
}