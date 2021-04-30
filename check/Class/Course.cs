using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check
{
    class Course
    {
        MY_DB db = new MY_DB();
        public bool isExistCourse(string name,int courseId = 0)
        {
            SqlCommand cmd = new SqlCommand("select * from Course where label =@cName and id <> @cId",db.getConnection);

            cmd.Parameters.Add("@cName", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@cId", SqlDbType.Int).Value = courseId;

            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool insertCourse(int id, string name ,int period, string des)
        {
            SqlCommand cmd = new SqlCommand("insert into course (id,label,period,description) values (@id,@name,@period,@des)",db.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@period", SqlDbType.Int).Value = period;
            cmd.Parameters.Add("@des", SqlDbType.Text).Value =des ;

            db.OpenConnection();

            if (cmd.ExecuteNonQuery() == 1)
            {
                return true;
                db.closeConnection();
            }
            else
            {
                return false;
                db.closeConnection();
            }
        }

        public bool removeCourse(int id)
        {
            SqlCommand cmd = new SqlCommand("delete from Course where id =@id",db.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            db.OpenConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                return true;
                db.closeConnection();
            }
            else
            {
                return false;
                db.closeConnection();
            }
        }

        public DataTable getAllCourse()
        {
            db.OpenConnection();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from Course", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
            db.closeConnection();
        }
        public DataTable getCourseById(int id)
        {
            SqlCommand cmd = new SqlCommand("select * from Course where id =@id", db.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            db.OpenConnection();
            adapter.Fill(dt);
            return dt;
        }
        public bool updateCourse(int id,string name,int hour,string des)
        {
            SqlCommand cmd = new SqlCommand("update Course set id =@id,label =@label,period =@period, description =@description where id =@id", db.getConnection);
            db.OpenConnection();
            //SqlCommand cmd = new SqlCommand("UPDATE Std SET fname=@fn,lname =@ln,bdate =@bd,gender=@gd,phone=@phone,address=@address,picture=@pic WHERE id =@id", db.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@label", SqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("@period", SqlDbType.Int).Value = hour;
            cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = des;
            //cmd.Parameters.Add("@gd", SqlDbType.VarChar).Value = Gender;
            //cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            //cmd.Parameters.Add("@Address", SqlDbType.VarChar).Value = Address;
            //cmd.Parameters.Add("@pic", SqlDbType.Image).Value = image.ToArray();

            if (cmd.ExecuteNonQuery() == 1)
            {
                return true;
                db.closeConnection();
            }
            else
            {
                return false;
                db.closeConnection();
            }
        }
        public int getTotalCourse()
        {
            SqlCommand cmd = new SqlCommand("select count(id) from Course", db.getConnection);
            return (int)cmd.ExecuteScalar();
        }
    }
}
