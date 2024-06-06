class Probl16{
    public static void Vowel()
    {
        Console.WriteLine("check the char");
      char a = Convert.ToChar(Console.ReadLine());
      switch (a)  // Switch statement to check for vowels
       { 
         case 'a':
             Console.WriteLine("The char is vowel");  
             break;
         case 'i':
             Console.WriteLine("The char is vowel"); 
             break;
         case 'o':
             Console.WriteLine("The char is vowel");  
             break;
         case 'u':
             Console.WriteLine("The char is vowel");  
             break;
         case 'e':
             Console.WriteLine("The char is vowel"); 
             break;
         default:
             Console.WriteLine("The char is not a vowel");  
             break;
    }
        }
    }