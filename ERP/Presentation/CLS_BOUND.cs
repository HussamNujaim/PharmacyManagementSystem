using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ERP.Presentation
{
    class CLS_BOUND
    {
        public string Get_Max_BoundID()
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            string dt;
            dt = DataLayer.SelectDataS("Get_Max_BoundID", null);
            return dt;
        }

        public string Get_BoundType(string BoundID)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@BoundID", SqlDbType.NVarChar, 10);
            para[0].Value = BoundID; 
            string s;
            s = DataLayer.SelectDataS("Get_BoundType", para);
            return s;
        }

        public void Add_Bound(string BoundID,string BoundType,int BFrom,int BTO,decimal BoundPrice,
                             DateTime Date,string BoundDetails,string UserName)
        {
            try
            {
                DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
                DataLayer.open();
                SqlParameter[] para = new SqlParameter[8];
                para[0] = new SqlParameter("@BoundID", SqlDbType.NVarChar, 20);
                para[0].Value = BoundID;
                para[1] = new SqlParameter("@BoundType", SqlDbType.NVarChar, 50);
                para[1].Value = BoundType;
                para[2] = new SqlParameter("@BFrom", SqlDbType.Int);
                para[2].Value = BFrom;
                para[3] = new SqlParameter("@BTo", SqlDbType.Int);
                para[3].Value = BTO;
                para[4] = new SqlParameter("@BoundPrice", SqlDbType.Money);
                para[4].Value = BoundPrice;
                para[5] = new SqlParameter("@Date", SqlDbType.Date);
                para[5].Value = Date;
                para[6] = new SqlParameter("@BoundDetails", SqlDbType.NVarChar, 200);
                para[6].Value = BoundDetails;
                para[7] = new SqlParameter("@@UserName", SqlDbType.NVarChar, 50);
                para[7].Value = UserName;
                DataLayer.ExecuteCommand("ADD_BOUND", para);
                DataLayer.close();
            }
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); }
        }

        public void Add_Bound(string BoundID, string BoundType, int BFrom, int BTO, decimal BoundPrice,
                             DateTime Date, string BoundDetails, string UserName,DataLayer.DataLayer DataLayer)
        {
                SqlParameter[] para = new SqlParameter[8];
                para[0] = new SqlParameter("@BoundID", SqlDbType.NVarChar, 20);
                para[0].Value = BoundID;
                para[1] = new SqlParameter("@BoundType", SqlDbType.NVarChar, 50);
                para[1].Value = BoundType;
                para[2] = new SqlParameter("@BFrom", SqlDbType.Int);
                para[2].Value = BFrom;
                para[3] = new SqlParameter("@BTo", SqlDbType.Int);
                para[3].Value = BTO;
                para[4] = new SqlParameter("@BoundPrice", SqlDbType.Money);
                para[4].Value = BoundPrice;
                para[5] = new SqlParameter("@Date", SqlDbType.Date);
                para[5].Value = Date;
                para[6] = new SqlParameter("@BoundDetails", SqlDbType.NVarChar, 200);
                para[6].Value = BoundDetails;
                para[7] = new SqlParameter("@UserName", SqlDbType.NVarChar, 50);
                para[7].Value = UserName;
                string sqlCommand = "INSERT INTO [dbo].[Bounds]([BoundID],[BoundType],[BFrom],[BTo] ,[BoundPrice] ,[Date] ,[BoundDetails] ,[UserName]) VALUES (@BoundID ,@BoundType  ,@BFrom ,@BTo ,@BoundPrice ,@Date ,@BoundDetails ,@UserName)";
                DataLayer.ExecuteCommand_offline(sqlCommand, para);
        }

        public void Add_MainBound(string BoundID,string BoundType,string BFrom,string BTo,
                                decimal BoundPrice,DateTime Date,string BoundDetails,string UserName,
                                int CustomerID,decimal CustomerDain,decimal CustomerMadin ,decimal CustomerPalance,
                                int AccID, decimal AccPalance,string DailyType,string DailyDetails,decimal DailyDain,
                                decimal DailyMadin,double DailyQty ,string CReportDetails,double CReportQty ,
                                decimal CReportDain,decimal CReportMadin)
        {
            try
            {
                DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
                DataLayer.open();
                SqlParameter[] para;
                if(BoundType=="سند قبض")
                 para = new SqlParameter[23];
                else
                 para = new SqlParameter[21];

                para[0] = new SqlParameter("@BoundID", SqlDbType.NVarChar, 20);
                para[0].Value = BoundID;
                para[1] = new SqlParameter("@BoundType", SqlDbType.NVarChar, 50);
                para[1].Value = BoundType;
                para[2] = new SqlParameter("@BFrom", SqlDbType.Int);
                para[2].Value = BFrom;
                para[3] = new SqlParameter("@BTo", SqlDbType.Int);
                para[3].Value = BTo;
                para[4] = new SqlParameter("@BoundPrice", SqlDbType.Money);
                para[4].Value = BoundPrice;
                para[5] = new SqlParameter("@Date", SqlDbType.DateTime);
                para[5].Value = Date;
                para[6] = new SqlParameter("@BoundDetails", SqlDbType.NVarChar, 200);
                para[6].Value = BoundDetails;
                para[7] = new SqlParameter("@UserName", SqlDbType.NVarChar, 50);
                para[7].Value = UserName;
                para[8] = new SqlParameter("@CustomerID", SqlDbType.Int);
                para[8].Value = CustomerID;
                para[9] = new SqlParameter("@CustomerDain", SqlDbType.Money);
                para[9].Value = CustomerDain;
                para[10] = new SqlParameter("@CustomerMadin", SqlDbType.Money);
                para[10].Value = CustomerMadin;
                para[11] = new SqlParameter("@CustomerPalance", SqlDbType.Money);
                para[11].Value = CustomerPalance;
                para[12] = new SqlParameter("@AccID", SqlDbType.Int);
                para[12].Value = AccID;
                para[13] = new SqlParameter("@AccPalance", SqlDbType.Money);
                para[13].Value = AccPalance;
               
                if (BoundType == "سند قبض")
                {
                    para[14] = new SqlParameter("@DailyType", SqlDbType.NVarChar, 50);
                    para[14].Value = DailyType;
                    para[15] = new SqlParameter("@DailyDetails", SqlDbType.NVarChar, 200);
                    para[15].Value = DailyDetails;
                    para[16] = new SqlParameter("@DailyDain", SqlDbType.Money);
                    para[16].Value = DailyDain;
                    para[17] = new SqlParameter("@DailyMadin", SqlDbType.Money);
                    para[17].Value = DailyMadin;
                    para[18] = new SqlParameter("@DailyQty", SqlDbType.Real);
                    para[18].Value = DailyQty;
                    para[19] = new SqlParameter("@CReportDetails", SqlDbType.NVarChar, 200);
                    para[19].Value = CReportDetails;
                    para[20] = new SqlParameter("@CReportQty", SqlDbType.Real);
                    para[20].Value = CReportQty;
                    para[21] = new SqlParameter("@CReportDain", SqlDbType.Money);
                    para[21].Value = CReportDain;
                    para[22] = new SqlParameter("@CReportMadin", SqlDbType.Money);
                    para[22].Value = CReportMadin;
                    DataLayer.ExecuteCommand("SP_MainBound", para);
                }
                else
                {
                    para[14] = new SqlParameter("@BrushsType", SqlDbType.NVarChar, 50);
                    para[14].Value = DailyType;//التسميه خاطئه لكن القيمه صحيحه 
                    para[15] = new SqlParameter("@BrushsDetails", SqlDbType.NVarChar, 200);
                    para[15].Value = DailyDetails;
                    para[16] = new SqlParameter("@BrushsPrice", SqlDbType.Money);
                    para[16].Value = BoundPrice;
                    para[17] = new SqlParameter("@CReportDetails", SqlDbType.NVarChar, 200);
                    para[17].Value = CReportDetails;
                    para[18] = new SqlParameter("@CReportQty", SqlDbType.Real);
                    para[18].Value = CReportQty;
                    para[19] = new SqlParameter("@CReportDain", SqlDbType.Money);
                    para[19].Value = CReportDain;
                    para[20] = new SqlParameter("@CReportMadin", SqlDbType.Money);
                    para[20].Value = CReportMadin;
                    DataLayer.ExecuteCommand("MainBoundSarf", para);
                }
                DataLayer.close();
            }
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); }
        }

        public DataTable Get_CustomerBound()
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            return DataLayer.SelectData("Get_CustomerBound", null);
        }

    }
}
