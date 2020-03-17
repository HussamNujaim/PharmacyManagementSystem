using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace ERP.DataLayer
{
    class DataLayer
    {
        SqlConnection con=new SqlConnection();
        SqlTransaction transaction;
        // Constructor 
        public DataLayer()
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["ERP.Properties.Settings.ERP"].ConnectionString;
        }
        public DataLayer(SqlTransaction transaction,SqlConnection con)
        {
            this.transaction = transaction;
            this.con = con;
        }
        // open connection
        public void open()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
        }
        //close connection 
        public void close()
        {
            if (con.State != ConnectionState.Closed)
            {
                con.Close();
            }
        }
        //read data from database 
        public DataTable SelectData(string stored_procedure, SqlParameter[] para)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = stored_procedure;
            cmd.Connection = con;
            if (para != null)
            {
                for (int i = 0; i < para.Length; i++)
                {
                    cmd.Parameters.Add(para[i]);
                }
            }
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            return dt;
        }

        public SqlDataReader SelectDataR(string stored_procedure, SqlParameter[] para)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = stored_procedure;
            cmd.Connection = con;
            if (para != null)
            {
                for (int i = 0; i < para.Length; i++)
                {
                    cmd.Parameters.Add(para[i]);
                }
            }
            SqlDataReader dr;
           // this.close();
            this.open();
            dr = cmd.ExecuteReader();
           // this.close();
            return dr;
        }
        // no stored procedure
        public string SelectDataS_offline(string stored_procedure, SqlParameter[] para)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = stored_procedure;
            cmd.Connection = con;
            cmd.Transaction = transaction;
            if (para != null)
            {
                for (int i = 0; i < para.Length; i++)
                {
                    cmd.Parameters.Add(para[i]);
                }
            }
            string s;
            s = cmd.ExecuteScalar().ToString();
            return s;
        }
        public DataTable SelectData_offline(string stored_procedure, SqlParameter[] para)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = stored_procedure;
            cmd.Connection = con; 
            cmd.Transaction = transaction;
            if (para != null)
            {
                for (int i = 0; i < para.Length; i++)
                {
                    cmd.Parameters.Add(para[i]);
                }
            }
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            return dt;
        }

        public string SelectDataS(string stored_procedure, SqlParameter[] para)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = stored_procedure;
            cmd.Connection = con;
            if (para != null)
            {
                for (int i = 0; i < para.Length; i++)
                {
                    cmd.Parameters.Add(para[i]);
                }
            }
            string dr;
            this.open();
            dr = cmd.ExecuteScalar().ToString();
            this.close();
            return dr;
        }
        //insert,update and delete data from database 
        public void ExecuteCommand(string stored_procedure, SqlParameter[] para)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = stored_procedure;
            cmd.Connection = con;
            if (para != null)
            {
                cmd.Parameters.AddRange(para);
            }
            cmd.ExecuteNonQuery();
        }
        // no stored procedure
        public void ExecuteCommand_offline(string stored_procedure, SqlParameter[] para)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = stored_procedure;
            cmd.Connection = con;
            cmd.Transaction = transaction;
            if (para != null)
            {
                cmd.Parameters.AddRange(para);
            }
            cmd.ExecuteNonQuery();
        }
        public string Split(string txt)
        {
            return Math.Round(decimal.Parse(txt), 2,MidpointRounding.ToEven).ToString();
          //  Math.Round(txt,2,MidpointRounding.AwayFromZero
            /*
            string newTxt="";
            for (int i = 0; i < txt.Length; i++)
            {
                if (txt[i] == '.')
                {
                    if (txt[i+1] == '0')
                        return newTxt;
                    else
                    {
                        newTxt = newTxt + ".";
                        newTxt = newTxt + txt[i+1];
                        return newTxt;
                    }
                }
                else
                    newTxt = newTxt + txt[i];
            }
            return newTxt; //null
             * */
        }

        public string GetQty(int qty,DataTable dt_UnitQty)
        {
            int[] u = new int[dt_UnitQty.Rows.Count];
            int[] u2 = new int[dt_UnitQty.Rows.Count];
            //  MessageBox.Show(dt.Rows[dt.Rows.Count-1][0].ToString());
            u[0] = qty / int.Parse(dt_UnitQty.Rows[0][0].ToString());
            u2[0] = qty % int.Parse(dt_UnitQty.Rows[0][0].ToString());
            for (int j = 1; j < dt_UnitQty.Rows.Count; j++)
            {
                u[j] = u2[j - 1] / int.Parse(dt_UnitQty.Rows[j][0].ToString());
                u2[j] = u2[j - 1] % int.Parse(dt_UnitQty.Rows[j][0].ToString());
            }
            string qtyUnit = "";
            for (int j = 0; j < dt_UnitQty.Rows.Count; j++)
            {
                if (u[j] > 0)
                {
                    qtyUnit += u[j] + " " + "|" + dt_UnitQty.Rows[j][1].ToString() + "| ";
                }

            }
            return qtyUnit;
        }

        public DialogResult ShowMessageBox(string msg,string type="Error")
        {
            if (type == "Error")
            {
                return System.Windows.Forms.MessageBox.Show(msg,"سيمبل للأنظمة والإستشارات - 770242776", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error); 
            }
            else if (type == "Warning")
            {
                return System.Windows.Forms.MessageBox.Show(msg, "سيمبل للأنظمة والإستشارات - 770242776", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning); 
            }
            else 
            {
                return System.Windows.Forms.MessageBox.Show(msg, "سيمبل للأنظمة والإستشارات - 770242776", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information); 
            }
        }
       
    }
}
