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
    class Contact
    {
        MY_DB db = new MY_DB();
        public bool insertContact(int id, int user_id,string fName, string lName,string phone,int group, string email, string Address, MemoryStream image)
        {
            SqlCommand command;
            if (group == -1)
            {
                 command= new SqlCommand("INSERT INTO contact (id,user_id,fname,lname,email,phone,address,pic)"
                + "VALUES (@id,@u_id,@fn,@ln,@email,@phone,@address,@picture)", db.getConnection);

            }
            else
            {
                command = new SqlCommand("INSERT INTO contact (id,user_id,fname,lname,email,phone,group_id,address,pic)"
                + "VALUES (@id,@u_id,@fn,@ln,@email,@phone,@gr_id,@address,@picture)", db.getConnection);
                command.Parameters.Add("@gr_id", System.Data.SqlDbType.Int).Value = group;
            }
            

            command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
            command.Parameters.Add("@u_id", System.Data.SqlDbType.Int).Value = user_id;
            command.Parameters.Add("@fn", System.Data.SqlDbType.VarChar).Value = fName;
            command.Parameters.Add("@ln", System.Data.SqlDbType.VarChar).Value = lName;
            command.Parameters.Add("@email", System.Data.SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@phone", System.Data.SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@address", System.Data.SqlDbType.VarChar).Value = Address;
            command.Parameters.Add("@picture", System.Data.SqlDbType.Image).Value = image.ToArray();

            db.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
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

        // ------------------------get function --------------------------
        public DataTable getStudentByTid(int id)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select Std.id as Sid,fname,lname,gender,bdate,phone,Course.id as cid,label from Course,Std,stuCourse where teacher_id=@tid and stuCourse.course_id =Course.id and stuCourse.student_id =Std.id", db.getConnection);
            cmd.Parameters.Add("tid", SqlDbType.Int).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            db.OpenConnection();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable getContactByGroupId(int group_id)
        {
            SqlCommand cmd = new SqlCommand("select * from Contact where group_id =@g and user_id =@id", db.getConnection);
            cmd.Parameters.Add("id", SqlDbType.Int).Value = Global.GlobalUserId;
            cmd.Parameters.Add("@g", SqlDbType.Int).Value = group_id;
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            db.OpenConnection();
            adapter.Fill(dt);
            return dt;
        }
        public DataTable getContactById(int id)
        {
            SqlCommand cmd = new SqlCommand("select * from Contact where id =@id", db.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            db.OpenConnection();
            adapter.Fill(dt);
            return dt;
        }
        public bool updateContact(int id, int user_id, string fName, string lName, string phone, int group, string email, string Address, MemoryStream image)
        {
            db.OpenConnection();
            SqlCommand command = new SqlCommand("UPDATE Contact SET fname =@fn,lname =@ln,email =@email,phone=@phone,group_id=@gr_id,address=@address,pic =@picture WHERE id =@id", db.getConnection);
            command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
            command.Parameters.Add("@fn", System.Data.SqlDbType.VarChar).Value = fName;
            command.Parameters.Add("@ln", System.Data.SqlDbType.VarChar).Value = lName;
            command.Parameters.Add("@email", System.Data.SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@phone", System.Data.SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@gr_id", System.Data.SqlDbType.VarChar).Value = group;
            command.Parameters.Add("@address", System.Data.SqlDbType.VarChar).Value = Address;
            command.Parameters.Add("@picture", System.Data.SqlDbType.Image).Value = image.ToArray();

            if (command.ExecuteNonQuery() == 1)
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
        public DataTable getAllGroup()
        {
            db.OpenConnection();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select group_id from Contact where user_id =@id group by group_id", db.getConnection);
            cmd.Parameters.Add("id", SqlDbType.Int).Value = Global.GlobalUserId;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
            db.closeConnection();
        }
        public DataTable getContact()
        {
            db.OpenConnection();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from Contact ", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
            db.closeConnection();
        }
        public DataTable getAllContact()
        {
            db.OpenConnection();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from Contact where user_id =@id", db.getConnection);
            cmd.Parameters.Add("id", SqlDbType.Int).Value = Global.GlobalUserId;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
            db.closeConnection();
        }
        // -----------------------------------------------------------------

        // -------------------remove----------------------------------------
        public bool removeContactById(int id)
        {
            SqlCommand cmd = new SqlCommand("delete from Contact where id =@id", db.getConnection);
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

        public bool removeContactByGid(int gid)
        {
            SqlCommand cmd = new SqlCommand("delete from Contact where group_id =@id", db.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = gid;
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

        //-----------------end of remove------------------------------------------
        
    }
}
