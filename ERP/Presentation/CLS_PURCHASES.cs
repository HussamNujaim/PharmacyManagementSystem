using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ERP.Presentation
{
    class CLS_PURCHASES
    {
        public DataTable Get_Max_BillPID()
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            DataTable dt = new DataTable();
            dt = DataLayer.SelectData("Get_Max_BillPID", null);
            return dt;
        }
        public DataTable Get_All_BillPIDs()
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            return DataLayer.SelectData("Get_All_BillPIDs", null);
        }
        public string Get_BillPID(string BillID)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@BillID", SqlDbType.NVarChar, 10);
            para[0].Value = BillID;
            string s;
            s = DataLayer.SelectDataS("Get_BillPID", para);
            return s;
        }
        public string Get_BillPTemporaryID(string ID)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@id", SqlDbType.Int);
            para[0].Value = ID;
            string s;
            s = DataLayer.SelectDataS("Get_BillPTemporaryID", para);
            return s;
        }
        public SqlDataReader Get_ItemsPurchasesDetailsR(string BeginDate, string EndDate)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@BeginDate", SqlDbType.VarChar, 50);
            para[0].Value = BeginDate;
            para[1] = new SqlParameter("@EndDate", SqlDbType.VarChar, 50);
            para[1].Value = EndDate;
            return DataLayer.SelectDataR("Get_ItemsPurchasesDetails", para);
        }
     /*   public void Add_BillP(string BillID, string rtpDetails, DateTime dt, string BillPrice,
                              string CustomerID, string UserName, decimal Discount)
        {
            try
            {
                DataLayer.DataAccessLayer DataLayer = new DataLayer.DataAccessLayer();
                DataLayer.open();
                SqlParameter[] para = new SqlParameter[7];
                para[0] = new SqlParameter("@BillID", SqlDbType.NVarChar, 10);
                para[0].Value = BillID;
                para[1] = new SqlParameter("@rptDetails", SqlDbType.NVarChar, 50);
                para[1].Value = rtpDetails;
                para[2] = new SqlParameter("@BillDate", SqlDbType.DateTime);
                para[2].Value = dt;
                para[3] = new SqlParameter("@BillPrice", SqlDbType.Money);
                para[3].Value = decimal.Parse(BillPrice);
                para[4] = new SqlParameter("@CustomerID", SqlDbType.Int);
                para[4].Value = int.Parse(CustomerID);
                para[5] = new SqlParameter("@UserName", SqlDbType.NVarChar, 50);
                para[5].Value = UserName;
                para[6] = new SqlParameter("@Discount", SqlDbType.Money);
                para[6].Value = Discount;
                DataLayer.ExecuteCommand("Add_BillP", para);
                DataLayer.close();
            }
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); }
        }*/
        public void Add_BillP(string BillID, DateTime dt, string BillPrice,
                         string BillType, string CustomerID, string UserName, decimal Discount, DataLayer.DataLayer DataLayer)
        {

           
                SqlParameter[] para = new SqlParameter[7];
                para[0] = new SqlParameter("@BillID", SqlDbType.NVarChar, 10);
                para[0].Value = BillID;
                para[1] = new SqlParameter("@BillDate", SqlDbType.DateTime);
                para[1].Value = dt;
                para[2] = new SqlParameter("@BillPrice", SqlDbType.Money);
                para[2].Value = decimal.Parse(BillPrice);
                para[3] = new SqlParameter("@CustomerID", SqlDbType.Int);
                para[3].Value = int.Parse(CustomerID);
                para[4] = new SqlParameter("@UserName", SqlDbType.NVarChar, 50);
                para[4].Value = UserName;
                para[5] = new SqlParameter("@Discount", SqlDbType.Money);
                para[5].Value = Discount;
                para[6] = new SqlParameter("@BillType", SqlDbType.NVarChar, 50);
                para[6].Value = BillType;
                string sqlCommand = "INSERT INTO  [dbo].[BillP] ([BillID],[BillDate],[BillPrice],[CustomerID] ,[UserName],[Discount],[BillType]) VALUES(@BillID ,@BillDate ,@BillPrice ,@CustomerID ,@UserName,@Discount,@BillType)";
                DataLayer.ExecuteCommand_offline(sqlCommand, para);
            
        }
       
      /*  public void Add_BillPDetails(string BillID, string ItemID, string Price, string Qty)
        {
            try
            {
                DataLayer.DataAccessLayer DataLayer = new DataLayer.DataAccessLayer();
                DataLayer.open();
                SqlParameter[] para = new SqlParameter[4];
                para[0] = new SqlParameter("@BillID", SqlDbType.NVarChar, 10);
                para[0].Value = BillID;
                para[1] = new SqlParameter("@ItemID", SqlDbType.Int);
                para[1].Value = int.Parse(ItemID);
                para[2] = new SqlParameter("@Price", SqlDbType.Money);
                para[2].Value = decimal.Parse(Price);
                para[3] = new SqlParameter("@Qty", SqlDbType.Real);
                para[3].Value = double.Parse(Qty);
                DataLayer.ExecuteCommand("Add_BillPDetails", para);
                DataLayer.close();
            }
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); }
        }
        */
        public void Add_BillPDetails(string BillID, string ItemID, decimal Price, double Qty, double Ponus, double DiscountPercent, DataLayer.DataLayer DataLayer)
        {

            SqlParameter[] para = new SqlParameter[6];
            para[0] = new SqlParameter("@BillID", SqlDbType.NVarChar, 10);
            para[0].Value = BillID;
            para[1] = new SqlParameter("@ItemID", SqlDbType.Int);
            para[1].Value = int.Parse(ItemID);
            para[2] = new SqlParameter("@Price", SqlDbType.Money);
            para[2].Value = Price;
            para[3] = new SqlParameter("@Qty", SqlDbType.Real);
            para[3].Value = Qty;
            para[4] = new SqlParameter("@Ponus", SqlDbType.Real);
            para[4].Value = Ponus;
            para[5] = new SqlParameter("@DiscountPercent", SqlDbType.Real);
            para[5].Value = DiscountPercent;
            string sqlCommand = "INSERT INTO  [dbo].[BillPDetails] ([BillID],[ItemID],[Price] ,[Qty],[Ponus],[DiscountPercent]) VALUES (@BillID ,@ItemID ,@Price,@Qty,@Ponus,@DiscountPercent)";
            DataLayer.ExecuteCommand_offline(sqlCommand, para);

        }

        public void Add_BillPTemporary(string BillID, DateTime dt, string BillPrice,
                     string BillType, string CustomerID, string UserName, decimal Discount, string BillDescription, string GiveMoney, string CashbookId, DataLayer.DataLayer DataLayer)
        {
            SqlParameter[] para = new SqlParameter[10];
            para[0] = new SqlParameter("@BillID", SqlDbType.NVarChar, 10);
            para[0].Value = BillID;
            para[1] = new SqlParameter("@BillDate", SqlDbType.DateTime);
            para[1].Value = dt;
            para[2] = new SqlParameter("@BillPrice", SqlDbType.Money);
            para[2].Value = decimal.Parse(BillPrice);
            para[3] = new SqlParameter("@CustomerID", SqlDbType.Int);
            para[3].Value = int.Parse(CustomerID);
            para[4] = new SqlParameter("@UserName", SqlDbType.NVarChar, 50);
            para[4].Value = UserName;
            para[5] = new SqlParameter("@Discount", SqlDbType.Money);
            para[5].Value = Discount;
            para[6] = new SqlParameter("@BillType", SqlDbType.NVarChar, 50);
            para[6].Value = BillType;
            para[7] = new SqlParameter("@BillDescription", SqlDbType.NVarChar, 50);
            para[7].Value = BillDescription;
            para[8] = new SqlParameter("@GiveMoney", SqlDbType.Money);
            para[8].Value = GiveMoney;
            para[9] = new SqlParameter("@CashbookId", SqlDbType.Int);
            para[9].Value = CashbookId;
            string sqlCommand = "INSERT INTO  [dbo].[BillPTemporary] ([BillID],[BillDate],[BillPrice],[CustomerID] ,[UserName],[Discount],[BillType],[BillDescription],[IsDone],[GiveMoney],[CashbookId]) VALUES(@BillID ,@BillDate ,@BillPrice ,@CustomerID ,@UserName,@Discount,@BillType,@BillDescription,0,@GiveMoney,@CashbookId)";
            DataLayer.ExecuteCommand_offline(sqlCommand, para);

        }
        public void Edit_BillPTemporary(string BillID, DateTime dt, string BillPrice,
                    string BillType, string CustomerID, string UserName, decimal Discount, string BillDescription, string GiveMoney, string CashbookId, DataLayer.DataLayer DataLayer)
        {
            SqlParameter[] para = new SqlParameter[10];
            para[0] = new SqlParameter("@BillID", SqlDbType.NVarChar, 10);
            para[0].Value = BillID;
            para[1] = new SqlParameter("@BillDate", SqlDbType.DateTime);
            para[1].Value = dt;
            para[2] = new SqlParameter("@BillPrice", SqlDbType.Money);
            para[2].Value = decimal.Parse(BillPrice);
            para[3] = new SqlParameter("@CustomerID", SqlDbType.Int);
            para[3].Value = int.Parse(CustomerID);
            para[4] = new SqlParameter("@UserName", SqlDbType.NVarChar, 50);
            para[4].Value = UserName;
            para[5] = new SqlParameter("@Discount", SqlDbType.Money);
            para[5].Value = Discount;
            para[6] = new SqlParameter("@BillType", SqlDbType.NVarChar, 50);
            para[6].Value = BillType;
            para[7] = new SqlParameter("@BillDescription", SqlDbType.NVarChar, 50);
            para[7].Value = BillDescription;
            para[8] = new SqlParameter("@GiveMoney", SqlDbType.Money);
            para[8].Value = GiveMoney;
            para[9] = new SqlParameter("@CashbookId", SqlDbType.Int);
            para[9].Value = CashbookId;
            string sqlCommand = "UPDATE  [dbo].[BillPTemporary] SET [BillDate]=@BillDate,[BillPrice]=@BillPrice,[CustomerID]=@CustomerID ,[UserName]=@UserName,[Discount]=@Discount,[BillType]=@BillType,[BillDescription]=@BillDescription,[IsDone]=0,[GiveMoney]=@GiveMoney, [CashbookId]=@CashbookId WHERE [BillID]=@BillID";
            DataLayer.ExecuteCommand_offline(sqlCommand, para);

        }
        public void Del_BillPTemporaryDetails(string BillID, DataLayer.DataLayer DataLayer)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@BillID", SqlDbType.NVarChar, 10);
            para[0].Value = BillID;
            string sqlCommand = "DELETE FROM  [dbo].[BillPTemporaryDetails] WHERE [BillID]=@BillID";
            DataLayer.ExecuteCommand_offline(sqlCommand, para);

        }
        public void Add_BillPTemporaryDetails(string BillID, string ItemID, decimal Price, double Qty, double Ponus, double DiscountPercent, string UnitName, DataLayer.DataLayer DataLayer)
        {

            SqlParameter[] para = new SqlParameter[7];
            para[0] = new SqlParameter("@BillID", SqlDbType.NVarChar, 10);
            para[0].Value = BillID;
            para[1] = new SqlParameter("@ItemID", SqlDbType.Int);
            para[1].Value = int.Parse(ItemID);
            para[2] = new SqlParameter("@Price", SqlDbType.Money);
            para[2].Value = Price;
            para[3] = new SqlParameter("@Qty", SqlDbType.Real);
            para[3].Value = Qty;
            para[4] = new SqlParameter("@Ponus", SqlDbType.Real);
            para[4].Value = Ponus;
            para[5] = new SqlParameter("@DiscountPercent", SqlDbType.Real);
            para[5].Value = DiscountPercent;
            para[6] = new SqlParameter("@UnitName", SqlDbType.NVarChar, 50);
            para[6].Value = UnitName;
            string sqlCommand = "INSERT INTO  [dbo].[BillPTemporaryDetails] ([BillID],[ItemID],[Price] ,[Qty],[Ponus],[DiscountPercent],[UnitName]) VALUES (@BillID ,@ItemID ,@Price,@Qty,@Ponus,@DiscountPercent,@UnitName)";
            DataLayer.ExecuteCommand_offline(sqlCommand, para);
        }

        public DataTable Get_BillPDetails(string BillID)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@BillID", SqlDbType.NVarChar, 10);
            para[0].Value = BillID;
            return DataLayer.SelectData("Get_BillPDetails", para);
        }
        public SqlDataReader Get_BillPDetailsR(string BillID)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@BillID", SqlDbType.NVarChar, 10);
            para[0].Value = BillID;
            return DataLayer.SelectDataR("Get_BillPDetails", para);
        }

        public DataTable Get_All_BillPTemporaryIDs()
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            return DataLayer.SelectData("Get_All_BillPTemporaryIDs", null);
        }
        public DataTable Get_All_BillPTemporaryIDsDoc()
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            return DataLayer.SelectData("Get_All_BillPTemporaryIDsDoc", null);
        }
        public DataTable Get_BillPTemporaryDetails(string BillID)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@BillID", SqlDbType.NVarChar, 10);
            para[0].Value = BillID;
            return DataLayer.SelectData("Get_BillPTemporaryDetails", para);
        }
        public DataTable Get_BillPTemporary(string BillID)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@BillID", SqlDbType.NVarChar, 10);
            para[0].Value = BillID;
            return DataLayer.SelectData("Get_BillPTemporary", para);
        }
        public void Edit_BillPTemporary(string BillID, DataLayer.DataLayer DataLayer)
        {

            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@BillID", SqlDbType.NVarChar, 10);
            para[0].Value = BillID;
            string sqlCommand = "update BillPTemporary set IsDone=1 where BillID=@BillID";
            DataLayer.ExecuteCommand_offline(sqlCommand, para);

        }
    }
}
