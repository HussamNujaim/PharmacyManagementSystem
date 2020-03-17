﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ERP.Presentation
{
    class CLS_ORDERS
    {
        public string Get_Max_BillID()
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            string dt;
            dt = DataLayer.SelectDataS("Get_Max_BillID", null);
            return dt;
        }
        public string Get_Max_BillTemporaryID()
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            string dt;
            dt = DataLayer.SelectDataS("Get_Max_BillTemporaryID", null);
            return dt;
        }

      /*  public void Add_Bill(string BillID, string BillType, DateTime dt,string BillPrice,
                              string CustomerID,string UserName,string State,string DailyDetails,decimal Discount)
        {
            try
            {
                DataLayer.DataAccessLayer DataLayer = new DataLayer.DataAccessLayer();
                DataLayer.open();
                SqlParameter[] para = new SqlParameter[9];
                para[0] = new SqlParameter("@BillID", SqlDbType.NVarChar, 10);
                para[0].Value = BillID;
                para[1] = new SqlParameter("@BillType", SqlDbType.NVarChar, 50);
                para[1].Value = BillType;
                para[2] = new SqlParameter("@BillDate", SqlDbType.DateTime);
                para[2].Value = dt;
                para[3] = new SqlParameter("@BillPrice", SqlDbType.Money);
                para[3].Value = decimal.Parse(BillPrice);
                para[4] = new SqlParameter("@CustomerID", SqlDbType.Int);
                para[4].Value =int.Parse(CustomerID);
                para[5] = new SqlParameter("@UserName", SqlDbType.NVarChar,50);
                para[5].Value = UserName;
                para[6] = new SqlParameter("@State", SqlDbType.VarChar, 20);
                para[6].Value = State;
                para[7] = new SqlParameter("@DailyDetails", SqlDbType.NVarChar, 200);
                para[7].Value = DailyDetails;
                para[8] = new SqlParameter("@Discount", SqlDbType.Money);
                para[8].Value = Discount;
                DataLayer.ExecuteCommand("Add_Bill", para);
                DataLayer.close();
            }
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); }
        }
        */
        public void Add_BillTemporary(string BillID, string dt, string BillPrice,
                       string BillType, string CustomerID, string UserName, decimal Discount, string BillDescription,string GiveMoney, int CashbookId, DataLayer.DataLayer DataLayer)
        {
            //   DataLayer.DataAccessLayer DataLayer = new DataLayer.DataAccessLayer(transaction);
            //   DataLayer.open();
            if (CustomerID == "-1")
            {
                SqlParameter[] para = new SqlParameter[8];
                para[0] = new SqlParameter("@BillID", SqlDbType.NVarChar, 10);
                para[0].Value = BillID;
                para[1] = new SqlParameter("@BillDate", SqlDbType.NVarChar,50);
                para[1].Value = dt;
                para[2] = new SqlParameter("@BillPrice", SqlDbType.Money);
                para[2].Value = decimal.Parse(BillPrice);
                para[3] = new SqlParameter("@UserName", SqlDbType.NVarChar, 50);
                para[3].Value = UserName;
                para[4] = new SqlParameter("@Discount", SqlDbType.Money);
                para[4].Value = Discount;
                para[5] = new SqlParameter("@BillType", SqlDbType.NVarChar, 50);
                para[5].Value = BillType;
                para[6] = new SqlParameter("@BillDescription", SqlDbType.NVarChar, 50);
                para[6].Value = BillDescription;
                para[7] = new SqlParameter("@CashbookId", SqlDbType.Int);
                para[7].Value = CashbookId;
                string sqlCommand = "INSERT INTO  [dbo].[BillTemporary] ([BillID],[BillDate],[BillPrice] ,[UserName],[Discount],[BillType],[BillDescription],[IsDone], [CashbookId]) VALUES(@BillID ,@BillDate ,@BillPrice ,@UserName,@Discount,@BillType,@BillDescription,0,@CashbookId)";
                DataLayer.ExecuteCommand_offline(sqlCommand, para);
            }
            else
            {
                SqlParameter[] para = new SqlParameter[9];
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
                para[8] = new SqlParameter("@GiveMoney", SqlDbType.NVarChar, 50);
                para[8].Value = GiveMoney;
                string sqlCommand = "INSERT INTO  [dbo].[BillTemporary] ([BillID],[BillDate],[BillPrice],[CustomerID] ,[UserName],[Discount],[BillType],[BillDescription],[IsDone],[GiveMoney]) VALUES(@BillID ,@BillDate ,@BillPrice ,@CustomerID ,@UserName,@Discount,@BillType,@BillDescription,0,@GiveMoney)";
                DataLayer.ExecuteCommand_offline(sqlCommand, para);
            }
        }

        public void Edit_BillTemporary(string BillID, DateTime dt, string BillPrice,
                     string BillType, string CustomerID, string UserName, decimal Discount, string BillDescription, string GiveMoney, int CashbookId, DataLayer.DataLayer DataLayer)
        {

            //   DataLayer.DataAccessLayer DataLayer = new DataLayer.DataAccessLayer(transaction);
            //   DataLayer.open();
            if (CustomerID == "-1")
            {
                SqlParameter[] para = new SqlParameter[8];
                para[0] = new SqlParameter("@BillID", SqlDbType.NVarChar, 10);
                para[0].Value = BillID;
                para[1] = new SqlParameter("@BillDate", SqlDbType.DateTime);
                para[1].Value = dt;
                para[2] = new SqlParameter("@BillPrice", SqlDbType.Money);
                para[2].Value = decimal.Parse(BillPrice);
                para[3] = new SqlParameter("@UserName", SqlDbType.NVarChar, 50);
                para[3].Value = UserName;
                para[4] = new SqlParameter("@Discount", SqlDbType.Money);
                para[4].Value = Discount;
                para[5] = new SqlParameter("@BillType", SqlDbType.NVarChar, 50);
                para[5].Value = BillType;
                para[6] = new SqlParameter("@BillDescription", SqlDbType.NVarChar, 50);
                para[6].Value = BillDescription;
                para[7] = new SqlParameter("@CashbookId", SqlDbType.Int);
                para[7].Value = CashbookId;
                string sqlCommand = "UPDATE  [dbo].[BillTemporary] SET [BillDate]=@BillDate,[BillPrice]=@BillPrice,[UserName]=@UserName,[Discount]=@Discount,[BillType]=@BillType,[BillDescription]=@BillDescription,[IsDone]=0, [CashbookId]=@CashbookId WHERE [BillID]=@BillID";
                DataLayer.ExecuteCommand_offline(sqlCommand, para);
            }
            else
            {
                SqlParameter[] para = new SqlParameter[9];
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
                para[8] = new SqlParameter("@GiveMoney", SqlDbType.NVarChar, 50);
                para[8].Value = GiveMoney;
                string sqlCommand = "UPDATE  [dbo].[BillTemporary] SET [BillDate]=@BillDate,[BillPrice]=@BillPrice,[CustomerID]=@CustomerID ,[UserName]=@UserName,[Discount]=@Discount,[BillType]=@BillType,[BillDescription]=@BillDescription,[IsDone]=0,[GiveMoney]=@GiveMoney WHERE [BillID]=@BillID";
                DataLayer.ExecuteCommand_offline(sqlCommand, para);
            }
        }
        public void Del_BillTemporaryDetails(string BillID, DataLayer.DataLayer DataLayer)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@BillID", SqlDbType.NVarChar, 10);
            para[0].Value = BillID;
            string sqlCommand = "DELETE FROM  [dbo].[BillTemporaryDetails] WHERE [BillID]=@BillID";
            DataLayer.ExecuteCommand_offline(sqlCommand, para);

        }
        public void Add_BillTemporaryDetails(string BillID, string ItemID, decimal Price, double Qty, double Ponus, double DiscountPercent,string UnitName, DataLayer.DataLayer DataLayer)
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
            para[6] = new SqlParameter("@UnitName", SqlDbType.NVarChar,50);
            para[6].Value = UnitName;
            string sqlCommand = "INSERT INTO  [dbo].[BillTemporaryDetails] ([BillID],[ItemID],[Price] ,[Qty],[Ponus],[DiscountPercent],[UnitName]) VALUES (@BillID ,@ItemID ,@Price,@Qty,@Ponus,@DiscountPercent,@UnitName)";
            DataLayer.ExecuteCommand_offline(sqlCommand, para);
        }

        public void Add_Bill(string BillID, string BillDescription, string dt, string BillPrice,
                       string BillType,   string CustomerID, string UserName, decimal Discount, int CashbookId, DataLayer.DataLayer DataLayer)
        {

            //   DataLayer.DataAccessLayer DataLayer = new DataLayer.DataAccessLayer(transaction);
            //   DataLayer.open();
            if (CustomerID == "-1")
            {
                SqlParameter[] para = new SqlParameter[8];
                para[0] = new SqlParameter("@BillID", SqlDbType.NVarChar, 10);
                para[0].Value = BillID;
                para[1] = new SqlParameter("@BillDate", SqlDbType.NVarChar, 50);
                para[1].Value = dt;
                para[2] = new SqlParameter("@BillPrice", SqlDbType.Money);
                para[2].Value = decimal.Parse(BillPrice);
                para[3] = new SqlParameter("@UserName", SqlDbType.NVarChar, 50);
                para[3].Value = UserName;
                para[4] = new SqlParameter("@Discount", SqlDbType.Money);
                para[4].Value = Discount;
                para[5] = new SqlParameter("@BillType", SqlDbType.NVarChar, 50);
                para[5].Value = BillType;
                para[6] = new SqlParameter("@CashbookId", SqlDbType.Int);
                para[6].Value = CashbookId;
                para[7] = new SqlParameter("@BillDescription", SqlDbType.NVarChar, 50);
                para[7].Value = BillDescription;
                string sqlCommand = "INSERT INTO  [dbo].[Bill] ([BillID],[BillDate],[BillPrice] ,[UserName],[Discount],[BillType],[CashbookId],[BillDescription]) VALUES(@BillID ,@BillDate ,@BillPrice ,@UserName,@Discount,@BillType,@CashbookId,@BillDescription)";
                DataLayer.ExecuteCommand_offline(sqlCommand, para);
            }
            else
            {
                SqlParameter[] para = new SqlParameter[8];
                para[0] = new SqlParameter("@BillID", SqlDbType.NVarChar, 10);
                para[0].Value = BillID;
                para[1] = new SqlParameter("@BillDate", SqlDbType.NVarChar, 50);
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
                string sqlCommand = "INSERT INTO  [dbo].[Bill] ([BillID],[BillDate],[BillPrice],[CustomerID] ,[UserName],[Discount],[BillType], [BillDescription]) VALUES(@BillID ,@BillDate ,@BillPrice ,@CustomerID ,@UserName,@Discount,@BillType, @BillDescription)";
                DataLayer.ExecuteCommand_offline(sqlCommand, para);
            }
        }
        public void Add_BillDetails(string BillID, string ItemID, decimal Price, double Qty, double Ponus,double DiscountPercent, DataLayer.DataLayer DataLayer)
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
            string sqlCommand = "INSERT INTO  [dbo].[BillDetails] ([BillID],[ItemID],[Price] ,[Qty],[Ponus],[DiscountPercent]) VALUES (@BillID ,@ItemID ,@Price,@Qty,@Ponus,@DiscountPercent)";
            DataLayer.ExecuteCommand_offline(sqlCommand, para);

        }

       /* public void Del_BillTemporaryDetails(string BillID, DataLayer.DataAccessLayer DataLayer)
        {

            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@BillID", SqlDbType.NVarChar, 10);
            para[0].Value = BillID;
            string sqlCommand = "delete from BillTemporaryDetails where BillID=@BillID";
            DataLayer.ExecuteCommand_offline(sqlCommand, para);

        }*/
        public void Del_BillTemporary(string BillID, DataLayer.DataLayer DataLayer)
        {

            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@BillID", SqlDbType.NVarChar, 10);
            para[0].Value = BillID;
            string sqlCommand = "delete from BillTemporary where BillID=@BillID";
            DataLayer.ExecuteCommand_offline(sqlCommand, para);

        }
        public void Edit_BillTemporary(string BillID, DataLayer.DataLayer DataLayer)
        {

            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@BillID", SqlDbType.NVarChar, 10);
            para[0].Value = BillID;
            string sqlCommand = "update BillTemporary set IsDone=1 where BillID=@BillID";
            DataLayer.ExecuteCommand_offline(sqlCommand, para);

        }
        public void Add_SoftBill(string BillID, string BillType, DateTime dt, string BillPrice,
                              string UserName, string DailyDetails)
        {
            try
            {
                DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
                DataLayer.open();
                SqlParameter[] para = new SqlParameter[6];
                para[0] = new SqlParameter("@BillID", SqlDbType.NVarChar, 10);
                para[0].Value = BillID;
                para[1] = new SqlParameter("@BillType", SqlDbType.NVarChar, 50);
                para[1].Value = BillType;
                para[2] = new SqlParameter("@BillDate", SqlDbType.DateTime);
                para[2].Value = dt;
                para[3] = new SqlParameter("@BillPrice", SqlDbType.Money);
                para[3].Value = decimal.Parse(BillPrice);
                para[4] = new SqlParameter("@UserName", SqlDbType.NVarChar, 50);
                para[4].Value = UserName;
                para[5] = new SqlParameter("@DailyDetails", SqlDbType.NVarChar, 200);
                para[5].Value = DailyDetails;
                DataLayer.ExecuteCommand("Add_SoftBill", para);
                DataLayer.close();
            }
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); }
        }

        public void Add_BillDetails(string BillID, string ItemID, string Price, string Qty)
        {
            try
            {
                DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
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
                DataLayer.ExecuteCommand("Add_BillDetails", para);
                DataLayer.close();
            }
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); }
        }

       

        public void Edit_BillType(string BillID,int CustomerID,string rptDetails)
        {
            try
            {
                DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
                DataLayer.open();
                SqlParameter[] para = new SqlParameter[3];
                para[0] = new SqlParameter("@BillID", SqlDbType.NVarChar, 10);
                para[0].Value = BillID;
                para[1] = new SqlParameter("@CustomerID", SqlDbType.Int);
                para[1].Value = CustomerID;
                para[2] = new SqlParameter("@rptDetails", SqlDbType.NVarChar,200);
                para[2].Value = rptDetails;
                DataLayer.ExecuteCommand("Edit_BillType", para);
                DataLayer.close();
            }
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); }
        }

        public DataTable Get_CustomerBill()
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            return DataLayer.SelectData("Get_CustomerBill", null);
        }

        public DataTable Get_BillIDs()
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            return DataLayer.SelectData("Get_BillIDs", null);
        }


        public DataTable Get_BillTemporaryDetails(string BillID)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@BillID", SqlDbType.NVarChar, 10);
            para[0].Value = BillID;
            return DataLayer.SelectData("Get_BillTemporaryDetails", para);
        }
        public DataTable Get_BillTemporary(string BillID,int BillType)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@BillID", SqlDbType.NVarChar, 10);
            para[0].Value = BillID;
            para[1] = new SqlParameter("@BillType", SqlDbType.Int);
            para[1].Value = BillType;
            return DataLayer.SelectData("Get_BillTemporary", para);
        }
        public DataTable Get_Bill(string BillID, int BillType)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@BillID", SqlDbType.NVarChar, 10);
            para[0].Value = BillID;
            para[1] = new SqlParameter("@BillType", SqlDbType.Int);
            para[1].Value = BillType;
            return DataLayer.SelectData("Get_Bill", para);
        }

        public DataTable Get_BillDetails(string BillID)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@BillID", SqlDbType.NVarChar, 10);
            para[0].Value = BillID;
            return DataLayer.SelectData("Get_BillDetails", para);
        }

        public SqlDataReader Get_BillDetailsR(string BillID)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@BillID", SqlDbType.NVarChar, 10);
            para[0].Value = BillID;
            return DataLayer.SelectDataR("Get_BillDetails", para);
        }

        public DataTable Get_BillDetails2(string BillID) // for orders done 
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@BillID", SqlDbType.NVarChar, 10);
            para[0].Value = BillID;
            return DataLayer.SelectData("Get_BillDetails2", para);
        }

        public DataTable Get_All_BillIDs()
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            return DataLayer.SelectData("Get_All_BillIDs", null);
        }
        public DataTable Get_All_BillTemporaryIDs()
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            return DataLayer.SelectData("Get_All_BillTemporaryIDs", null);
        }

        public SqlDataReader Get_Buttons()
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlDataReader dr;
            dr = DataLayer.SelectDataR("GET_Buttons", null);
            return dr;
        }

        public string Get_BillUserName(string BillID)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@BillID", SqlDbType.NVarChar, 10);
            para[0].Value = BillID;
            string s;
            s = DataLayer.SelectDataS("Get_BillUserName", para);
            return s;
        }

        

        public DataTable Get_ItemsSalesDetails(string BeginDate,string EndDate)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@BeginDate", SqlDbType.VarChar, 50);
            para[0].Value = BeginDate;
            para[1] = new SqlParameter("@EndDate", SqlDbType.VarChar, 50);
            para[1].Value = EndDate;
            return DataLayer.SelectData("Get_ItemsSalesDetails4", para);
        }
        public SqlDataReader Get_ItemsSalesDetailsR(string BeginDate, string EndDate,string q)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@BeginDate", SqlDbType.VarChar, 50);
            para[0].Value = BeginDate;
            para[1] = new SqlParameter("@EndDate", SqlDbType.VarChar, 50);
            para[1].Value = EndDate;
            return DataLayer.SelectDataR("Get_ItemsSalesDetails"+q, para);
        }
    
    }
}
