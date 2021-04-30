using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check
{
    class Score
    {
        MY_DB db = new MY_DB();
        public bool insertScore(int student_id,int course_id, float score,string des)
        {
            
            db.OpenConnection();
            SqlCommand cmd = new SqlCommand("insert into Score (student_id,course_id,student_score,description) values (@sid,@cid,@sc,@des)", db.getConnection);
            cmd.Parameters.Add("@sid", System.Data.SqlDbType.Int).Value = student_id;
            cmd.Parameters.Add("@cid", System.Data.SqlDbType.Int).Value = course_id;
            cmd.Parameters.Add("@sc", System.Data.SqlDbType.Float).Value = score;
            cmd.Parameters.Add("@des", System.Data.SqlDbType.Text).Value = des;
            if (cmd.ExecuteNonQuery() == 1)
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
        public bool is_existScore(int std_id, int cour_id)
        {
            SqlCommand cmd = new SqlCommand("select * from Score where student_id = @StdId and course_id =@cId", db.getConnection);

            

            cmd.Parameters.Add("@cId", SqlDbType.Int).Value = cour_id;
            cmd.Parameters.Add("@StdId", SqlDbType.Int).Value = std_id;

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
        public DataTable getScoreById(int s_id,int C_id)
        {
            DataTable dt = new DataTable();
            if (is_existScore(s_id, C_id))
            {
                SqlCommand cmd = new SqlCommand("select * from Score where student_id = @StdId and course_id =@cId", db.getConnection);
                cmd.Parameters.Add("@cId", SqlDbType.Int).Value = C_id;
                cmd.Parameters.Add("@StdId", SqlDbType.Int).Value = s_id;
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                
                adt.Fill(dt);
                return dt;
            }
            else
            {
                return dt;
            }
        }
        public DataTable getAvgScoreByCourse()
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = db.getConnection;
            cmd.CommandText = "select Course.label, AVG(Score.student_score) as AverageGrade from Course ,Score where Course.id =Score.course_id Group by Course.label";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public bool deleteScoreById(int sId,int cId)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Score WHERE student_id =@sid and course_id =@cid", db.getConnection);
            cmd.Parameters.Add("@sid", SqlDbType.Int).Value = sId;
            cmd.Parameters.Add("@cId", SqlDbType.Int).Value = cId;
            db.OpenConnection();

            if (cmd.ExecuteNonQuery() == 1)
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
