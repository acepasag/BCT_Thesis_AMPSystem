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
    public class ClassUserManagement
    {
        public ClassUserManagement()
        {
            var Database = new ClassDatabase();
            Database.SetConnection();
        }
    }

    internal class DataTraider
    {
        public void Login(Connector connect, string username, string password)
        {
            
        }
    }

    internal abstract class Connector
    {
        public abstract void Login(string username, string password);
    }

    internal class UserLogin : Connector
    {
        delegate void AsyncLogin(string username, string password);

        public override void Login(string username, string password)
        {
            AsyncLogin a = (u,p) =>
                {
                    
                };
            AsyncCallback ac = (iar) =>
                {
 
                };
            IAsyncResult ar = a.BeginInvoke(username, password, ac, null);
        }
    }
}