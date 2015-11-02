using System.Data;
using System.Collections.Generic;
using System;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;
using System.Data.SqlClient;
using System.Configuration;
using PhotoOrganizer.PictureObjects;

namespace PhotoOrganizer.Repository
{
    public partial class Repository
    {
        protected readonly IDbConnection connection;
        protected static readonly string connString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        public Repository()
        {
            connection.ConnectionString = connString;
        }

        public Repository(string source, string catalog, bool security)
        {
            // this.connection = connection;
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder()
            {
                DataSource = source, //localhost",
                InitialCatalog = catalog, //"Scratch",
                IntegratedSecurity = security //true
            };
            connection.ConnectionString = scsb.ConnectionString;
        }

        public Dictionary<string, Object> GetRecordData(int id, Type type)
        {
            string table = null;
            string commandString = null;
            DataTable dt = new DataTable();

            switch(type.ToString())
            {
                case "Tag":
                    table = "Tag";
                    break;
                case "Picture":
                    table = "Picture";
                    break;
                case "Location":
                    table = "Location";
                    break;
            }

            commandString = "SELECT * FROM "
                + table + " "
                + "WHERE id = " + id;

            using (SqlConnection conn = new SqlConnection(connection.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(commandString))
                {
                    dt.Load(command.ExecuteReader());
                }
            }

            return ConvertToDictionary(dt);
        }

        internal Dictionary<string, object> ConvertToDictionary(DataTable dt)
        {
            return dt.AsEnumerable()
              .ToDictionary<DataRow, string, object>(row => row.Field<string>(0), row => row.Field<object>(1));
        }
    }
}
