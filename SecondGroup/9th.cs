 class Probl9{
    public static void Quadrant(){
      Console.WriteLine("Enter num 1");
      int m = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter num 2");
      int n = Convert.ToInt32(Console.ReadLine());
     if (m>0 && n>0 )
     {
        Console.WriteLine("The coordinate point"+ (m,n) +"lies in the First quadrant");
     } 
     else if (m<0 && n>0 ){
        Console.WriteLine("The coordinate point"+ (m,n) +"lies in the Second quadrant");
     }
     else if (m<0 && n<0){
        Console.WriteLine("The coordinate point"+ (m,n) +"lies in the Third quadrant");
     }
     else 
     {
        Console.WriteLine("The coordinate point"+ (m,n) +"lies in the Fourth quadrant");
     }

    }
}