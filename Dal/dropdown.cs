using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Interface;
using WebApplication2.Models;

namespace WebApplication2.Dal
{
    public class dropdown : dropdownInterface
    {

        
   

            private readonly string connection = Startup.StaticConfiguration["customData:Connectionstring"];

            public List<clientList> GetClientList()

            {

                List<clientList> remarks = new List<clientList>();

                ResponseModel res = new ResponseModel();

                using (SqlConnection con = new SqlConnection(connection))

                {

                    con.Open();

                    try

                    {

                        using (SqlCommand cmd = new SqlCommand("select id,projectClient from client_table", con))

                        {

                            cmd.CommandType = CommandType.Text;

                            SqlDataReader reader = cmd.ExecuteReader();

                            if (reader.HasRows)

                            {

                                while (reader.Read())

                                {

                                    clientList u = new clientList();
                                u.id = string.IsNullOrEmpty(reader["id"].ToString()) ? 0 : Convert.ToInt32(reader["id"]);

                                u.projectClient = string.IsNullOrWhiteSpace(reader["projectClient"].ToString()) ? "" : reader["projectClient"].ToString();

                                    

                                    remarks.Add(u);

                                }

                            }

                        }

                    }

                    catch (Exception ex)

                    {

                        res.status = false;

                        res.Message = "Errorr!!!";

                        Helper.WriteLog("The error is:" + ex);

                    }

                    finally

                    {

                        con.Close();

                        con.Dispose();

                    }

                    return remarks;

                }

            }
        public ResponseModel deleteProject(int id)

        {
            ResponseModel result = new ResponseModel();

            using (SqlConnection con = new SqlConnection(connection))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("deleteProject", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", id);

                        var Id = cmd.ExecuteNonQuery();

                        if (Id > 0)
                        {
                            result.status = true;
                            result.Message = "Data Deleted Successfully..!!";
                            result.Id = Id;


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
                    result.Message = "Exception Occure..!!";

                }
                finally
                {
                    con.Close();
                    con.Dispose();

                }
            }
            return result;

        }

        
        public user editProject(int id)

        {

            ResponseModel res = new ResponseModel();

            user User = new user();

            using (SqlConnection con = new SqlConnection(connection))

            {

                con.Open();

                try

                {

                    using (SqlCommand cmd = new SqlCommand("getProjectById", con))

                    {

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@id", id);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)

                        {

                            while (reader.Read())

                            {

                                User.id = string.IsNullOrEmpty(reader["id"].ToString()) ? 0 : Convert.ToInt32(reader["id"]);

                               
                                User.projectName = string.IsNullOrWhiteSpace(reader["projectName"].ToString()) ? "" : reader["projectName"].ToString();

                                User.fromDate = string.IsNullOrWhiteSpace(reader["fromDate"].ToString()) ? "" : reader["fromDate"].ToString();

                                User.toDate = string.IsNullOrWhiteSpace(reader["toDate"].ToString()) ? "" : reader["toDate"].ToString();

                                User.leaderName = string.IsNullOrWhiteSpace(reader["leaderName"].ToString()) ? "" : reader["leaderName"].ToString();

                                User.projectStatus = string.IsNullOrWhiteSpace(reader["projectStatus"].ToString()) ? "" : reader["projectStatus"].ToString();

                                User.projectClient = string.IsNullOrWhiteSpace(reader["projectClient"].ToString()) ? "" : reader["projectClient"].ToString();




                            }

                        }

                    }

                }

                catch (Exception ex)

                {

                    res.status = false;

                    res.Message = "Errorr!!!";

                }

                finally

                {

                    con.Close();

                    con.Dispose();

                }


            }

            return User;

        }

        public ResponseModel updateuser(user objmodel)
        {

            ResponseModel result = new ResponseModel();
            user User = new user();
            using (SqlConnection con = new SqlConnection(connection))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("updateproject", con))

                    {
                        cmd.Parameters.AddWithValue("@id", objmodel.id);
                        cmd.CommandType = CommandType.StoredProcedure;
                        
                        cmd.Parameters.AddWithValue("@projectName", objmodel.projectName);
                        cmd.Parameters.AddWithValue("@fromDate", objmodel.fromDate);
                        cmd.Parameters.AddWithValue("@toDate", objmodel.toDate);
                        cmd.Parameters.AddWithValue("@leaderName", objmodel.leaderName);
                        cmd.Parameters.AddWithValue("@projectStatus", objmodel.projectStatus);
                        cmd.Parameters.AddWithValue("@projectClient", objmodel.projectClient);

                        var Id = cmd.ExecuteNonQuery();





                        if (Id > 0)
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

    }


    }

