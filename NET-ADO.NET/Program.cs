using System;

namespace ADONET
{
    class Program
    {
        static void Main(string[] args)
        {
            Database db = new Database();

            db.InsertDept();

            db.DisplayDept();

            db.DeleteEmp();

            db.DisplayEmp();
            db.DisplayDept();


        }
    }
}
