using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Principles.DIP
{
    public class DataManager
    {
        IDatabase _database;

        DataManager(IDatabase database)
        {
            _database = database;
        }

        public void Save(string d)
        {
            _database.SaveData(d);
        }
        // এখানে চাইল্ড থেকে যে ধরণের ডাটাবেজের জন্য ইনপুট (টাইপ) দিবো, সেটার জন্যই ,সি ডেটাবেজে ডাটা ইনপুট হবে । 

    }

    public interface IDatabase
    {
        void SaveData(string data) { }
    }

    public class MySQLServer : IDatabase
    {
        void SaveData(string data) { }

    }

    public class SQLLite : IDatabase
    {
        void SaveData(string data) { }

    }


}
