using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ERP.Presentation
{
    class CLS_Cashbook
    {
        public void Add_Cashbook(string name, string details, int currency, decimal initBalance, int isMain, DataLayer.DataLayer DataLayer)
        {

            SqlParameter[] para = new SqlParameter[5];
            para[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            para[0].Value = name;
            para[1] = new SqlParameter("@details", SqlDbType.NVarChar, 100);
            para[1].Value = details;
            para[2] = new SqlParameter("@currency", SqlDbType.TinyInt);
            para[2].Value = currency;
            para[3] = new SqlParameter("@initialBalance", SqlDbType.Decimal);
            para[3].Value = initBalance;
            para[4] = new SqlParameter("@isMain", SqlDbType.TinyInt);
            para[4].Value = isMain;
            string sql = "INSERT INTO [dbo].[Cashbooks] ([name] ,[details] ,[Palance] , [Currency] , [initialBalance], [isMain])  VALUES (@name,@details,@initialBalance,@currency ,@initialBalance,@isMain)";
            DataLayer.ExecuteCommand_offline(sql, para);
        }

        public void Del_CashbookReport(string docId, string docType, DataLayer.DataLayer DataLayer)
        {

            //Delete 
            SqlParameter[] pa = new SqlParameter[2];
            pa[0] = new SqlParameter("@docId", SqlDbType.NVarChar, 50);
            pa[0].Value = docId;
            pa[1] = new SqlParameter("@docType", SqlDbType.NVarChar, 50);
            pa[1].Value = docType;
            string sqlCommand = "DELETE FROM  [dbo].[CashbookReport] WHERE [DocType]=@docType and [DocId] =@docId";
            DataLayer.ExecuteCommand_offline(sqlCommand, pa);
        }

        public DataTable Get_Cashbook(int Id, DataLayer.DataLayer DataLayer)
        {
            
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Id", SqlDbType.Int);
            para[0].Value = Id;
            return DataLayer.SelectData_offline("SELECT [Id] ,[name] ,[details] , [Palance] FROM  [dbo].[Cashbooks] WHERE [Id]=@Id", para);
        }
        public DataTable Get_Cashbook(int Id)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Id", SqlDbType.Int);
            para[0].Value = Id;
            DataTable dt = DataLayer.SelectData("Get_Cashbook", para);
            DataLayer.close();
            return dt;
        }

        public DataTable Get_Cashbooks()
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            return DataLayer.SelectData("Get_Cashbooks", null);
        }
        public DataTable Get_Cashbooks(DataLayer.DataLayer DataLayer)
        {
            return DataLayer.SelectData_offline("SELECT [Id],[name] ,[details] FROM [dbo].[Cashbooks]", null);
        }
        public void Edit_Cashbook(int CashbookId, decimal Palance, DataLayer.DataLayer DataLayer)
        {

            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@Id", SqlDbType.Int);
            para[0].Value = CashbookId;
            para[1] = new SqlParameter("@Palance", SqlDbType.NVarChar, 50);
            para[1].Value = Palance;


            string sqlCommand = "UPDATE  [dbo].[Cashbooks] SET [Palance] = @Palance WHERE [Id]=@Id";
            DataLayer.ExecuteCommand_offline(sqlCommand, para);
        }

        // Report 
        public void Add_CashbookReport(int CashbookId, string DocType, int DocId, string TransactionDate, string Details, decimal Dain, decimal Madin, DataLayer.DataLayer DataLayer)
        {
            SqlParameter[] para = new SqlParameter[8];
            para[0] = new SqlParameter("@CashbookId", SqlDbType.Int);
            para[0].Value = CashbookId;
            para[1] = new SqlParameter("@DocType", SqlDbType.NVarChar, 50);
            para[1].Value = DocType;
            para[2] = new SqlParameter("@DocId", SqlDbType.Int);
            para[2].Value = DocId;
            para[3] = new SqlParameter("@TransactionDate", SqlDbType.NVarChar, 50);
            para[3].Value = TransactionDate;
            para[4] = new SqlParameter("@Details", SqlDbType.NVarChar, 200);
            para[4].Value = Details;
            para[5] = new SqlParameter("@Dain", SqlDbType.Money);
            para[5].Value = Dain;
            para[6] = new SqlParameter("@Madin", SqlDbType.Money);
            para[6].Value = Madin;
            para[7] = new SqlParameter("@rTime", SqlDbType.Time);
            para[7].Value = DateTime.Now.TimeOfDay;
            string sqlCommand = "INSERT INTO  [dbo].[CashbookReport] ([CashbookId] ,[DocType] ,[DocId] ,[TransactionDate] ,[Details],[Dain] ,[Madin],[rTime]) VALUES(@CashbookId, @DocType, @DocId, @TransactionDate, @Details, @Dain, @Madin,@rTime)";
            DataLayer.ExecuteCommand_offline(sqlCommand, para);
        }

        public string Get_Sum_CashbookDain(int CashbookId, string EndDate)//, string Begin)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            DataLayer.open();
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@CashbookId", SqlDbType.Int);
            para[0].Value = CashbookId;
            para[1] = new SqlParameter("@EndDate", SqlDbType.VarChar, 50);
            para[1].Value = EndDate;
            para[2] = new SqlParameter("@Dain", SqlDbType.Money);
            para[2].Direction = ParameterDirection.ReturnValue;
            DataLayer.ExecuteCommand("Get_Sum_CashbookDain", para);
            string p = para[2].Value.ToString();
            DataLayer.close();
            return p;
        }
        public string Get_Sum_CashbookMadin(int CashbookId, string EndDate)//, string Begin)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            DataLayer.open();
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@CashbookId", SqlDbType.Int);
            para[0].Value = CashbookId;
            para[1] = new SqlParameter("@EndDate", SqlDbType.VarChar, 50);
            para[1].Value = EndDate;
            para[2] = new SqlParameter("@Madin", SqlDbType.Money);
            para[2].Direction = ParameterDirection.ReturnValue;
            DataLayer.ExecuteCommand("Get_Sum_CashbookMadin", para);
            string p= para[2].Value.ToString();
            DataLayer.close();
            return p;
        }

        public DataTable Get_OpeningAccounts(string EndDate)//, string Begin)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@EndDate", SqlDbType.VarChar, 50);
            para[0].Value = EndDate;     
           return DataLayer.SelectData("Get_OpeningAccounts", para);
        }

        //
        public DataTable Get_CashbookTransfereReport()
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            return DataLayer.SelectData("Get_CashbookTransfereReport", null);
        }
        public void Add_CashbookTransfereReport(string tDate, string Details, decimal Dain, decimal Madin, int cashbookId, DataLayer.DataLayer DataLayer)
        {
            SqlParameter[] para = new SqlParameter[5];
            para[0] = new SqlParameter("@tDate", SqlDbType.NVarChar, 50);
            para[0].Value = tDate;
            para[1] = new SqlParameter("@Details", SqlDbType.NVarChar, 100);
            para[1].Value = Details;
            para[2] = new SqlParameter("@Dain", SqlDbType.Money);
            para[2].Value = Dain;
            para[3] = new SqlParameter("@Madin", SqlDbType.Money);
            para[3].Value = Madin;
            para[4] = new SqlParameter("@cashbookId", SqlDbType.Int);
            para[4].Value = cashbookId;
            string sqlCommand = " INSERT INTO [dbo].[CashbookTransfereReport] ([tDate] ,[Details] ,[Dain] ,[Madin] ,[cashbookId]) VALUES (@tDate,@Details ,@Dain ,@Madin ,@cashbookId)";
            DataLayer.ExecuteCommand_offline(sqlCommand, para);
        }
        public string Get_Max_CashbookTransfereReportId(DataLayer.DataLayer DataLayer)
        {
            string s;
            s = DataLayer.SelectDataS_offline("SELECT isnull (MAX(convert(int,[TransfereId])),0) FROM [dbo].[CashbookTransfereReport]", null);
            return s;
        }

    }
}
