using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ERP.Presentation
{
    class CLS_CUSTOMERS
    {
        public void ADD_CUSTOMER(string CustomerName, string Phone,string ADDRESS
                               ,int CustomerType,decimal Dain,decimal Madin,decimal Palance)
        {
            try
            {
                DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
                DataLayer.open();
                SqlParameter[] para = new SqlParameter[7];
                para[0] = new SqlParameter("@CustomerName", SqlDbType.NVarChar, 100);
                para[0].Value = CustomerName;
                para[1] = new SqlParameter("@CustomerPhone", SqlDbType.NVarChar, 20);
                para[1].Value = Phone;
                para[2] = new SqlParameter("@CustomerAddress", SqlDbType.NVarChar, 100);
                para[2].Value = ADDRESS;
                para[3] = new SqlParameter("@CustomerType", SqlDbType.TinyInt);
                para[3].Value = CustomerType;
                para[4] = new SqlParameter("@Dain", SqlDbType.Money);
                para[4].Value = Dain;
                para[5] = new SqlParameter("@Madin", SqlDbType.Money);
                para[5].Value = Madin;
                para[6] = new SqlParameter("@Palance", SqlDbType.Money);
                para[6].Value = Palance;
                DataLayer.ExecuteCommand("ADD_CUSTOMER", para);
                DataLayer.close();
            }
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); }
        }

        public void UPDATE_CUSTOMER(string CustomerID,string CustomerName, string Phone, string ADDRESS)
        {
            try
            {
                DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
                DataLayer.open();
                SqlParameter[] para = new SqlParameter[4];
                para[0] = new SqlParameter("@CustomerID", SqlDbType.Int);
                para[0].Value = CustomerID;
                para[1] = new SqlParameter("@CustomerName", SqlDbType.NVarChar, 100);
                para[1].Value = CustomerName;
                para[2] = new SqlParameter("@CustomerAddress", SqlDbType.NVarChar, 100);
                para[2].Value = ADDRESS;
                para[3] = new SqlParameter("@CustomerPhone", SqlDbType.NVarChar, 20);
                para[3].Value = Phone;
                DataLayer.ExecuteCommand("Edit_Customer", para);
                DataLayer.close();
            }
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); }
        }

        public void Del_Customer(string ID)
        {
            try
            {
                DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
                DataLayer.open();
                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@ID", SqlDbType.VarChar, 10);
                para[0].Value = ID;
                DataLayer.ExecuteCommand("DEL_CUSTOMER", para);
                DataLayer.close();
            }
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); }
        }

        public DataTable GET_ALL_CUSTOMERS()
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            DataTable dt = new DataTable();
            dt = DataLayer.SelectData("GET_ALL_CUSTOMERS", null);
            return dt;
        }
        public DataTable Search_CustomerT(string Criterion, int CustomerType)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            DataTable dt = new DataTable();
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@Criterion", SqlDbType.VarChar, 50);
            para[0].Value = Criterion;
            para[1] = new SqlParameter("@CustomerType", SqlDbType.TinyInt);
            para[1].Value = CustomerType;
            dt = DataLayer.SelectData("Search_CustomerT", para);
            return dt;
        }

        public SqlDataReader Search_Customer(string Criterion,int CustomerType)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlDataReader dr;
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@Criterion", SqlDbType.VarChar, 50);
            para[0].Value = Criterion;
            para[1] = new SqlParameter("@CustomerType", SqlDbType.TinyInt);
            para[1].Value = CustomerType;
            dr = DataLayer.SelectDataR("Search_Customer", para);
            return dr;
        }

        public SqlDataReader GetCustomerData(int CustomerType)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlDataReader dr;
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@CustomerType", SqlDbType.TinyInt);
            para[0].Value = CustomerType;
            dr = DataLayer.SelectDataR("GetCustomerData", para);
            return dr;
        }

        public string GetMaxCustomerID()
        {
           DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
           string id= DataLayer.SelectDataS("GetMaxCustomerID", null);
           DataLayer.close();
           return id;
        }

        public void ADD_ClientReport(int CustomerID,string Details,double Qty,
                                      decimal Dain ,decimal Madin,DateTime Date)
        {
            try
            {
                DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
                DataLayer.open();
                SqlParameter[] para = new SqlParameter[6];
                para[0] = new SqlParameter("@CustomerID", SqlDbType.Int);
                para[0].Value = CustomerID;
                para[1] = new SqlParameter("@Details", SqlDbType.NVarChar, 200);
                para[1].Value = Details;
                para[2] = new SqlParameter("@Qty", SqlDbType.Real);
                para[2].Value = Qty;
                para[3] = new SqlParameter("@Dain", SqlDbType.Money);
                para[3].Value = Dain;
                para[4] = new SqlParameter("@Madin", SqlDbType.Money);
                para[4].Value = Madin;
                para[5] = new SqlParameter("@Date", SqlDbType.Date);
                para[5].Value = Date; 
                DataLayer.ExecuteCommand("Add_ClientReport", para);
                DataLayer.close();
            }
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); }
        }
        
        public void ADD_ClientReport(int CustomerID,string BillID ,string Details, double Qty,
                                    decimal Dain, decimal Madin, DateTime Date, DataLayer.DataLayer DataLayer)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[7];
                para[0] = new SqlParameter("@CustomerID", SqlDbType.Int);
                para[0].Value = CustomerID;
                para[1] = new SqlParameter("@Details", SqlDbType.NVarChar, 200);
                para[1].Value = Details;
                para[2] = new SqlParameter("@Qty", SqlDbType.Real);
                para[2].Value = Qty;
                para[3] = new SqlParameter("@Dain", SqlDbType.Money);
                para[3].Value = Dain;
                para[4] = new SqlParameter("@Madin", SqlDbType.Money);
                para[4].Value = Madin;
                para[5] = new SqlParameter("@Date", SqlDbType.Date);
                para[5].Value = Date;
                para[6] = new SqlParameter("@BillID", SqlDbType.NVarChar, 12);
                para[6].Value = BillID;
                string sqlCommand = "INSERT INTO [dbo].[CustomersReport] ([CustomerID] ,[Details] ,[Qty] ,[Dain] ,[Madin] ,[Date],[ID]) VALUES(@CustomerID ,@Details ,@Qty ,@Dain,@Madin ,@Date,@BillID)";
                DataLayer.ExecuteCommand_offline(sqlCommand, para);
            }
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); }
        }
        public string Get_CustomerPalance(string CustomerID)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@ID", SqlDbType.Int);
            para[0].Value = CustomerID;
            string data= DataLayer.SelectDataS("Get_CustomerPalance", para);
            DataLayer.close();
            return data;
        }
        public string Get_CustomerDain(string CustomerID)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@ID", SqlDbType.Int);
            para[0].Value = CustomerID;
            string data= DataLayer.SelectDataS("Get_CustomerDain", para);
            DataLayer.close();
            return data;
        }
        public string Get_CustomerMadin(string CustomerID)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@ID", SqlDbType.Int);
            para[0].Value = CustomerID;
            string data= DataLayer.SelectDataS("Get_CustomerMadin", para);
            DataLayer.close();
            return data;
        }

        public void Edit_CustomerPalance(string CustomerID,decimal Dain,decimal Madin,decimal Palance)
        {
            try
            {
                DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
                DataLayer.open();
                SqlParameter[] para = new SqlParameter[4];
                para[0] = new SqlParameter("@ID", SqlDbType.Int);
                para[0].Value = CustomerID;
                para[1] = new SqlParameter("@Dain", SqlDbType.Money);
                para[1].Value = Dain;
                para[2] = new SqlParameter("@Madin", SqlDbType.Money);
                para[2].Value = Madin;
                para[3] = new SqlParameter("@Palance", SqlDbType.Money);
                para[3].Value = Palance;
                DataLayer.ExecuteCommand("Edit_CustomerPalance", para);
                DataLayer.close();
            }
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); }
        }
      
        public string Get_CustomerPalance(string CustomerID,DataLayer.DataLayer DataLayer)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@ID", SqlDbType.Int);
            para[0].Value = CustomerID;
            string sqlCommand = "select Palance from Customers where CustomerId=@ID";
            string data = DataLayer.SelectDataS_offline(sqlCommand, para);
            return data;
        }
        public string Get_CustomerDain(string CustomerID, DataLayer.DataLayer DataLayer)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@ID", SqlDbType.Int);
            para[0].Value = CustomerID;
            string sqlCommand = "select Dain from Customers where CustomerId=@ID";
            string data = DataLayer.SelectDataS_offline(sqlCommand, para);
            return data;
        }
        public string Get_CustomerMadin(string CustomerID, DataLayer.DataLayer DataLayer)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@ID", SqlDbType.Int);
            para[0].Value = CustomerID;
            string sqlCommand = "select Madin from Customers where CustomerId=@ID";
            string data = DataLayer.SelectDataS_offline(sqlCommand, para);
            return data;
        }

        public void Edit_CustomerPalance(string CustomerID, decimal Dain, decimal Madin, decimal Palance, DataLayer.DataLayer DataLayer)
        {

            SqlParameter[] para = new SqlParameter[4];
            para[0] = new SqlParameter("@ID", SqlDbType.Int);
            para[0].Value = CustomerID;
            para[1] = new SqlParameter("@Dain", SqlDbType.Money);
            para[1].Value = Dain;
            para[2] = new SqlParameter("@Madin", SqlDbType.Money);
            para[2].Value = Madin;
            para[3] = new SqlParameter("@Palance", SqlDbType.Money);
            para[3].Value = Palance;
            string sqlCommand = "update Customers set Dain=@Dain , Madin=@Madin, Palance=@Palance where CustomerId=@ID";
            DataLayer.ExecuteCommand_offline(sqlCommand, para);

        }
    }
}
