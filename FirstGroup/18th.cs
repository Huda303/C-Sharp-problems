 class Prob18{
    public static int BigestInt3(){
        // goal: to return the bigest int given between 3 ints
        int x = 1;
        int y = 1;
        int z = 2;
        if (x>y && x>z)
        {
            return x;
        }
        else if(y>x && y>z){
            return y;
        }
        else{
            return z;
        }
    }
    }