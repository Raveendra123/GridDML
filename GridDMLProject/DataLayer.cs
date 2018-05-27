using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace GridDMLProject
{
  
    public class DataLayer
    {
        SqlConnection con = new SqlConnection("Server=tcp:cloudsqlsrvr.database.windows.net,1433;Initial Catalog=Details;Persist Security Info=False;User ID=raveendra;Password=June@2018;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
       public DataSet Getdata()
        {
            

            SqlCommand cmd = new SqlCommand("Select * from Employee_Details", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds);
            return ds;
            con.Close();

        }

        public int Update(int value1,String value2,String value3)
        {
            int n;
            con.Open();
           
            SqlCommand cmd = new SqlCommand("update Employee_Details set City='" + value2 + "',Designation='" + value3 + "' where UserId=" + value1, con);

          return  n=cmd.ExecuteNonQuery();
            con.Close();
        }

        public int Delete(int value1)
        {
            con.Open();
            int n;

            SqlCommand cmd = new SqlCommand("delete from Employee_Details where Userid=" + value1,con);
            return n= cmd.ExecuteNonQuery();
            con.Close();
        }

        public int Insert(string  value1,string value2,string value3)
        {
            con.Open();
            int n;

            SqlCommand cmd = new SqlCommand("insert into Employee_Details (UserName,city,Designation) values ('" + value1 + "','" + value2 + "','" + value3 + "')",con);
            return n = cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}