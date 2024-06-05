 class Prob9{
    public static String CopiesString(){
       //take the last letter of string and save it
       //copy it in the front and end of the original string
        string str = "1";
        string res = "";
        res = str.Remove(0, str.Length-1);
        return res + str + res;
       
    }
}