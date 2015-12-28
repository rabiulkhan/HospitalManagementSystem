using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;



namespace Dataacress
{
    public class sqldoctor
    {
        //for inserting doctor info
        public bool InsertDoctor(string _did,
                                       string _dname,
                                       string _dsex,
                                       string _daddress,
                                       string _demail,                           
                                       string _dphone,
                                       string _ddpt,
                                       string _dqualification)
        {
            //Open a connection
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DbConn"].ToString();
                SqlConnection objconnection = new SqlConnection(connectionString);
                objconnection.Open();
                //Fire Command "insert"
                string strInsertCommand = "insert into DoctorTable values('"
                                            + _did + "','"    // this single and double quotations 
                                            + _dname + "','"    // are only used for string values
                                            + _dsex + "','"    // are only used for string values
                                            + _daddress + "','"
                                            + _demail + "','"    // are only used for string values
                                            + _dphone + "','"    // are only used for string values
                                            + _ddpt + "','"
                                            + _dqualification + "')";
                SqlCommand objcommand = new SqlCommand(strInsertCommand, objconnection);
                objcommand.ExecuteNonQuery();
                //getDoctor();
                objconnection.Close();
                return true;
            }
           // catch (Exception ex)
            //{
              //  return false;
            //}
            catch (Exception)
            {
                return false;                // do something
            }
        }



        public DataSet getDoctor()
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["DbConn"].ToString();
            SqlConnection objconnection = new SqlConnection(ConnectionString);
            objconnection.Open();

            SqlCommand objcommand = new SqlCommand("Select * from DoctorTable", objconnection);
            DataSet objDataset = new DataSet();
            SqlDataAdapter objAdapter = new SqlDataAdapter(objcommand);

            objAdapter.Fill(objDataset);

            objconnection.Close();
            return objDataset;
        }


    }
}
