using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asaigment.SQL
{
    public class SQLiteDemo
    {
        private void LoadDatabase1()
        {
            // Get a reference to the SQLite database    
            var conn = new SQLiteConnection("sqlitepcldemo.db");
            string sql = @"CREATE TABLE IF NOT EXISTS                          
Customer (Id      INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,                                    
Name    VARCHAR( 140 ),                                    
City    VARCHAR( 140 ),                                    
Contact VARCHAR( 140 )                     
);";
            using (var statement = conn.Prepare(sql))
            {
                statement.Step();
            }

            // SqlConnection was opened in App.xaml.cs and exposed through property conn
            //var db = App.conn;
            //try
            //{
            //    using (
            //        var custstmt = db.Prepare("INSERT INTO Customer (Name, City, Contact) VALUES (?, ?, ?)"))
            //    {
            //        custstmt.Bind(1, customerName);
            //        custstmt.Bind(2, customerCity);
            //        custstmt.Bind(3, customerContact);
            //        custstmt.Step();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    // TODO: Handle error
            //}
        }

        public void LoadDatabase()
        {
            // Get a reference to the SQLite database
            var conn = new SQLiteConnection("sqlitepcldemo.db"); string sql = @"CREATE TABLE IF NOT EXISTS Customer (Id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,Name VARCHAR( 140 ),City VARCHAR( 140 ),Contact VARCHAR( 140 ));"; using (var statement = conn.Prepare(sql)) { statement.Step(); }
            try { using (var custstmt = conn.Prepare("INSERT INTO Customer (Name, City, Contact) VALUES (?, ?, ?)")) { custstmt.Bind(1, "Hung"); custstmt.Bind(2, "hanoi"); custstmt.Bind(3, "alo"); custstmt.Step(); } }
            catch (Exception ex)
            {
                // TODO: Handle error
            }
        }
    }
}
