using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
           string calculate = System.Console.ReadLine();
           string num = "0";
           calculate += " ";
           double ans = 0, n;
           int symb = 0;
            for(int i = 0; i < calculate.Length; i++){
                if(calculate[i] - '\0' > 47 && calculate[i] - '\0' < 58){
                    num += calculate[i];
                }
                else{
                    n = Convert.ToDouble(num);
                    num = "0";
                    switch(symb){
                        case 0 :
                            ans += n;
                            break;
                        case 1 :
                            ans -= n;
                            break;
                        case 2 :
                            ans *= n;
                            break;
                        case 3 :
                            ans /= n;
                            break;
                    }
                    
                    switch(calculate[i]){
                        case '-':
                            symb = 1;
                            break;
                        case '+':
                            symb = 0;
                            break;
                        case '*':
                            symb = 2;
                            break;
                        case '/':
                            symb = 3;
                            break;
                    }
                }
            }
            System.Console.WriteLine(ans);
        }
    }
}
