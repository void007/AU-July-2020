using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace ADONET
{
public class Database
    {
        string connectionString;
        string connectionString;
        SqlDataAdapter adapter;
        DataSet dataSet;


        public Database()
        {
            //change it according to the connection property
            connectionString = ConfigurationManager.ConnectionStrings[""].ConnectionString.ToString();
            connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();
            dataSet = new DataSet();
        }

        public void InsertDept()
        {
            string input_deptid, input_deptname;
            Console.WriteLine("\nEnter Department id ");
            input_deptid = Console.ReadLine();
            Console.WriteLine("\nEnter Department Name: ");
            input_deptname = Console.ReadLine();
            string sqlQuery = "executing " + "'" + input_deptid + "'" + "," + "'" + input_deptname + "'" + ";";
            int rowAffected = 0;
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            rowAffected = command.ExecuteNonQuery();

            if (rowAffected != 0)
            {
                Console.WriteLine("\nData Inserted\n");
            }
            else
            {
                Console.WriteLine("Data insertion Failed\n");
            }
        }
        //
        public void DeleteEmp()
        {
            string input_empid;
            Console.WriteLine("\nEnter Employee ID ");
            input_empid = Console.ReadLine();

            string sqlQuery = "execute delete_from_employee " + "'" + input_empid + "'" + ";";
            int rowAffected = 0;
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            rowAffected = command.ExecuteNonQuery();

            if (rowAffected != 0)
            {
                Console.WriteLine("Data Deleted Successfully\n");
            }
            else
            {
                Console.WriteLine("Data Deletion Failed\n");
            }

        }
        //
        public void DisplayEmp()
        {
            adapter = new SqlDataAdapter("Select * from Employee", connection);
            dataSet = new DataSet();
            adapter.Fill(dataSet);
            if (dataSet != null)
            {
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {

                    Console.WriteLine("Employee ID: " + dataSet.Tables[0].Rows[i]["EmpID"] + " Employee Name:" + dataSet.Tables[0].Rows[i]["EmpName"] + "Department ID: " + dataSet.Tables[0].Rows[i]["DeptID"]);
                }
            }
        }
        //
        public void DisplayDept()
        {
            adapter = new SqlDataAdapter("Select * from Department", connection);
            dataSet = new DataSet();
            adapter.Fill(dataSet);
            if (dataSet != null)
            {
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {

                    Console.WriteLine("Department ID: " + dataSet.Tables[0].Rows[i]["DeptID"] + " Department Name:" + dataSet.Tables[0].Rows[i]["DeptName"]);
                }
            }
        }

    }
}
