class Proble10{
    public static void CountChar(){
        //غير مكتمل
    //alot of worinings
    Console.WriteLine("Enter a string");
    string m = Console.ReadLine();
    int countC = 0;
    for (int i = 0; i < m.Length; i++)
    {
        if (m[i] == m[i])
        {
            countC++;
        }
        
    }
         Console.WriteLine("The total number of char in the string is : " + countC);
    }
}
