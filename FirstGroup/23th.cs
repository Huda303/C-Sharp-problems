using System.Linq.Expressions;

class Prob23{
    public static Boolean Last3Digits(){
        // goal: convert the int value into a sting and then compare between the last digit if it was the same or not
        int x = 12;
        int y = 412;
        //converting
        String strX = x.ToString();
        String strY = y.ToString();
        //comparing
        if (strX[strX.Length-1] == strY[strY.Length-1])
        {
            return true;
        }
        else{
            return false;
        }
    }
    }