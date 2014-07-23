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
        DataTable _Table = new DataTable();

        public DataTable Table { get { return _Table; } }

        public void SetConnection()
        {
            var traider = new DataTraider();
            Connector connect_oledb = new DatabaseConnector();
            traider.ImportData(connect_oledb);
        }
    }

    internal class DataTraider
    {
        public DatabaseInformation datainfo { get; set; }

        public void ImportData(Connector connect)
        {
            connect.Connect_Set(datainfo);
            connect.Connect_Open();
        }
    }

    internal struct DatabaseInformation
    {
        public string Server, Port, Database, Username, Password;
    }

    internal abstract class Connector
    {
        public abstract void Connect_Set(DatabaseInformation datainfo);
        public abstract void Connect_Open();
        public abstract void Connect_Close();
        public abstract void Connect_Select(string Query);
    }

    internal class DatabaseConnector : Connector
    {
        OdbcConnection OdbcConnection = null;
        OdbcDataAdapter OdbcDataAdapter = null;
        OdbcCommand OdbcCommand = null;

        public override void Connect_Set(DatabaseInformation datainfo)
        {
            if (datainfo.Database != null &&
                datainfo.Password != null &&
                datainfo.Port != null &&
                datainfo.Server != null &&
                datainfo.Username != null)
            {
                OdbcConnection = new OdbcConnection();
                OdbcConnection.ConnectionString = string.Format("Driver={MySQL ODBC 5.2 UNICODE Driver};Server={0};Port={1};Database={2};User={3};Password={4};", datainfo.Server, datainfo.Port, datainfo.Server, datainfo.Username, datainfo.Password);
            }
            else
            {
                throw new Exception("Invalid Database Information");
            }
        }
        public override void Connect_Open()
        {
            if (OdbcConnection.State == ConnectionState.Open)
            {
                OdbcConnection.Close();
            }
            OdbcConnection.Open();
        }
        public override void Connect_Close()
        {
            OdbcConnection.Close();
        }
        public override void Connect_Select(string Query)
        {
            OdbcDataAdapter = new OdbcDataAdapter();
            OdbcDataAdapter.SelectCommand = new OdbcCommand(Query, OdbcConnection);

        }
    }
}