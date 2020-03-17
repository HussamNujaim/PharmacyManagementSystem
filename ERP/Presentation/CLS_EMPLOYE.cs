using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ERP.Presentation
{
    class CLS_EMPLOYE
    {
        public void ADD_EMPLOYE(string EmpName, string EmpAddress, string EmpPhone
                               , decimal EmpSalary, DateTime EmpDate, string EmpJob)
        {
            try
            {
                DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
                DataLayer.open();
                SqlParameter[] para = new SqlParameter[6];
                para[0] = new SqlParameter("@EmpName", SqlDbType.NVarChar, 50);
                para[0].Value = EmpName;
                para[1] = new SqlParameter("@EmpAddress", SqlDbType.NVarChar, 50);
                para[1].Value = EmpAddress;
                para[2] = new SqlParameter("@EmpPhone", SqlDbType.NVarChar, 50);
                para[2].Value = EmpPhone;
                para[3] = new SqlParameter("@EmpSalary", SqlDbType.Money);
                para[3].Value = EmpSalary;
                para[4] = new SqlParameter("@EmpDate", SqlDbType.Date);
                para[4].Value = EmpDate;
                para[5] = new SqlParameter("@EmpJob", SqlDbType.NVarChar, 50);
                para[5].Value = EmpJob;
                DataLayer.ExecuteCommand("ADD_EMPLOYE", para);
                DataLayer.close();
            }
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); }
        }

        public void Edit_Emploey(int EmpID, string EmpName, string EmpAddress,
                                 string EmpPhone,decimal EmpSalary,string EmpJob)
        {
            try
            {
                DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
                DataLayer.open();
                SqlParameter[] para = new SqlParameter[6];
                para[0] = new SqlParameter("@EmpID", SqlDbType.Int);
                para[0].Value = EmpID;
                para[1] = new SqlParameter("@EmpName", SqlDbType.NVarChar, 50);
                para[1].Value = EmpName;
                para[2] = new SqlParameter("@EmpAddress", SqlDbType.NVarChar, 50);
                para[2].Value = EmpAddress;
                para[3] = new SqlParameter("@EmpPhone", SqlDbType.NVarChar, 50);
                para[3].Value = EmpPhone;
                para[4] = new SqlParameter("@EmpSalary", SqlDbType.Money);
                para[4].Value = EmpSalary;
                para[5] = new SqlParameter("@EmpJob", SqlDbType.NVarChar, 50);
                para[5].Value = EmpJob;
                DataLayer.ExecuteCommand("Edit_Emploey", para);
                DataLayer.close();
            }
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); }
        }

        public void DEL_Employe(int ID)
        {
            try
            {
                DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
                DataLayer.open();
                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@ID", SqlDbType.Int);
                para[0].Value = ID;
                DataLayer.ExecuteCommand("DEL_Employe", para);
                DataLayer.close();
            }
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); }
        }

        public DataTable Get_All_Employe()
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            DataTable dt = new DataTable();
            dt = DataLayer.SelectData("Get_All_Employe", null);
            return dt;
        }

        public DataTable Search_Employe(string Criterion)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            DataTable dt=new DataTable();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Criterion", SqlDbType.VarChar, 50);
            para[0].Value = Criterion;
            dt = DataLayer.SelectData("Search_Employe", para);
            return dt;
        }

        public void Add_EmpMadin(int EmpID, string Details, decimal Dain
                              , decimal Madin, DateTime Date,string UserName)
        {
            try
            {
                DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
                DataLayer.open();
                SqlParameter[] para = new SqlParameter[6];
                para[0] = new SqlParameter("@EmpID", SqlDbType.Int);
                para[0].Value = EmpID;
                para[1] = new SqlParameter("@Details", SqlDbType.NVarChar, 50);
                para[1].Value = Details;
                para[2] = new SqlParameter("@Dain", SqlDbType.NVarChar, 50);
                para[2].Value = Dain;
                para[3] = new SqlParameter("@Madin", SqlDbType.Money);
                para[3].Value = Madin;
                para[4] = new SqlParameter("@Date", SqlDbType.Date);
                para[4].Value = Date;
                para[5] = new SqlParameter("@UserName", SqlDbType.NVarChar, 50);
                para[5].Value = UserName;
                DataLayer.ExecuteCommand("Add_EmpMadin", para);
                DataLayer.close();
            }
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); }
        }

        public void Add_EmpDain(int EmpID, string Details, decimal Dain
                            , decimal Madin, DateTime Date)
        {
            try
            {
                DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
                DataLayer.open();
                SqlParameter[] para = new SqlParameter[5];
                para[0] = new SqlParameter("@EmpID", SqlDbType.Int);
                para[0].Value = EmpID;
                para[1] = new SqlParameter("@Details", SqlDbType.NVarChar, 50);
                para[1].Value = Details;
                para[2] = new SqlParameter("@Dain", SqlDbType.NVarChar, 50);
                para[2].Value = Dain;
                para[3] = new SqlParameter("@Madin", SqlDbType.Money);
                para[3].Value = Madin;
                para[4] = new SqlParameter("@Date", SqlDbType.Date);
                para[4].Value = Date;
                DataLayer.ExecuteCommand("Add_EmployeReport", para);
                DataLayer.close();
            }
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); }
        }
    }
}
