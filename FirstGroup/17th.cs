 class Prob17{
    public static String StringYt(){
// goal: to check if the given string contains 'yt' at the position 1 if its return the string without it , if its not return it the same
 //save it into a var
 //remove the 'yt' frome the string 
 //return the result

    string str = "jsues";
    string res = "";
    if(str[1] == 'y' && str[2] == 't'){
            res = str.Remove(1 ,2);
        }
        else
    {
        return res = str;
    }
    return res;
    }
    }