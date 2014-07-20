﻿using System;
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
            Cryptography.Encrypt("Ace");
            Console.Read();
        }
    }

    public class Cryptography
    {
        static Random ran = new Random();

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
                    "1iAq","6oBa","6pAz","4nBz","4zAa","2aBq",
                    "6yAz","1uBa","4lAq","6bBq","2xAa","5sBz",
                    "3tAz","4rBq","1kAa","2vBq","5cAz","5dBa",
                    "4eAq","3eBa","2jAz","1hBz","1gAa","1fBq",
                    "3wAa","2qBq",

                    "1i1q","6O2A","6p3Z","4N4z","4z5A","2A6q",
                    "6Y1Z","1u2a","4L3q","6b4Q","2X5a","5s6Z",
                    "3t1Z","4R2Q","1k3A","2V4q","5c5Z","5D6A",
                    "4E1q","3e2a","2J3z","1h4Z","1G5a","1f6q",
                    "3w1a","2Q2Q"
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
                    new object[] {"Q","X","y"},
                    new object[] {"_","z","7"},
                    new object[] {"W","Z","w"},
                    new object[] {"+","x","C"},
                    new object[] {"E",":","u"},
                    new object[] {"-","v","6"},
                    new object[] {"R",";","s"},
                    new object[] {")","t","V"},
                    new object[] {"T","L","q"},
                    new object[] {"(","r","5"},
                    new object[] {"Y","K","o"},
                    new object[] {"*","p","B"},
                    new object[] {"U","J","m"},
                    new object[] {"&","n","4"},
                    new object[] {"I","H","k"},
                    new object[] {"^","l","N"},
                    new object[] {"O","0","i"},
                    new object[] {"%","j","3"},
                    new object[] {"P","G","g"},
                    new object[] {"$","h","M"},
                    new object[] {"A","9","e"},
                    new object[] {"#","f","2"},
                    new object[] {"S","F","c"},
                    new object[] {"@","d"," "},
                    new object[] {"D","8","a"},
                    new object[] {"!","b","1"},
                };
            }
        }

        static string Generate_Encryt(string file)
        {
            string output = "";
            string[] match = new string[0];

            for (int i = 0, cnt = 0; i < file.Length; i++ )
            {
                
                if (file[i] != ' ')
                {
                    for (char s = 'a'; s <= 'z'; s++)
                    {
                        if (file[i] == s)
                        {
                            Array.Resize<string>(ref match, match.Length + 1);
                            match[match.Length - 1] = cnt + "";
                            goto OutSide;
                        }
                        cnt++;
                    }
                    for (char b = 'A'; b <= 'Z'; b++)
                    {
                        if (file[i] == b)
                        {
                            Array.Resize<string>(ref match, match.Length + 1);
                            match[match.Length - 1] = cnt + "";
                            goto OutSide;
                        }
                        cnt++;
                    }
                }
                else 
                {
                    Array.Resize<string>(ref match, match.Length + 1);
                    match[match.Length - 1] = cnt + "~";
                }
                OutSide:
                cnt = 0;
            }

            for (int main = 0, cnt = 0; main < PhaseMain.Length; main++, cnt++)
            {
                for (int mainchar = 0; mainchar < PhaseMain[main].ToString().Length; mainchar++)
                {
                    output += (PhaseMain[main].ToString()[ran.Next(0, PhaseMain[main].ToString().Length)]).ToString();
                }
            }
            return "";
        }

        public static string Encrypt(string text)
        {
            Generate_PhaseMain(PhraseType.FixedPoint);
            Generate_PhaseEnd(KeyType.Point3);
            return Generate_Encryt(text);
        }

        public static string Encrypt(string text, PhraseType Type)
        {
            return "";
        }
    }
}
