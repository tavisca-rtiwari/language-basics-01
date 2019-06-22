using System;

namespace Tavisca.Bootcamp.LanguageBasics.Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Test("42*47=1?74", 9);
            Test("4?*47=1974", 2);
            Test("42*?7=1974", 4);
            Test("42*?47=1974", -1);
            Test("2*12?=247", -1);
            Console.ReadKey(true);
        }

        private static void Test(string args, int expected)
        {
            var result = FindDigit(args).Equals(expected) ? "PASS" : "FAIL";
            Console.WriteLine($"{args} : {result}");
        }

        public static int FindDigit(string equation)
        {
                        string strings =equation;
            string [] split = strings .Split(new Char [] {'*' , '=' });
            float a=0,b=0,c=0,d=0,mul1=0;
            int i=0;
            string s="";
            if(split[0].Contains("?") || split[1].Contains("?")){
            if(split[0].Contains("?")){
               i = split[0].IndexOf('?');
               mul1=float.Parse(split[1]);
               s=split[0];
            }
            else{
               i = split[1].IndexOf('?');
               mul1=float.Parse(split[0]);
               s=split[1];
            }
            c= float.Parse(split[2]);
            d=c/mul1;
            if((d-(int)(d))==0){
                strings = d.ToString();
                if(i==0 && String.Equals(strings,s.Substring(1))){
                    return -1;
                }
                return (int)Char.GetNumericValue(strings[i]);
            }
            else{
                return -1;
            }
        }
        else{
            a=float.Parse(split[0]);
            b=float.Parse(split[1]);
            s=split[2];
            i = split[2].IndexOf('?');
            d=a*b;
            strings = d.ToString();
                if(i==0 && String.Equals(strings,s.Substring(1))){
                    return -1;
                }
                return (int)Char.GetNumericValue(strings[i]);
        }
        
            throw new NotImplementedException();
        }
    }
}
