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
                Console.WriteLine(Cryptography.Encrypt("Ace"));
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
                PhaseMain = new object[]
                {
                    "1Aq","6oa","pAz","4nB","zAa","2aB",
                    "6yz","1Ba","4Aq","6bq","2Aa","5sz",
                    "3tz","4rB","1ka","2vq","50z","5Ba",
                    "4Aq","3ea","2jA","hBz","1gA","fBq",
                    "3wA","2Bq",

                    "i1q","62A","p3Z","4N4","z5A","2A6",
                    "Y1Z","1ua","4Lq","6bQ","25a","5sZ",
                    "3tZ","R2Q","1k3","24q","5cZ","56A",
                    "41q","3e2","2J3","h4Z","1G5","f6q",
                    "w1a","22Q"
                };
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
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},

                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},

                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
                    new object[] {"","","","",""},
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
                if (temp[main].ToString() != " ")
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
                else
                {
                    Original += temp[main];
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