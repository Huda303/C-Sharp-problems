 class Probl5{
    public static void CheckAge(){
      Console.WriteLine("Enter your age");
      int x = Convert.ToInt32(Console.ReadLine());

     if (x >= 21)
     {
         Console.WriteLine("Congratulation! You are eligible for casting your vote");
     } 
     else{
         Console.WriteLine(" You are not ready yet");
     }
        
    }
}