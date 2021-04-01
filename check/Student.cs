using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check
{
    class Student
    {
        public MY_DB db = new MY_DB();
        public int total { get; set; }
        public int totalMale { get; set; }
        public int totalFmale { get; set; }

        // get total student
        
        public int getTotalStd()
        {
            db.OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Std", db.getConnection);
            this.total = (int)cmd.ExecuteScalar();
            return total;
        }

        public int getTotalMale()
        {
            db.OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(id) FROM Std WHERE gender = 'Male'", db.getConnection);
            this.totalMale = (int)cmd.ExecuteScalar();
            return totalMale;
        }

        public int getTotalFemale()
        {
            db.OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Std WHERE gender = 'Female'", db.getConnection);
            this.totalFmale = (int)cmd.ExecuteScalar();
            return totalFmale;
        }

        // function to insert new student 
        public bool insertStudent(int id,string fName, string lName, DateTime BirthDate, string Gender, string phone, string Address, MemoryStream image )
        {
            SqlCommand command = new SqlCommand("INSERT INTO Std (id,fname,lname,bdate,gender,phone,address,picture)" 
                + "VALUES (@id,@fn,@ln,@bdate,@gender,@phone,@address,@picture)",db.getConnection);
            command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
            command.Parameters.Add("@fn", System.Data.SqlDbType.VarChar).Value = fName;
            command.Parameters.Add("@ln", System.Data.SqlDbType.VarChar).Value = lName;
            command.Parameters.Add("@bdate", System.Data.SqlDbType.DateTime).Value = BirthDate;
            command.Parameters.Add("@gender", System.Data.SqlDbType.VarChar).Value = Gender;
            command.Parameters.Add("@phone", System.Data.SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@address", System.Data.SqlDbType.VarChar).Value = Address;
            command.Parameters.Add("@picture", System.Data.SqlDbType.Image).Value = image.ToArray();

            db.OpenConnection();
            if(command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }

        public DataTable getStudent(SqlCommand cmd)
        {
            cmd.Connection = db.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool deleteStudent(int id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Std WHERE id =@id", db.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            db.OpenConnection();
            
            if(cmd.ExecuteNonQuery()==1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
    }
}
