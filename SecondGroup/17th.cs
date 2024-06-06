 class Probl17{
    public static void Profit(){
      Console.WriteLine("Input the cost prise");
      int cost = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Input selling prise");
      int sell = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Input the selling prise");
     int diff = sell - cost;
     if (sell < cost)
     {
         Console.WriteLine("You can not book your loss amount : " + Math.Abs(diff));
     }
     else
     {
         Console.WriteLine("You can book your profit amount : " + diff);
     }

    }
}