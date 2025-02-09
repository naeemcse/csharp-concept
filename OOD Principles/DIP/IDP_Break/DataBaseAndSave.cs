using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Principles.DIP.IDP_Break
{
    public class DataBaseAndSave
    {
        MySQLDataBase mySQLDataBase = new MySQLDataBase();

        void save(string data)
        {
            mySQLDataBase.SaveData(data);
        }

        // এটা হার্ড কোডেড , এখন চাইলেই অন্য ডাটাবেজ এড করা যাবে না । বাধ্য হয়েই MySQLDataBase ব্যবহার করতে হবে । 




    }

    public class MySQLDataBase
    {
        public void SaveData(string data) {
            Console.WriteLine($"{data} is inserted");
        }
}
