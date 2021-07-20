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
    class user
    {
        MY_DB db = new MY_DB();
        public bool insertUser(int id, string fname, string lname,string username,string password,MemoryStream pic)
        {
            SqlCommand command = new SqlCommand("insert into HR (id,fname,lname,uname,pwd,pic) values (@id,@fn,@ln,@un,@pw,@pic)", db.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fn", SqlDbType.NChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.NChar).Value = lname;
            command.Parameters.Add("@un", SqlDbType.NChar).Value = username;
            command.Parameters.Add("@pw", SqlDbType.NChar).Value = password;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = pic.ToArray();

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

        public bool isExistUser(string uname, int id = 0)
        {
            SqlCommand cmd = new SqlCommand("select * from HR where uname =@uname and id = @id", db.getConnection);
            cmd.Parameters.Add("@uname", SqlDbType.NChar).Value = uname;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

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
        public DataTable getUserById(int id)
        {
            SqlCommand cmd = new SqlCommand("select * from HR where id =@id", db.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            db.OpenConnection();
            adapter.Fill(dt);
            return dt;
        }

        public bool updateUser(int id, string fname, string lname, string username, string password, MemoryStream pic)
        {
            db.OpenConnection();
            SqlCommand command = new SqlCommand("UPDATE HR SET fname=@fn,lname=@ln,uname=@un,pwd=@pw,pic =@pic WHERE id =@id", db.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fn", SqlDbType.NChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.NChar).Value = lname;
            command.Parameters.Add("@un", SqlDbType.NChar).Value = username;
            command.Parameters.Add("@pw", SqlDbType.NChar).Value = password;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = pic.ToArray();

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
    }
}
