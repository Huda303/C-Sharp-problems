 class Proble4{
    public static void SplitStrR(){
      Console.WriteLine("Enter a word");
      string x = Console.ReadLine();
        
       for (int i = x.Length-1 ; i >= 0 ; i--)
       {
       
      Console.WriteLine(x[i]);
      }
    }
}