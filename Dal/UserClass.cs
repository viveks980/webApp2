using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;


namespace WebApplication2.Dal
{
    public class UserClass : UserInterface
    {
        private readonly string connection = Startup.StaticConfiguration["customData:Connectionstring"];
        // string Connection = "Data Source=DESKTOP-DNP394E\\SQLEXPRESS;Initial Catalog=coreDemo;Integrated Security=true;Encrypt=True;TrustServerCertificate=True;";
        public ResponseModel adduser(user objmodel)
        {

             ResponseModel result = new ResponseModel();
             user User = new user();
            using (SqlConnection con = new SqlConnection(connection))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("saveproject", con))

                    {
                       
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@projectName", objmodel.projectName);
                        cmd.Parameters.AddWithValue("@fromDate", objmodel.fromDate);
                        cmd.Parameters.AddWithValue("@toDate", objmodel.toDate);
                        cmd.Parameters.AddWithValue("@leaderName", objmodel.leaderName);
                        cmd.Parameters.AddWithValue("@projectStatus", objmodel.projectStatus);
                        cmd.Parameters.AddWithValue("@projectClient", objmodel.projectClient);

                        var id = cmd.ExecuteNonQuery();





                        if (id > 0)
                        {
                            result.status = true;
                            result.Message = "Data Saved Successfully";
              


                        }
                        else
                        {
                            result.status = false;
                            result.Message = "Please Check...Something Went wrong...!!!";

                        }
                    }

                }

                catch (Exception ex)
                {
                    result.status = false;
                    Helper.WriteLog("The error is:" + ex);
                    Console.WriteLine("Error is:" + ex);


                }
                finally
                {
                    con.Close();
                    con.Dispose();

                }
            }
            return result;
        }

        public List<user> getprojectdetails()

        {

            List<user> res = new List<user>();

            using (SqlConnection con = new SqlConnection(connection))

            {

                con.Open();

                try

                {

                    using (SqlCommand cmd = new SqlCommand("GetProjects", con))

                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)

                        {

                            while (reader.Read())

                            {
                                

                                user u = new user();
                                u.id = (int)reader["id"];

                                u.projectName = (string)reader["projectName"];

                                u.fromDate = (string)reader["fromDate"];

                                u.toDate = (string)reader["toDate"];

                                u.leaderName = (string)reader["leaderName"];

                                u.projectStatus = (string)reader["projectStatus"];
                                u.projectClient= (string)reader["projectClient"];

                                res.Add(u);



                            }

                        }

                    }

                }

                catch (Exception ex)

                {

                    Console.WriteLine(ex);
                    Helper.WriteLog("The error is:" + ex);

                }

                finally

                {

                    con.Close();

                    con.Dispose();

                }

                return res;

            }



        }
    }
}

