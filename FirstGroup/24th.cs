class Prob24{
    public static String Last3ToUpper(){
        //the goal is to make the last 3 chars in the word into an upper case and if the word is less than 3 make it all in upper case 
        string str = "python";
        string res = "";
        //check the string if its less than 3 chars
        if (str.Length < 3){
            return str.ToUpper();
        }
        //اذا كانت الكلمة اطول من 3 حروف نجزئها نقلب النهاية الى حرف كبير ثم نعيد جمعها مع الكلمة المتبقية
        else
        {
            //length-3 the reach the last 3 chars and save it into result
            for (int i = str.Length-3; i < str.Length; i++)
            {
                res = res + str[i];
            }
            // make the last 3 upper
            res = res.ToUpper();
        }
        // remove the last 3 chars from the old string and replace it with the new one
        return str.Remove(str.Length - 3) + res;
    }
    }