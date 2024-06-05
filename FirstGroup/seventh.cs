public class Exchange  {
    public static String charex(){
       String str = "abcd";
       //save the first char
      char temp = str[0];
      //replace the last char with the first one
      String result = str.Replace(str[0], str[str.Length - 1]);
      // remove the last one
      result = result.Remove(result.Length - 1);
      // add the firs char at the end
      return result + temp;

    }
    }