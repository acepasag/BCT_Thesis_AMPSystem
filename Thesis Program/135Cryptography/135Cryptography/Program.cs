using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _135Cryptography
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i< 20; i++)
            {
                Cryptography crypt = new Cryptography();
                string container = Cryptography.Encrypt("abABx");
                Console.WriteLine("Encrypted:   "+container);
                Console.WriteLine("Decypted:    "+Cryptography.Decrypt(container));
            }
            Console.Read();
        }
    }

    public class Cryptography
    {
        private static readonly Random ran = new Random();

        public Cryptography() 
        {
            PhaseMain = new object[]{
            "1Bq","6oa","pAz","4nB","zAa","2aB",
            "6yz","1Ba","4Aq","6bq","2Aa","5sz",
            "3tz","4rB","1ka","2vq","50z","5Ba",
            "4Aq","3ea","2jA","hBz","1gA","fBq",
            "3wA","2Bq",

            "i1q","62A","p3Z","4N4","z5A","2A6",
            "Y1Z","1ua","4Lq","6bQ","25a","5sZ",
            "3tZ","R2Q","1k3","24q","5cZ","56A",
            "4xq","3e2","2J3","h4Z","1G5","f6q",
            "w1a","22Q"};

            PhaseEnd = new object[][]
                {
                    new object[] {"∞","¿","Ô","ä","a"},
                    new object[] {"é","7","Õ","k","("},
                    new object[] {"å","ì","O","ê","þ"},
                    new object[] {"Ċ","Ġ","ß","Ē",")"},
                    new object[] {"[","Ó","ĉ","¾","s"},
                    new object[] {"č","8","±","l","û"},
                    new object[] {"Ö","ã","P","π­","_"},
                    new object[] {"«","Ã","ô","Ê","Ĝ"},
                    new object[] {"]","Î","Ĩ","Ě","d"},
                    new object[] {"Ø","9","Ģ","z","ą"},
                    new object[] {"ù","½","A","Ý","|"},
                    new object[] {"Ć","Ü","ü","§","Ď"},
                    new object[] {"ф","¥","Û","Ì","f"},
                    new object[] {"Ð","0","ð","x","ø"},
                    new object[] {"Ĳ","Ė","S","Ò","`"},
                    new object[] {"ľ","Ą","°","Ŕ","ǎ"},
                    new object[] {";","ŋ","ǐ","µ","g"},
                    new object[] {"ũ","-","¼","c","Ǘ"},
                    new object[] {"ţ","ú","D","ł","{"},
                    new object[] {"Į","ơ","ŉ","ĸ","Ï"},
                    new object[] {"'","ś","Ù","ç","h"},
                    new object[] {"Ķ","+","ı","v","ĥ"},
                    new object[] {"Ŀ","₤","F","Ǖ","}"},
                    new object[] {"Ų","ĵ","ŏ","Ň","ń"},
                    new object[] {",","Ǔ","º","Ĺ","j"},
                    new object[] {"İ","=","»","b",":"},
                    
                    new object[] {".","ǘ","³","ō","r"},
                    new object[] {"Ω","V","Ǿ","n","Ľ"},
                    new object[] {"Ā","ë","G","ª","Ư"},
                    new object[] {"Ű","Ǻ","š","ů","Ǚ"},
                    new object[] {"/","Ũ","ī","²","t"},
                    new object[] {"<","B","Ǽ","m","÷"},
                    new object[] {"đ","Ť","H","æ","Ǒ"},
                    new object[] {"¶","Ů","ĭ","Ł","Ņ"},
                    new object[] {"!","N","¹","Ŵ","y"},
                    new object[] {">","Ĥ","ŵ","Q","Đ"},
                    new object[] {"ǚ","Ś","J","Ŝ","Ǐ"},
                    new object[] {"Ū","ſ","Ź","ų","Ə"},
                    new object[] {"@","M","ƒ","Ř","u"},
                    new object[] {"?","Ŧ","Ţ","W","Þ"},
                    new object[] {"ġ","į","K","ź","ñ"},
                    new object[] {"ö","©","Ă","ņ","ŭ"},
                    new object[] {"#","1","Ÿ","ý","i"},
                    new object[] {"ž","ĺ","ó","E","è"},
                    new object[] {"Ĉ","Ļ","L","Ĕ","ĕ"},
                    new object[] {"Ĭ","ķ","ò","¤","Ę"},
                    new object[] {"$","2","ļ","ę","o"},
                    new object[] {"Ë","¢","ė","R","ŕ"},
                    new object[] {"ħ","Œ","Z","ă","õ"},
                    new object[] {"ŷ","ï","œ","Ŏ","ć"},
                    new object[] {"%","3","ē","ā","p"},
                    new object[] {"Ń","♠","ǔ","T","ň"},
                    
                    new object[] {"^","ə","£","Ǜ","q"},
                    new object[] {"Ž","4","Â","Y","È"},
                    new object[] {"Ç","ű","X","ǒ","Ơ"},
                    new object[] {"Ŋ","Ú","ŀ","ż","ǖ"},
                    new object[] {"&","×","ư","ǜ","w"},
                    new object[] {"ǻ","5","ǿ","U","Ŭ"},
                    new object[] {"Æ","ť","C","Ő","Ō"},
                    new object[] {"Ī","ŧ","Š","ď","î"},
                    new object[] {"*","ş","®","ő","e"},
                    new object[] {"Ş","6","¡","I","Č"},
                };
        }

        public enum PhraseType
        {
            FixedPoint,
            TwoPoint,
            MultiplePoint
        };
        public enum KeyType
        {
            Point3,
            Point4,
            Point5,
            Point6
        };

        static object[] PhaseMain = null;
        static object[][] PhaseEnd = null;


        static string Generate_PM_Encrypt(string file)
        {
            string Temp = "";
            for (int i = 0; i < file.Length; i++)
            {
                int cnt = 0;
                if (file[i] != ' ')
                {
                    for (char s = 'a'; s <= 'z'; s++)
                    {
                        if (file[i] == s)
                        {
                            Temp += PhaseMain[cnt] + "";
                            goto OutSide;
                        }
                        cnt++;
                    }
                    for (char b = 'A'; b <= 'Z'; b++)
                    {
                        
                        if (file[i] == b)
                        {
                            Temp += PhaseMain[cnt] + "";
                            goto OutSide;
                        } cnt++;
                    }
                    for (int b= 0; b <= 9; b++)
                    {
                        
                        if (file[i] == b)
                        {
                            Temp += PhaseMain[cnt] + "";
                            goto OutSide;
                        } cnt++;
                    }
                }
                else
                {
                    Temp += "~";
                }
            OutSide:
                continue;
            }
            return Temp;
        }
        static string Generate_PE_Encrypt(string temp)
        {
            string Original = "";
            for (int main = 0; main < temp.Length; main++)
            {
                int cnt = -1;
                for (char s = 'a'; s <= 'z'; s++)
                {
                    cnt++;
                    if (temp[main] == s)
                    {
                        Original += PhaseEnd[cnt][ran.Next(0, PhaseEnd[cnt].Length)].ToString();
                        goto Outside;
                    }
                }
                cnt = -1;
                cnt += 26;
                for (char b = 'A'; b <= 'Z'; b++)
                {
                    cnt++;
                    if (temp[main] == b)
                    {
                        Original += PhaseEnd[cnt][ran.Next(0, PhaseEnd[cnt].Length)].ToString();
                        goto Outside;
                    }
                }
                cnt = -1;
                cnt += 52;
                for (int num = 0; num <= 9; num++)
                {
                    cnt++;
                    if (temp[main] + "" == num + "")
                    {
                        Original += PhaseEnd[cnt][ran.Next(0, PhaseEnd[cnt].Length)].ToString();
                        goto Outside;
                    }
                }
            Outside:
                continue;
            }
            return Original;
        }

        public static string Encrypt(string text)
        {
            return Generate_PE_Encrypt(Generate_PM_Encrypt(text));
        }

        static string Degenerate_PM_Decrypt(string file) 
        {
            string temp = "";
            for (int i = 0; i < file.Length; i++)
            {
                for (int j = 0; j < PhaseEnd.Length; j++)
                {
                    for (int k = 0; k < PhaseEnd[j].Length; k++)
                    {
                        
                        string a = file[i]+"";
                        string b = PhaseEnd[j][k]+"";
                        if (file[i].ToString() == PhaseEnd[j][k].ToString())
                        {
                            int cnt = 0;
                            for (char l = 'a'; l <= 'z'; l++)
                            {
                                if (cnt == j)
                                {
                                    temp += l--;
                                    goto Outer;
                                }
                                cnt++;
                            }
                            cnt = 0;
                            cnt += 26;
                            for (char m = 'A'; m <= 'Z'; m++)
                            {
                                if (cnt == j)
                                {
                                    temp += m;
                                    goto Outer;
                                }
                                cnt++;
                            }
                            cnt = 0;
                            cnt += 52;
                            for (int n = 0; n <= 9; n++)
                            {
                                if (cnt == j)
                                {
                                    temp += n+"";
                                    goto Outer;
                                }
                                cnt++;
                            }
                        Outer:
                            continue;
                        }
                    }
                }
            }
            return temp;
        }
        
        static string Degenerate_PE_Decrypt(string file) 
        {
            string temp = "", Original = "";
            int cnt = 0;
            for (int i = 0; i < file.Length; i++)
            {
                temp += file[i];
                cnt++;
                if ((cnt % 3) == 0)
                {
                    for (int j = 0; j < PhaseMain.Length; j++)
                    {
                        if (temp == PhaseMain[j].ToString())
                        {
                            Original += PhaseMain[j];
                            goto Outer;
                        }
                    }
                Outer:
                    temp = "";
                }
            }
            return Original;
        }

        public static string Decrypt(string text)
        {
            return Degenerate_PM_Decrypt(text);
        }
    }
}