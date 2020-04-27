using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ERP.Presentation
{
    class CLS_Bounds
    {
        public void Add_Bound(string Id, string Type, string AccId, decimal Price, string Details, string Date,string ReceiverId, string UserName, int CashbookId, DataLayer.DataLayer DataLayer)
        {
            SqlParameter[] para = new SqlParameter[9];
            para[0] = new SqlParameter("@Id", SqlDbType.NVarChar, 10);
            para[0].Value = Id;
            para[1] = new SqlParameter("@Type", SqlDbType.NVarChar, 50);
            para[1].Value = Type;
            para[2] = new SqlParameter("@AccId", SqlDbType.NVarChar, 20);
            para[2].Value = AccId;
            para[3] = new SqlParameter("@Price", SqlDbType.Money);
            para[3].Value = Price;
            para[4] = new SqlParameter("@Details", SqlDbType.NVarChar,200);
            para[4].Value = Details;
            para[5] = new SqlParameter("@Date", SqlDbType.NVarChar, 50);
            para[5].Value = Date;
            para[6] = new SqlParameter("@ReceiverId", SqlDbType.NVarChar, 20);
            para[6].Value = ReceiverId;
            para[7] = new SqlParameter("@UserName", SqlDbType.NVarChar, 50);
            para[7].Value = UserName;
            para[8] = new SqlParameter("@CashbookId", SqlDbType.Int);
            para[8].Value = CashbookId;
            string sqlCommand = "INSERT INTO  [dbo].[Bound] ([Id],[Type],[AccId], [Price],[Details],[Date],[ReceiverId], [UserName], [CashbookId]) VALUES (@Id, @Type, @AccId, @Price, @Details, @Date, @ReceiverId, @UserName, @CashbookId)";
            DataLayer.ExecuteCommand_offline(sqlCommand, para);
        }
        public void Add_BoundPayment(string Id, string Type, string AccId, decimal Price, string Details, string Date, string ReceiverId, string UserName, int CashbookId, DataLayer.DataLayer DataLayer)
        {
            SqlParameter[] para = new SqlParameter[9];
            para[0] = new SqlParameter("@Id", SqlDbType.NVarChar, 10);
            para[0].Value = Id;
            para[1] = new SqlParameter("@Type", SqlDbType.NVarChar, 50);
            para[1].Value = Type;
            para[2] = new SqlParameter("@AccId", SqlDbType.NVarChar, 20);
            para[2].Value = AccId;
            para[3] = new SqlParameter("@Price", SqlDbType.Money);
            para[3].Value = Price;
            para[4] = new SqlParameter("@Details", SqlDbType.NVarChar, 200);
            para[4].Value = Details;
            para[5] = new SqlParameter("@Date", SqlDbType.NVarChar, 50);
            para[5].Value = Date;
            para[6] = new SqlParameter("@ReceiverId", SqlDbType.NVarChar, 20);
            para[6].Value = ReceiverId;
            para[7] = new SqlParameter("@UserName", SqlDbType.NVarChar, 50);
            para[7].Value = UserName;
            para[8] = new SqlParameter("@CashbookId", SqlDbType.Int);
            para[8].Value = CashbookId;
            string sqlCommand = "INSERT INTO  [dbo].[BoundPayment] ([Id],[Type],[AccId], [Price],[Details],[Date],[ReceiverId], [UserName], [CashbookId]) VALUES (@Id, @Type, @AccId, @Price, @Details, @Date, @ReceiverId, @UserName, @CashbookId)";
            DataLayer.ExecuteCommand_offline(sqlCommand, para);
        }
        public void Add_ReceivingBound(string Id, string Type, string AccId, decimal Price, string Details, string Date, string UserName, DataLayer.DataLayer DataLayer)
        {
            SqlParameter[] para = new SqlParameter[7];
            para[0] = new SqlParameter("@Id", SqlDbType.NVarChar, 10);
            para[0].Value = Id;
            para[1] = new SqlParameter("@Type", SqlDbType.NVarChar, 50);
            para[1].Value = Type;
            para[2] = new SqlParameter("@AccId", SqlDbType.NVarChar, 20);
            para[2].Value = AccId;
            para[3] = new SqlParameter("@Price", SqlDbType.Money);
            para[3].Value = Price;
            para[4] = new SqlParameter("@Details", SqlDbType.NVarChar, 200);
            para[4].Value = Details;
            para[5] = new SqlParameter("@Date", SqlDbType.NVarChar, 50);
            para[5].Value = Date;
            para[6] = new SqlParameter("@UserName", SqlDbType.NVarChar, 50);
            para[6].Value = UserName;
            string sqlCommand = "INSERT INTO  [dbo].[ReceivingBound] ([Id],[Type],[AccId], [Price],[Details],[Date], [UserName]) VALUES (@Id, @Type, @AccId, @Price, @Details, @Date, @UserName)";
            DataLayer.ExecuteCommand_offline(sqlCommand, para);
        }

        public string Get_Max_BoundId(string Type, DataLayer.DataLayer DataLayer)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Type", SqlDbType.NVarChar, 50);
            para[0].Value = Type;
            return DataLayer.SelectDataS_offline("SELECT isnull (MAX(convert(int,[Id])),0) from  [dbo].[Bound] WHERE [Type]=@Type", para);
        }
        public string Get_Max_BoundId(string Type)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            DataLayer.open();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Type", SqlDbType.NVarChar, 50);
            para[0].Value = Type; 
            string s = DataLayer.SelectDataS("Get_MaxBoundId", para);
            DataLayer.close();
            return s;
        }

        public string Get_Max_BoundPaymentId(string Type, DataLayer.DataLayer DataLayer)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Type", SqlDbType.NVarChar, 50);
            para[0].Value = Type;
            return DataLayer.SelectDataS_offline("SELECT isnull (MAX(convert(int,[Id])),0) from  [dbo].[BoundPayment] WHERE [Type]=@Type", para);
        }

        public string Get_Max_BoundPaymentId(string Type)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            DataLayer.open();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Type", SqlDbType.NVarChar, 50);
            para[0].Value = Type;
            string s = DataLayer.SelectDataS("Get_MaxBoundPaymentId", para);
            DataLayer.close();
            return s;
        }

        //Bound Receiving 
        public string Get_MaxReceivingBoundId(DataLayer.DataLayer DataLayer)
        {
            return DataLayer.SelectDataS_offline("SELECT isnull (MAX(convert(int,[Id])),0) from  [dbo].[ReceivingBound]", null);
        }
        public string Get_MaxReceivingBoundId()
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            DataLayer.open();
            string s = DataLayer.SelectDataS("Get_MaxReceivingBoundId", null);
            DataLayer.close();
            return s;
        }

        public DataTable Get_Bound(string boundId)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            DataLayer.open();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Id", SqlDbType.NVarChar, 10);
            para[0].Value = boundId;
            DataTable s = DataLayer.SelectData("Get_Bound", para);
            DataLayer.close();
            return s;
        }
        public DataTable Get_BoundPayment(string boundId)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            DataLayer.open();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Id", SqlDbType.NVarChar, 10);
            para[0].Value = boundId;
            DataTable s = DataLayer.SelectData("Get_BoundPayment", para);
            DataLayer.close();
            return s;
        }
    }
}
