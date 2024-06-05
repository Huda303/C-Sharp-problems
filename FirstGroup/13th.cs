class Prob13{
    public static Boolean CheckWeather(){
        //checking if the ints are in the range or not
        int x = 2;
        int y = 120;
        if (x<0 || x>100 && y<0 && y>100 )
        {
            return true;
        }
        else{
            return false;
        }
    }
    }