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
            Cryptography crypt = new Cryptography();
            
            for (int i = 0; i < 20; i++)
            {
                System.Threading.Thread.Sleep(100);
                Console.WriteLine(Cryptography.Encrypt("a A"));
            }
            Console.Read();
        }
    }

    public class Cryptography
    {
        private static readonly Random ran = new Random();

        public Cryptography() { }

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

        static void Generate_PhaseMain(PhraseType type)
        {
            if (type == PhraseType.FixedPoint)
            {
                int i = ran.Next(1, 3);
                switch (i)
                {
                    case 1:
                        PhaseMain = new object[]
                        {
                            "1Bq","6oa","pAz","4nB","zAa","2aB",
                            "6yz","1Ba","4Aq","6bq","2Aa","5sz",
                            "3tz","4rB","1ka","2vq","50z","5Ba",
                            "4Aq","3ea","2jA","hBz","1gA","fBq",
                            "3wA","2Bq",

                            "i1q","62A","p3Z","4N4","z5A","2A6",
                            "Y1Z","1ua","4Lq","6bQ","25a","5sZ",
                            "3tZ","R2Q","1k3","24q","5cZ","56A",
                            "4xq","3e2","2J3","h4Z","1G5","f6q",
                            "w1a","22Q"
                        };
                        break;
                    case 2:
                        PhaseMain = new object[]
                        {
                            "j31","2kw","b5d","4cf","r9g","8sH",
                            "q4I","sl1","C6a","vD3","b0q","nT7",
                            "H5a","0mx","z74","2e5","p16","6u7",
                            "z6G","3N9","r8y","tF1","Y2o","uv5",
                            "f72","8Oe",

                            "8ej","p79","1x9","03g","n31","a4w",
                            "Md9","o6q","0we","h9D","W4m","x3X",
                            "0c8","r5l","av1","8if","l5F","t2y",
                            "ib1","4s0","2uF","gj7","6kf","z1j",
                            "2aK","pT3"
                        };
                        break;
                    case 3:
                        PhaseMain = new object[]
                        {
                            "pAz","b5d","zAa","r9g","1Ba","sl1",
                            "6bq","vD3","5sz","nT7","3tz","H5a",
                            "1ka","z74","50z","p16","3ea","3N9",
                            "hBz","tF1","fBq","uv5","3wA","f72",
                            "8ej","62A",

                            "62A","1x9","4N4","n31","2A6","Md9",
                            "0we","1ua","W4m","6bQ","8if","5sZ",
                            "3tZ","r5l","1k3","t2y","5cZ","l5F",
                            "ib1","3e2","2uF","h4Z","6kf","f6q",
                            "j31","1Bq"
                        };
                        break;
                }
                
                
            }
            else if (type == PhraseType.TwoPoint)
            {

            }
            else if (type == PhraseType.MultiplePoint)
            {

            }
        }
        static void Generate_PhaseEnd(KeyType key)
        {
            
            if (key == KeyType.Point3)
            {
                PhaseEnd = new object[][]
                {
                    new object[] {@"\","¿","Ô","ä","a"},
                    new object[] {"é","7","Õ","k","("},
                    new object[] {"å","ì","O","ê","þ"},
                    new object[] {"Ċ","Ġ","ß","Ē",")"},
                    new object[] {"[","Ó","ĉ","¾","s"},
                    new object[] {"č","8","±","l","û"},
                    new object[] {"Ö","ã","P","¬­","_"},
                    new object[] {"«","Ã","ô","Ê","Ĝ"},
                    new object[] {"]","Î","Ĩ","Ě","d"},
                    new object[] {"Ø","9","Ģ","z","ą"},
                    new object[] {"ù","½","A","Ý","|"},
                    new object[] {"Ć","Ü","ü","§","Ď"},
                    new object[] {"]","¥","Û","Ì","f"},
                    new object[] {"Ð","0","ð","x","ø"},
                    new object[] {"Ĳ","Ė","S","Ò","`"},
                    new object[] {"ľ","Ą","°","Ŕ","ǎ"},
                    new object[] {";","ŋ","ǐ","µ","g"},
                    new object[] {"ũ","-","¼","c","Ǘ"},
                    new object[] {"ţ","ú","D","ł","{"},
                    new object[] {"Į","ơ","ŉ","ĸ","Ï"},
                    new object[] {"'","ś","Ù","ç","h"},
                    new object[] {"Ķ","+","ı","v","ĥ"},
                    new object[] {"Ŀ","ĳ","F","Ǖ","}"},
                    new object[] {"Ų","ĵ","ŏ","Ň","ń"},
                    new object[] {",","Ǔ","º","Ĺ","j"},
                    new object[] {"İ","=","»","b",":"},
                    
                    new object[] {".","ǘ","³","ō","r"},
                    new object[] {@"'","V","Ǿ","n","Ľ"},
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
                    new object[] {"Ń","¯","ǔ","T","ň"},
                    
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
        }

        static string Generate_PM_Encrypt(string file)
        {
            string Temp = "";
            #region Indexing
            for (int i = 0; i < file.Length; i++)
            {
                if (file[i] != ' ')
                {
                    for (char s = 'a'; s <= 'z'; s++)
                    {
                        if (file[i] == s)
                        {
                            Temp += PhaseMain[i] + "";
                            goto OutSide;
                        }
                    }
                    for (char b = 'A'; b <= 'Z'; b++)
                    {
                        if (file[i] == b)
                        {
                            Temp += PhaseMain[i] + "";
                            goto OutSide;
                        }
                    }
                }
                else
                {
                    Temp += "~";
                }
            OutSide:
                continue;
            }
            #endregion
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
                    }
                }
            }
            return Original;
        }

        public static string Encrypt(string text)
        {
            Generate_PhaseMain(PhraseType.FixedPoint);
            Generate_PhaseEnd(KeyType.Point3);
            return Generate_PE_Encrypt(Generate_PM_Encrypt(text));
        }

        public static string Encrypt(string text, PhraseType Type)
        {
            return "";
        }
    }
}