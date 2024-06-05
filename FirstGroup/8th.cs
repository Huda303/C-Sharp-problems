 class Prob8{
    public static String CopiesString(){
       //take the last letter of string and save it
       //copy it in the front and end of the original string
        string str = "c sharp";
        string res = "";
        if (str.Length > 1 )
        {
            res = str.Remove(2);
            return res + res + res + res;
        }
        else {
            return str;
        }
        
    }
}