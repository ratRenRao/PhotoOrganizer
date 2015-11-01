using System.Data;
using System.Collections.Generic;
using System;
using System.Collections;
using System.Linq.Expressions;
using System.Data.SqlClient;

namespace PhotoOrganizer.Repository
{
    class Repository : IRepository
    {
        public class Repository
        {
            //protected IDbConnection Connection;
            protected static readonly IDbConnection connection;

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
        }
    }
}
