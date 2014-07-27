using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;
using System.Runtime.Remoting.Messaging;
using System.Data.Odbc;
using System.Windows.Forms;

namespace System.Ace.Database
{
    public class ClassDatabase
    {
        Connector connect_odbc = new DatabaseConnector();
        
        public DatabaseInformation datainfo { get; set; }

        public void SetConnection(DatabaseInformation datainfo)
        {
            var traider = new DataTraider();
            traider.SetConnection(connect_odbc, datainfo);
        }

        public void SetConnectionOpen()
        {
            var traider = new DataTraider();
            traider.SetConnectionOpen(connect_odbc);
        }

        public void SetConnectionClose()
        {
            var traider = new DataTraider();
            traider.SetConnectionClose(connect_odbc);
        }

        public OdbcDataAdapter GetAdapter(string Query)
        {
            var traider = new DataTraider();
            return traider.SetDataAdapter(connect_odbc, "select * from tbltest");
        }
    }

    internal class DataTraider
    {
        public void SetConnection(Connector connect, DatabaseInformation datainfo)
        {
            connect.SetConnection(datainfo);
        }

        public void SetConnectionOpen(Connector connect)
        {
            connect.SetConnectionOpen();
        }

        public void SetConnectionClose(Connector connect)
        {
            connect.SetConnectionClose();
        }

        public OdbcDataAdapter SetDataAdapter(Connector connect, string Query)
        {
            return connect.SetConnectionAdapter(Query);
        }
    }

    public struct DatabaseInformation
    {
        public string Server, Port, Database, Username, Password;
    }

    internal abstract class Connector
    {
        public abstract void SetConnection(DatabaseInformation datainfo);
        public abstract void SetConnectionOpen();
        public abstract void SetConnectionClose();
        public abstract OdbcDataAdapter SetConnectionAdapter(string Query);
    }

    internal class DatabaseConnector : Connector
    {
        OdbcConnection OdbcConnection = null;
        OdbcDataAdapter OdbcDataAdapter = null;
        OdbcCommand OdbcCommand = null;

        public override void SetConnection(DatabaseInformation datainfo)
        {
            if (datainfo.Database != null &&
                datainfo.Password != null &&
                datainfo.Port != null &&
                datainfo.Server != null &&
                datainfo.Username != null)
            {
                OdbcConnection = new OdbcConnection();
                OdbcConnection.ConnectionString = "Driver={MySQL ODBC 5.2 UNICODE Driver};Server=db4free.net;Port=3306;Database=acepasag;User=acepasag;Password=acepasag;";
            }
            else
            {
                throw new Exception("Invalid Database Information");
            }
        }

        public override void SetConnectionOpen()
        {
            if (OdbcConnection.State == ConnectionState.Open)
            {
                OdbcConnection.Close();
            }
            OdbcConnection.Open();
            MessageBox.Show("Open");
        }

        public override void SetConnectionClose()
        {
            OdbcConnection.Close();
        }

        public override OdbcDataAdapter SetConnectionAdapter(string Query)
        {
            OdbcDataAdapter = new OdbcDataAdapter();
            OdbcDataAdapter.SelectCommand = new OdbcCommand(Query, OdbcConnection);
            return OdbcDataAdapter;
        }


    }
}