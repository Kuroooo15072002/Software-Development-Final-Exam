using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admission
{
    class Modify
    {
        public Modify()
        {

        }
        SqlDataAdapter dataAdapter;
        SqlCommand sqlCommand;
        public DataTable getAllAdmissionStudent()
        {
            DataTable dataTable = new DataTable();
            string query = "Select * from Table";
            using (SqlConnection sqlConnection= Connection.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }
        public bool Add(AdmissionStudent admissionStudent)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "Insert into AdSInformation values (@AdSID, @AdSFullName, @AdSDateOfBirth, @AdSSex, @AdSAddress, @AdSEmail, @AdSPhone, @AdSExamResult, @AdSChoice)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@AdSID", SqlDbType.VarChar).Value = admissionStudent.ID;
                sqlCommand.Parameters.Add("@AdSFullName", SqlDbType.VarChar).Value = admissionStudent.FullName;
                sqlCommand.Parameters.Add("@AdSDateOfBirth", SqlDbType.VarChar).Value = admissionStudent.DateOfBirth.ToShortDateString();
                sqlCommand.Parameters.Add("@AdSSex", SqlDbType.VarChar).Value = admissionStudent.Sex;
                sqlCommand.Parameters.Add("@AdSAddress", SqlDbType.VarChar).Value = admissionStudent.Address;
                sqlCommand.Parameters.Add("@AdSEmail", SqlDbType.VarChar).Value = admissionStudent.Email;
                sqlCommand.Parameters.Add("@AdSPhone", SqlDbType.VarChar).Value = admissionStudent.Phone;
                sqlCommand.Parameters.Add("@AdSExamResult", SqlDbType.VarChar).Value = admissionStudent.ExamResult;
                sqlCommand.Parameters.Add("@AdSChoice", SqlDbType.VarChar).Value = admissionStudent.Choice;
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
        public bool Update(AdmissionStudent admissionStudent)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "Update from Table set" + "AdSID = @AdSID, AdSFullName = @AdSFullName, AdSDateOfBirth = @AdSDateOfBirth, AdSSex = @AdSSex, AdSAddress = @AdSAddress, AdSEmail = @AdSEmail, @AdSPhone = @AdSPhone, @AdSExamResult = @AdSExamResult,  AdSChoice = @AdSChoice";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@AdSID", SqlDbType.NVarChar).Value = admissionStudent.ID;
                sqlCommand.Parameters.Add("@AdSFullName", SqlDbType.VarChar).Value = admissionStudent.FullName;
                sqlCommand.Parameters.Add("@AdSDateOfBirth", SqlDbType.VarChar).Value = admissionStudent.DateOfBirth.ToShortDateString();
                sqlCommand.Parameters.Add("@AdSSex", SqlDbType.VarChar).Value = admissionStudent.Sex;
                sqlCommand.Parameters.Add("@AdSAddress", SqlDbType.VarChar).Value = admissionStudent.Address;
                sqlCommand.Parameters.Add("@AdSEmail", SqlDbType.VarChar).Value = admissionStudent.Email;
                sqlCommand.Parameters.Add("@AdSPhone", SqlDbType.VarChar).Value = admissionStudent.Phone;
                sqlCommand.Parameters.Add("@AdSExamResult", SqlDbType.VarChar).Value = admissionStudent.ExamResult;
                sqlCommand.Parameters.Add("@AdSChoice", SqlDbType.VarChar).Value = admissionStudent.Choice;
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            { 
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
        public bool Delete(String ID)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "Delete AdSInformation where AdSID + @AdSID";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@AdSID", SqlDbType.NVarChar).Value = ID;
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
    }

}
