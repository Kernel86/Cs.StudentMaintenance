using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Novak.StudentMaintenance.Utilities.PL
{
    public class CDataAccess
    {
        SqlConnection conn;

        private ConnectionState Open()
        {
            try
            {
                conn = new SqlConnection(Properties.Settings.Default.DBConn);
                conn.Open();

                return conn.State;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool Close()
        {
            try
            {
                if (conn != null)
                    conn.Close();

                conn = null;
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetData(string sCommand)
        {
            try
            {
                Open();

                SqlDataAdapter oDA = new SqlDataAdapter(sCommand, conn);
                DataTable oDT = new DataTable();
                oDA.Fill(oDT);

                oDA.Dispose();
                oDA = null;

                Close();

                return oDT;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Insert(string sCommand)
        {
            try
            {
                Open();

                SqlCommand oCmd = new SqlCommand(sCommand, conn);
                int iRows = oCmd.ExecuteNonQuery();

                oCmd.Dispose();
                oCmd = null;

                Close();

                return iRows;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Update(string sCommand)
        {
            try
            {
                Open();

                SqlCommand oCmd = new SqlCommand(sCommand, conn);
                int iRows = oCmd.ExecuteNonQuery();

                oCmd.Dispose();
                oCmd = null;

                Close();

                return iRows;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Delete(string sCommand)
        {
            try
            {
                Open();

                SqlCommand oCmd = new SqlCommand(sCommand, conn);
                int iRows = oCmd.ExecuteNonQuery();

                oCmd.Dispose();
                oCmd = null;

                Close();

                return iRows;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
