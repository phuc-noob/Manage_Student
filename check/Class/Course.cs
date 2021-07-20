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

        
        public bool insertCourse(int id, string name ,int period, string des,int sem,int teacher_id,string teacher_name)
        {
            SqlCommand cmd = new SqlCommand("insert into course (id,label,period,description,semester,teacher_id,teacher_name) values (@id,@name,@period,@des,@sem,@tid,@tname)",db.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@tname", SqlDbType.NVarChar).Value = teacher_name;
            cmd.Parameters.Add("@tid", SqlDbType.Int).Value = teacher_id;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@period", SqlDbType.Int).Value = period;
            cmd.Parameters.Add("@des", SqlDbType.Text).Value =des ;
            cmd.Parameters.Add(@"sem",SqlDbType.Int).Value =sem;
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
        public bool insertStuCourse(int stu_id,int cour_id)
        {
            if (!isExistStuCourse(stu_id, cour_id))
            {
                SqlCommand cmd = new SqlCommand("insert into stuCourse (student_id,course_id) values (@sid,@cid)", db.getConnection);
                cmd.Parameters.Add("@sid", SqlDbType.Int).Value = stu_id;
                cmd.Parameters.Add("@cid", SqlDbType.Int).Value = cour_id;
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
            else
            {
                return false;
            }
            
        }
        public bool isExistStuCourse(int sid ,int courseId)
        {
            SqlCommand cmd = new SqlCommand("select * from stuCourse where student_id =@sid and course_id = @cId", db.getConnection);

            cmd.Parameters.Add("@sid", SqlDbType.Int).Value = sid;
            cmd.Parameters.Add("@cId", SqlDbType.Int).Value = courseId;

            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable getStuCourseBySId(int id)
        {
            db.OpenConnection();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select label from stuCourse, Course where student_id =@id and course_id =id", db.getConnection);
            cmd.Parameters.Add("id", SqlDbType.Int).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
            db.closeConnection();
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
        public bool updateCourse(int id,string name,int hour,string des,int sem,int tid,string tname)
        {
            SqlCommand cmd = new SqlCommand("update Course set id =@id,teacher_id=@tid,teacher_name =@tname,label =@label,period =@period, description =@description ,semester =@sem where id =@id", db.getConnection);
            db.OpenConnection();
            //SqlCommand cmd = new SqlCommand("UPDATE Std SET fname=@fn,lname =@ln,bdate =@bd,gender=@gd,phone=@phone,address=@address,picture=@pic WHERE id =@id", db.getConnection);
            cmd.Parameters.Add("@tname", SqlDbType.NVarChar).Value = tname;
            cmd.Parameters.Add("@tid",SqlDbType.Int).Value =tid;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@label", SqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("@period", SqlDbType.Int).Value = hour;
            cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = des;
            cmd.Parameters.Add("@sem", SqlDbType.Int).Value = sem;
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

        public DataTable getCourseBySem(int sem)
        {
            SqlCommand cmd = new SqlCommand("select * from Course where semester =@sem", db.getConnection);
            cmd.Parameters.Add("@sem", SqlDbType.Int).Value = sem;
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            db.OpenConnection();
            adapter.Fill(dt);
            return dt;
        }

        
    }
}
