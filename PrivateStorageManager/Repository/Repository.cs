using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateStorageManager.Repository
{
    public class Users
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int IsActive { get; set; }
    }
    public class Repository
    {
        System.Data.IDbConnection _db = null;
        dynamic _simpleDataDb = null;

        public Repository()
        {
            string dbPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string connectionString = $@"data source=C:\Bernard\PrivateStorageManager\PrivateStorageManager\Database\PrivateStorageManager.sqlite;Version=3;";
            this._simpleDataDb = Simple.Data.Database.OpenConnection(connectionString);

            this._simpleDataDb.Users.Insert(Username: "admin", Password: "123", IsActive: "1");

            dynamic clients = (List<Users>)this._simpleDataDb.Users.All();
            foreach (dynamic d in clients)
            {
                string str = d.Username;
            }

            Simple.Data.Sqlite.SqliteConnectionStringConnectionProvider con = new Simple.Data.Sqlite.SqliteConnectionStringConnectionProvider();
            con.SetConnectionString(connectionString);
            this._db = con.CreateConnection();
            this._db.Open();

        }

        public void Insert()
        {
            System.Data.IDbCommand cmd = this._db.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "Insert Into Users(Username,Password,IsActive) Values('admin','123',1)";
            int rowAffected = cmd.ExecuteNonQuery();
        }

        public void Select()
        {
            System.Data.IDbCommand cmd = this._db.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "Select * From Users";
            System.Data.IDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dynamic[] strings = new dynamic[4];
                dr.GetValues(strings);
            }
        }
    }
}
