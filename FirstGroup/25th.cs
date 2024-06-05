 class Prob25{
    public static String CopiesString(){
       // الهدف من هذا البرنامج هو تكرار الكلمة المعطاة بنفس عدد المتغير n
        int n = 4;
        string str = "js";
        // اعطيناها "" لان بدونها النتيجة تطلع boolen
        string res = "";
        //checking the value of n and give the resulte to n and rep the process 
        for (int i = 0; i < n; i++)
        {
            res = res + str;
        }
        return res;
    }
}