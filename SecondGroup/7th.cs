 class Probl7{
    public static void Height(){
      Console.WriteLine("Enter your height");
      int m = Convert.ToInt32(Console.ReadLine());
     if (m>=100 && m<150)
     {
        Console.WriteLine("The person is Dwarf");
     } 
     else if (m>=150 && m<180){
         Console.WriteLine("The person is avraige");
     }
     else 
     {
       Console.WriteLine("The person is tall");
     }

    }
}