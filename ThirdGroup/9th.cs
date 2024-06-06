class Proble9{
    public static void CheckVowel(){
    //alot of worinings
    Console.WriteLine("Enter a string");
    string m = Console.ReadLine();
    int countV = 0;
    int countC = 0;
    for (int i = 0; i < m.Length; i++)
    {
        if (m[i] == 'a' || m[i] == 'e' || m[i] == 'i' || m[i] == 'u' || m[i] == 'o')
        {
            countV++;
        }
        else if(m[i] == 'A' || m[i] == 'E' || m[i] == 'I' || m[i] == 'U' || m[i] == 'O')
        {
            countV++;
        }
        else
        {
            countC++;
        }
    }
                Console.WriteLine("The total number of vowel in the string is : " + countV);
                Console.WriteLine("The total number of consonant in the string is : " + countC);
    }
}
