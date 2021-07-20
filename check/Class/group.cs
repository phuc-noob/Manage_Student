using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check
{
    class group
    {
        MY_DB db = new MY_DB();
        public bool insertGroup(int id,string name,int uid)
        {
            SqlCommand command = new SqlCommand("INSERT INTO mygroup (id,name,uid)"
                + "VALUES (@id,@name,@uid)", db.getConnection);

            command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", System.Data.SqlDbType.VarChar).Value = name;
            command.Parameters.Add("@uid", System.Data.SqlDbType.Int).Value = uid;


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
        public DataTable getGroupbyGid(int id)
        {
            db.OpenConnection();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from mygroup where uid =@id and id =@gid", db.getConnection);
            cmd.Parameters.Add("id", SqlDbType.Int).Value = Global.GlobalUserId;
            cmd.Parameters.Add("gid", SqlDbType.Int).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
            db.closeConnection();
        }
        public DataTable getAllGroup()
        {
            db.OpenConnection();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from mygroup where uid =@id", db.getConnection);
            cmd.Parameters.Add("id", SqlDbType.Int).Value = Global.GlobalUserId;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
            db.closeConnection();
        }
        public bool updateGroup(int id, string name)
        {
            db.OpenConnection();
            SqlCommand command = new SqlCommand("UPDATE mygroup SET name =@name WHERE id =@id", db.getConnection);
            command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", System.Data.SqlDbType.VarChar).Value = name;

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
        public bool removeGroup(int id)
        {
            SqlCommand cmd = new SqlCommand("delete from mygroup where id =@id", db.getConnection);
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
        public DataTable getGroupByIdUser(int uId)
        {
            db.OpenConnection();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from mygroup where uid =@id", db.getConnection);
            cmd.Parameters.Add("id", SqlDbType.Int).Value = uId;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
            db.closeConnection();
        }
    }
}
