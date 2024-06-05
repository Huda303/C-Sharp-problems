 class Prob19{
    public static int CloserTo100(){
        //goal: to cheack the closet number to 100 between 2 given numbers
        int x = 99;
        int y = 99;
        if (x > y && x <= 100)
        {
            return x;
        }
        else if(x == y){
            return 0;
        }
        else{
            return y;
        }
    }
    }