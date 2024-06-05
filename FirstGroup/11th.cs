 class Prob11{
    public static String CopiesString(){
       //take the first 3 letters of string and save it
       //copy it in the front and end of the original string
        string str = "python";
        string res = "";
        
        //for strings are less than 3 chars
        if (str.Length < 3)
        {
            return res = str + str +str;
        }
        else{
            //saving the first 3 chars
            res = str.Remove(3);
             //concat the chars with the original string
            return res + str + res;
        }
       
    }
}