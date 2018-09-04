using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using Microsoft.Extensions.Configuration;
using System.IO;
using BillifyAPI.Models;

namespace BillifyAPI
{
    public static class Orm
    {
        static OrmLiteConnectionFactory dbFactory;
        public static IConfiguration Configuration { get; set; }
        static IDbConnection db;
        static Orm()
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");

            Configuration = builder.Build();

            dbFactory = new OrmLiteConnectionFactory(Configuration["ConnectionString"], SqlServer2012Dialect.Provider);
            db = dbFactory.OpenDbConnection();
        }

        public static void CreateTable<T>()
        {
            // if (db.TableExists()

            db.CreateTableIfNotExists(typeof(T));
        }

        public static long Insert<T>(T o)
        {
            //string sql = "insert into invoices(invoiceDate, customerId, service, statusId, totalAmount, amountDue) " + 
             //   "VALUES " +
              //  string.Format(" (GETDATE(), {0}, {0}, {0}, {0}, {0}) ", o.customerId, o.service, o.statusId,;
            return db.Insert<T>(o, true);
        }

        public static void InsertAll<T>(IEnumerable<T> o)
        {
            //Trip test = new Trip { id = 12, ItineraryId = 112, destAirportCode = "OKC" };
            //db.Insert(test, true );
            db.InsertAll<T>(o);
        }

        public static int GetLastIndex(string table)
        {
            return db.Select<int>("select IDENT_CURRENT('" + table + "')").FirstOrDefault();
        }

        public static List<T> Query<T>(string q)
        {
            return db.Select<T>(q);
        }

        public static List<invoiceView> GetAllInvoices()
        {
            return db.Select<invoiceView>("select * from invoiceView");
        }

        public static List<T> Get<T>()
        {
            return db.Select<T>().ToList();
        }

        public static void Update<T>(T o)
        {
            db.Update<T>(o);
        }
    }
}
