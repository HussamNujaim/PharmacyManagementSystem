using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ERP.Presentation
{
    class CLS_Login
    {
        public DataTable SelectUsers()
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            DataLayer.open();
            DataTable dt = new DataTable();
            dt = DataLayer.SelectData("SP_USERS", null);
            return dt;
        }

        public SqlDataReader SelectUsersR()
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            DataLayer.open();
            SqlDataReader dr;
            dr = DataLayer.SelectDataR("SP_USERS", null);
            return dr;
        }

        public string Select_Grant(string UserName)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            DataLayer.open();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@UserName", SqlDbType.NVarChar, 50);
            para[0].Value = UserName;
           return DataLayer.SelectDataS("SP_GRANT", para);
        }

        public string Select_Password(string UserName)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            DataLayer.open();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@UserName", SqlDbType.NVarChar, 50);
            para[0].Value = UserName;
            return DataLayer.SelectDataS("Get_UserPassword", para);
        }

        public DataTable Login(string UserName, string Password)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@UserName",SqlDbType.NVarChar,50 );
            para[1] = new SqlParameter("@Password", SqlDbType.NVarChar, 50);
            para[0].Value = UserName;
            para[1].Value = Password;
            DataLayer.open();
            DataTable dt = new DataTable();
            dt = DataLayer.SelectData("SP_LOGIN", para);
            return dt; 
        }

        public SqlDataReader Get_UserDetails(string UserName)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@UserName", SqlDbType.NVarChar, 50);
            para[0].Value = UserName;
            DataLayer.open();
            return DataLayer.SelectDataR("Get_UserDetails", para);
        }

        public void Add_User(string UserName, string Password, string Grant)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@UserName", SqlDbType.NVarChar, 50);
            para[1] = new SqlParameter("@Password", SqlDbType.NVarChar, 50);
            para[2] = new SqlParameter("@Grant", SqlDbType.NVarChar, 50);
            para[0].Value = UserName;
            para[1].Value = Password;
            para[2].Value = Grant;
            DataLayer.open();
            DataLayer.ExecuteCommand("Add_User", para);
            DataLayer.close();
        }

        public void Edit_User(string UserName, string Password, string Grant)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@UserName", SqlDbType.NVarChar, 50);
            para[1] = new SqlParameter("@Password", SqlDbType.NVarChar, 50);
            para[2] = new SqlParameter("@Grant", SqlDbType.NVarChar, 50);
            para[0].Value = UserName;
            para[1].Value = Password;
            para[2].Value = Grant;
            DataLayer.open();
            DataLayer.ExecuteCommand("Edit_Users", para);
            DataLayer.close();
        }

        public void Del_User(string UserName)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@UserName", SqlDbType.NVarChar, 50);
            para[0].Value = UserName;
            DataLayer.open();
            DataLayer.ExecuteCommand("Del_User", para);
            DataLayer.close();
        }
       

    }
}
