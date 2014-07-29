using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;
using System.Data.OleDb;
using System.Runtime.Remoting.Messaging;
using System.Data.Odbc;
using System.Windows.Forms;

using System.Ace.Database;
using System.Ace.Security.Cryptography;

namespace System.Ace.UserManagement
{
    public struct UserInformation
    {
        public string Username, Password, Firstname, MiddleName, LastName, EmailAddress,AccessType;
    }

    public class ClassUserManagement
    {
        Connector connect = new UserLogin();

        public event Action<object, string> Callback_Login;
        delegate void AsyncLogin(UserInformation userinfo);
        public void UserLogin(UserInformation userinfo)
        {
            AsyncLogin a = (ui) =>
                {
                    var dr = new DataTraider();
                    Callback_Login(dr.Login(connect, userinfo), dr.AccessType(connect));
                };
            AsyncCallback ac = (iar) =>
                {
                    a = (AsyncLogin)((AsyncResult)iar).AsyncDelegate;
                    a.EndInvoke(iar);
                    if (Callback_Login != null)
                    {
                        Callback_Login(null, null);
                    }
                };
            IAsyncResult ar = a.BeginInvoke(userinfo, ac, null);
        }
    }

    internal class DataTraider
    {
        public bool Login(Connector connect, UserInformation userinfo)
        {
            return connect.Login(userinfo);
        }

        public string AccessType(Connector connect)
        {
            return connect.AccessType();
        }
    }

    internal abstract class Connector
    {
        public abstract string AccessType();
        public abstract bool Login(UserInformation userinfo);
    }

    internal class UserLogin : Connector
    {
        string AT = "";

        Cryptography cg = new Cryptography();
		OdbcDataAdapter adapter = new OdbcDataAdapter();
		DataTable Table = new DataTable();

        public override string AccessType()
        {
            return this.AT;
        }
        public override bool Login(UserInformation userinfo)
        {
            AT = "";
            ClassDatabase cd = new ClassDatabase();
            Table = new DataTable();
            
            cg = new Cryptography();
            cg.SetMainPhase();
            cg.SetEndPhase();

            cd.SetConnection(new DatabaseInformation
            {
                Server = "db4free.net",
                Port = "3306",
                Database = "acepasag",
                Username = "acepasag",
                Password = "acepasag"
            });
            
            adapter = new OdbcDataAdapter();
            cd.SetConnectionOpen();
            adapter = cd.GetAdapter("select * from tblUserCredentials");
            cd.SetConnectionClose();

            adapter.Fill(Table);

            bool result = false;
            if (Table.Rows.Count > 0)
            {
                foreach (DataRow value in Table.Rows)
                {
                    if (cg.Decrypt(value[1].ToString(), cg.Encrypt(userinfo.Username))
                        && cg.Decrypt(value[2].ToString(), cg.Encrypt(userinfo.Password)))
                    {
                        AT = cg.Decrypt(value[3].ToString());
                        result = true;
                        break;
                    }
                }
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}