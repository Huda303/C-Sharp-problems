class Probl18{
    public static double ElectricityBill(){
    //couldn't run it
    int id = Convert.ToInt32(Console.ReadLine());
    int units = Convert.ToInt32(Console.ReadLine());
    String name = Console.ReadLine();

    double amount;
    if(units <= 199){
        amount = 1.20 * units;
    }
    else if(units >= 200 && units < 400){
        amount = 1.50 * units;
    }
    else if(units >= 400 && units < 600){
        amount = 1.80 * units;
    }
    else{
        amount = 2.0 * units;
    }

    if(amount >= 400){
        amount = amount + amount * 0.15;
        return amount;
    }
    else{
        return amount;
    }
}   
}

 
