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

namespace System.Ace.UserManagement
{
    public struct UserInformation
    {
        public string Username, Password, Firstname, MiddleName, LastName, EmailAddress;
    }

    public class ClassUserManagement
    {
        Connector connect = new UserLogin();
        public event Action<object> Callback_Login;
        public event Action<DataTable, object> Callback_UserList;

        public ClassUserManagement()
        {
            //ClassDatabase cd = new ClassDatabase();
            //cd.SetConnection(new DatabaseInformation
            //{
            //    Server = "db4free.net",
            //    Port = "3306",
            //    Database = "acepasag",
            //    Username = "acepasag",
            //    Password = "acepasag"
            //});
        }

        public void UserLogin(UserInformation userinfo)
        {
            var dr = new DataTraider();
            dr.Login(connect, userinfo, Callback_Login);
        }
    }

    internal class DataTraider
    {
        public void Login(Connector connect, UserInformation userinfo, Action<object> CallBack)
        {
            connect.Login(userinfo.Username, userinfo.Password, CallBack);
        }
    }

    internal abstract class Connector
    {
        public abstract void Login(string username, string password, Action<object> CallBack);
    }

    internal class UserLogin : Connector
    {
		ClassDatabase cd = new ClassDatabase();
		OdbcDataAdapter adapter = new OdbcDataAdapter();
		DataTable Table = new DataTable();

        delegate void AsyncLogin(string username, string password, Action<object> CallBack);

        public override void Login(string username, string password, Action<object> CallBack)
        {
            AsyncLogin a = (u, p, cb) =>
                {
                    Table = new DataTable();
                    cd = new ClassDatabase();
                    cd.SetConnection(new DatabaseInformation
                    {
                        Server = "db4free.net",
                        Port = "3306",
                        Database = "acepasag",
                        Username = "acepasag",
                        Password = "acepasag"
                    });
                    cd.SetConnectionOpen();
                    adapter = new OdbcDataAdapter();
                    adapter = cd.GetAdapter("select * from tblUserCredentials");
                    cd.SetConnectionClose();
                    adapter.Fill(Table);

                    foreach (DataRow value in Table.Rows)
                    {
                        if (username == value[1].ToString() && password == value[2].ToString())
                        {
                            CallBack(true);
                        }
                    }
                };
            AsyncCallback ac = (iar) =>
                {
                    a = (AsyncLogin)((AsyncResult)iar).AsyncDelegate;
                    a.EndInvoke(iar);
                    if (CallBack != null) 
                    {
                        CallBack(null);
                    }
                };
            IAsyncResult ar = a.BeginInvoke(username, password,CallBack, ac, null);
        }
    }
}