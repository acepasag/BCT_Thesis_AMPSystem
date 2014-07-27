using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Odbc;

using System.Ace.Security.Cryptography;

namespace AdvanceController
{
    class Program
    {
        static void Main(string[] args)
        {
            Cryptography cryp = new Cryptography();
            cryp.SetMainPhase();
            cryp.SetEndPhase();
            
            OdbcConnection Connection = new OdbcConnection();
            OdbcDataAdapter Adapter = new OdbcDataAdapter();
            OdbcCommand Command = new OdbcCommand();


            DataTable Table = new DataTable();

            string input = "a";

            while (input.Length > 0)
            {
                Console.WriteLine("a. Select List");
                Console.Write(">>");
                input = Console.ReadLine();
                
                Connection.ConnectionString = "Driver={MySQL ODBC 5.2 UNICODE Driver};Server=db4free.net;Database=acepasag;User=acepasag;Password=acepasag;Option=3";
                Adapter = new OdbcDataAdapter();
                Connection.Open();
                if (input == "a")
                {
                Up:
                    Adapter.SelectCommand = new OdbcCommand("select * from tblUserCredentials", Connection);
                    Connection.Close();
                    Adapter.Fill(Table);
                
                    Console.WriteLine("User Credential List");
                    foreach (DataRow value in Table.Rows)
                    {
                        Console.WriteLine("{0} {1} {2} {3}", value[0], value[1], value[2], value[3]);
                    }
                    Console.Write("\na.Add \nb.update \nc.delete\n>> ");
                    input = Console.ReadLine();
                    
                    
                    string UID = "", PWD = "", AT = "";
                    
                    
                    if (input == "a")
                    {
                        Console.Write("\nUsername: ");
                        UID = Console.ReadLine();
                        Console.Write("\nPassword: ");
                        PWD = Console.ReadLine();
                        Console.Write("\nAccessType: ");
                        AT = Console.ReadLine();
                        Command = new OdbcCommand();
                        Command = new OdbcCommand("insert into tblUserCredentials (fuid,fpwd,fat) values('" + cryp.Encrypt(UID) + "','" + cryp.Encrypt(PWD) + "','" + cryp.Encrypt(AT) + "')", Connection);
                        Connection.Open();
                        Command.ExecuteNonQuery();
                        Connection.Close();
                        Console.Write("\nSaved\n");
                        goto Up;
                    }
                    else if (input == "b")
                    {
 
                    }
                    else if (input == "c")
                    {

                    }
                }
            }
            
            Console.Read();
        }
    }
}
