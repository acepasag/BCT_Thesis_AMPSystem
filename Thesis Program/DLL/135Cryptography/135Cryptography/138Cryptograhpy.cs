using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Ace.Security.Cryptography
{
    public class Cryptography
    {
		DataTraider dt = new DataTraider();
        ClassFixedPoint ce = new ClassFixedPoint();       
        /// <summary>
        /// Initialized Default key for Main Phase Key
        /// </summary>
        public void SetMainPhase()
        {
            dt.SetMainPhase(ce);
        }
        /// <summary>
        /// Initialized Custom key for Main Phase Key
        /// </summary>
        /// <param name="PhaseMain">Custom Key for Main Phase Key</param>
        public void SetMainPhase(object[] PhaseMain)
        {
            if (PhaseMain.Length > 0)
            {
                dt.SetMainPhase(ce, PhaseMain);
            }
            else
            {
                throw new ArgumentNullException("999", "Invalid Main Phase Key");
            }
        }
        /// <summary>
        /// Initialized Default key for End Phase Key
        /// </summary>
        public void SetEndPhase()
        {
            dt.SetEndPhase(ce);
        }
        /// <summary>
        /// Initialized Custom key for End Phase Key
        /// </summary>
        /// <param name="PhaseEnd">Custom Key for End Phase Key</param>
        public void SetEndPhase(object[][] PhaseEnd)
        {
            if (PhaseEnd.Length > 0)
            {
                dt.SetEndPhase(ce, PhaseEnd);
            }
            else
            {
                throw new ArgumentNullException("998", "Invalid Main Phase Key");
            }
        }
        /// <summary>
        /// Encrypt Message Based on Generated Pseudo-Random Key from MP and EP
        /// </summary>
        /// <param name="Text">Message to Encrypt</param>
        /// <returns>Return Encrypted Value</returns>
        public string Encrypt(string Text)
        {
            return dt.Encrypt(ce, Text);
        }
        /// <summary>
        /// Decrypt Encrypted Message Based on Generated Pseudo-Random Key from MP and EP
        /// </summary>
        /// <param name="Value">Message to Decrypt</param>
        /// <returns>Return Decrypted Message</returns>
        public string Decrypt(string Value)
        {
            return dt.Decrypt(ce, Value);
        }
        /// <summary>
        /// Decrypt Encrypted Message Based on Generated Pseudo-Random Key from MP and EP
        /// </summary>
        /// <param name="OriginalValue">Original Value to be Compare</param>
        /// <param name="BasedValue">Based Value to Compare with</param>
        /// <returns>Return Bool Result</returns>
        public bool Decrypt(string OriginalValue,string BasedValue)
        {
            return dt.Decrypt(ce, OriginalValue, BasedValue);
        }
    }

    internal class DataTraider
    {
        public void SetMainPhase(Connector connect)
        {
            connect.SetMainPhase();
        }
        public void SetMainPhase(Connector connect, object[] PhaseMain)
        {
            connect.SetMainPhase(PhaseMain);
        }
        public void SetEndPhase(Connector connect)
        {
            connect.SetEndPhase();
        }
        public void SetEndPhase(Connector connect, object[][] PhaseEnd)
        {
            connect.SetEndPhase(PhaseEnd);
        }
        public string Encrypt(Connector connect,string value) 
        {
            return connect.Encrypt(value);
        }
        public string Decrypt(Connector connect,string value) 
        {
            return connect.Decrypt(value);
        }
        public bool Decrypt(Connector connect, string OriginalValue, string BasedValue)
        {
            return connect.Decrypt(OriginalValue, BasedValue);
        }
    }

    internal abstract class Connector
    {
        public abstract void SetMainPhase();
        public abstract void SetMainPhase(object[] PhaseMain);
        public abstract void SetEndPhase();
        public abstract void SetEndPhase(object[][] PhaseEnd);
        public abstract string Encrypt(string value);
        public abstract string Decrypt(string value);
        public abstract bool Decrypt(string OriginalValue, string BasedValue);
    }

    internal class ClassFixedPoint : Connector
    {
        readonly Random ran = new Random();
        object[] PhaseMain = null;
        object[][] PhaseEnd = null;

        public ClassFixedPoint()
		{
			SetMainPhase();
			SetEndPhase();
		}

        public override void SetMainPhase()
        {
            PhaseMain = new object[]
            {
                "1Bq","6oa","pAz","4nB","zAa","2aB",
                "6yz","1Ba","4Aq","6bq","2Aa","5sz",
                "3tz","4rB","1ka","2vq","50z","5Ba",
                "4Aq","3ea","2jA","hBz","1gA","fBq",
                "3wA","2Bq","i1q","62A","p3Z","4N4",
                "z5A","2A6","Y1Z","1ua","4Lq","6bQ",
                "25a","5sZ","3tZ","R2Q","1k3","24q",
                "5cZ","56A","4xq","3e2","2J3","h4Z",
                "1G5","f6q","w1a","22Q","hfH","Us2",
                "j38","c83","N7w","cJ0","f82","f92",
                "2eD","3Fc"
            };
        }
        public override void SetMainPhase(object[] PhaseMain)
        {
            this.PhaseMain = PhaseMain;
        }
        public override void SetEndPhase()
        {
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
        public override void SetEndPhase(object[][] PhaseEnd)
        {
            this.PhaseEnd = PhaseEnd;
        }
        public override string Encrypt(string value)
        {
            return Encrypt_EP(Encrypt_MP(value));
        }
        public override string Decrypt(string value)
        {
            return Decrypt_EP(Decrypt_MP(value));
        }
        public override bool Decrypt(string OriginalValue, string BasedValue)
        {
            string _OriginalValue = Decrypt_MP(OriginalValue);
            string _BasedValue = Decrypt_MP(BasedValue);
            if (_OriginalValue.Equals(_BasedValue))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        string Encrypt_MP(string value)
        {
            string Temp = "";
            for (int i = 0; i < value.Length; i++)
            {
                int cnt = 0;
                if (value[i] != ' ')
                {
                    for (char s = 'a'; s <= 'z'; s++)
                    {
                        if (value[i] == s)
                        {
                            Temp += PhaseMain[cnt] + "";
                            goto OutSide;
                        }
                        cnt++;
                    }
                    for (char b = 'A'; b <= 'Z'; b++)
                    {

                        if (value[i] == b)
                        {
                            Temp += PhaseMain[cnt] + "";
                            goto OutSide;
                        } cnt++;
                    }
                    for (int b = 0; b <= 9; b++)
                    {

                        if (value[i] == b)
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
        string Encrypt_EP(string value)
        {
            string Original = "";
            for (int main = 0; main < value.Length; main++)
            {
                int cnt = -1;
                for (char s = 'a'; s <= 'z'; s++)
                {
                    cnt++;
                    if (value[main] == s)
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
                    if (value[main] == b)
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
                    if (value[main] + "" == num + "")
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
        string Decrypt_MP(string value)
        {
            string temp = "";
            for (int i = 0; i < value.Length; i++)
            {
                for (int j = 0; j < PhaseEnd.Length; j++)
                {
                    for (int k = 0; k < PhaseEnd[j].Length; k++)
                    {

                        string a = value[i] + "";
                        string b = PhaseEnd[j][k] + "";
                        if (value[i].ToString() == PhaseEnd[j][k].ToString())
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
                                    temp += n + "";
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
        string Decrypt_EP(string value)
        {
            string temp = "", Original = "";
            int maincnt = 0, basedcnt = 0;
            for (int i = 0; i < value.Length; i++)
            {
                temp += value[i];
                maincnt++;
                if ((maincnt % 3) == 0)
                {
                    for (int j = 0; j < PhaseMain.Length; j++)
                    {
                        if (temp == PhaseMain[j].ToString())
                        {
                            basedcnt = 0;
                            for (char l = 'a'; l <= 'z'; l++)
                            {
                                if (basedcnt == j)
                                {
                                    Original += l;
                                    goto Outer;
                                }
                                basedcnt++;
                            }
                            basedcnt = 0;
                            basedcnt += 26;
                            for (char m = 'A'; m <= 'Z'; m++)
                            {
                                if (basedcnt == j)
                                {
                                    Original += m;
                                    goto Outer;
                                }
                                basedcnt++;
                            }
                            basedcnt = 0;
                            basedcnt += 52;
                            for (int n = 0; n <= 9; n++)
                            {
                                if (basedcnt == j)
                                {
                                    Original += n + "";
                                    goto Outer;
                                }
                                basedcnt++;
                            }
                        }
                    }
                Outer:
                    temp = "";
                }
            }
            return Original;
        }
    }
}