using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ERP.Presentation
{
    class CLS_Bursary
    {
        public string Get_Sum_AccMadin(string AccId, string EndDate)//, string Begin)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlParameter[] para=new SqlParameter[2];
            para[0] = new SqlParameter("@AccId", SqlDbType.NVarChar, 20);
            para[0].Value = AccId;
            para[1] = new SqlParameter("@EndDate", SqlDbType.VarChar, 50);
            para[1].Value = EndDate;
        /*  para[2] = new SqlParameter("@EndDate", SqlDbType.VarChar, 50);
            para[2].Value = EndDate;*/
           return DataLayer.SelectDataS("Get_Sum_AccMadin", para);
        }
        public string Get_Sum_AccDain(string AccId, string EndDate)//, string Begin)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlParameter[] para=new SqlParameter[2];
            para[0] = new SqlParameter("@AccId", SqlDbType.NVarChar, 20);
            para[0].Value = AccId;
            para[1] = new SqlParameter("@EndDate", SqlDbType.VarChar, 50);
            para[1].Value = EndDate;
           /* para[2] = new SqlParameter("@EndDate", SqlDbType.VarChar, 50);
            para[2].Value = EndDate;*/
            return DataLayer.SelectDataS("Get_Sum_AccDain", para);
        }

        public string Get_Sum_ReceiverMadin(string AccId, string EndDate)//, string Begin)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@AccId", SqlDbType.NVarChar, 20);
            para[0].Value = AccId;
            para[1] = new SqlParameter("@EndDate", SqlDbType.VarChar, 50);
            para[1].Value = EndDate;
            /*  para[2] = new SqlParameter("@EndDate", SqlDbType.VarChar, 50);
                para[2].Value = EndDate;*/
           return DataLayer.SelectDataS("Get_Sum_ReceiverMadin", para);
        }
        public string Get_Sum_ReceiverDain(string AccId, string EndDate)//, string Begin)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@AccId", SqlDbType.NVarChar, 20);
            para[0].Value = AccId;
            para[1] = new SqlParameter("@EndDate", SqlDbType.VarChar, 50);
            para[1].Value = EndDate;
            /* para[2] = new SqlParameter("@EndDate", SqlDbType.VarChar, 50);
             para[2].Value = EndDate;*/
            return DataLayer.SelectDataS("Get_Sum_ReceiverDain", para);
        }

        /// <summary>
        /// ////////
        /// </summary>
        /// <param name="EmpID"></param>
        /// <param name="BeginDate"></param>
        /// <param name="EndDate"></param>
        /// <returns></returns>
        public string Get_Sum_EmployeDain(int EmpID, string BeginDate, string EndDate)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@EmpID", SqlDbType.Int);
            para[0].Value = EmpID;
            para[1] = new SqlParameter("@BeginDate", SqlDbType.VarChar, 50);
            para[1].Value = BeginDate;
            para[2] = new SqlParameter("@EndDate", SqlDbType.VarChar, 50);
            para[2].Value = EndDate;
            string id = DataLayer.SelectDataS("Get_Sum_EmployeDain", para);
            DataLayer.close();
            return id;
        }
        public string Get_Sum_EmployeMadin(int EmpID, string BeginDate, string EndDate)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@EmpID", SqlDbType.Int);
            para[0].Value = EmpID;
            para[1] = new SqlParameter("@BeginDate", SqlDbType.VarChar, 50);
            para[1].Value = BeginDate;
            para[2] = new SqlParameter("@EndDate", SqlDbType.VarChar, 50);
            para[2].Value = EndDate;
            string id = DataLayer.SelectDataS("Get_Sum_EmployeMadin", para);
            DataLayer.close();
            return id;
        }

        public string Get_SumBrushPrice(string BeginDate, string EndDate)
        {
            try
            {
                DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
                SqlParameter[] para = new SqlParameter[2];
                para[0] = new SqlParameter("@BeginDate", SqlDbType.VarChar, 50);
                para[0].Value = BeginDate;
                para[1] = new SqlParameter("@EndDate", SqlDbType.VarChar, 50);
                para[1].Value = EndDate;
                string sum = DataLayer.SelectDataS("Get_SumBrushPrice", para);
                DataLayer.close();
                return sum;
            }
            catch { return "0"; }
        }
        public string Get_SumBillPrice(string BeginDate, string EndDate)
        {
            try
            {
                DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
                SqlParameter[] para = new SqlParameter[2];
                para[0] = new SqlParameter("@BeginDate", SqlDbType.VarChar, 50);
                para[0].Value = BeginDate;
                para[1] = new SqlParameter("@EndDate", SqlDbType.VarChar, 50);
                para[1].Value = EndDate;
                string sum = DataLayer.SelectDataS("Get_SumBillPrice", para);
                DataLayer.close();
                return sum;
            }
            catch { return "0"; }
        }
    }
}
