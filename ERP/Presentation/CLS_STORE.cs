using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ERP.Presentation
{
    class CLS_STORE
    {
        public void Add_Store(string name, string location, string details, int isMain, DataLayer.DataLayer DataLayer)
        {
            SqlParameter[] para = new SqlParameter[4];
            para[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            para[0].Value = name;
            para[1] = new SqlParameter("@location", SqlDbType.NVarChar, 50);
            para[1].Value = location;
            para[2] = new SqlParameter("@details", SqlDbType.NVarChar,100);
            para[2].Value = details;
            para[3] = new SqlParameter("@isMain", SqlDbType.TinyInt);
            para[3].Value = isMain;
            string sqlCommand = " INSERT INTO  [dbo].[Stores]([name] ,[location],[details],[isMain]) VALUES (@name ,@location ,@details,@isMain )";
            DataLayer.ExecuteCommand_offline(sqlCommand, para);
        }
        public DataTable Get_Stores(DataLayer.DataLayer DataLayer)
        {
            return DataLayer.SelectData_offline("SELECT [Id],[name] ,[location], [details], [isMain] FROM [dbo].[Stores]", null);
        }
        public DataTable Get_Stores()
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            return DataLayer.SelectData("Get_Stores", null);
        }

        public void Add_ItemToStore(int ItemID, double Qty, decimal PurchasePrice,DataLayer.DataLayer DataLayer)
        {
                SqlParameter[] para = new SqlParameter[3];
                para[0] = new SqlParameter("@ItemID", SqlDbType.Int);
                para[0].Value = ItemID;
                para[1] = new SqlParameter("@Qty", SqlDbType.Int);
                para[1].Value = Qty;
                para[2] = new SqlParameter("@PurchasePrice", SqlDbType.Money);
                para[2].Value = PurchasePrice;

                string sqlCommand = " INSERT INTO  [dbo].[Store]([ItemID] ,[Qty],[PurchasePrice]) VALUES (@ItemID ,@Qty ,@PurchasePrice )";
                DataLayer.ExecuteCommand_offline(sqlCommand, para);
        }


        public void Update_ItemInStore(int ItemID, double Qty, decimal PurchasePrice, DataLayer.DataLayer DataLayer)
        {
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@ItemID", SqlDbType.Int);
            para[0].Value = ItemID;
            para[1] = new SqlParameter("@Qty", SqlDbType.Int);
            para[1].Value = Qty;
            para[2] = new SqlParameter("@PurchasePrice", SqlDbType.Money);
            para[2].Value = PurchasePrice;

            string sqlCommand = "UPDATE  [dbo].[Store] SET [Qty] = @Qty,[PurchasePrice] = @PurchasePrice WHERE [ItemID]=@ItemID ";
            DataLayer.ExecuteCommand_offline(sqlCommand, para);
        }
        public void Update_ItemInStore(int ItemID, double Qty, DataLayer.DataLayer DataLayer)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@ItemID", SqlDbType.Int);
            para[0].Value = ItemID;
            para[1] = new SqlParameter("@Qty", SqlDbType.Int);
            para[1].Value = Qty;

            string sqlCommand = "UPDATE  [dbo].[Store] SET [Qty] = @Qty WHERE [ItemID]=@ItemID";
            DataLayer.ExecuteCommand_offline(sqlCommand, para);
        }
        //
        public SqlDataReader get_Items_EndDate(int ItemID)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@ItemID", SqlDbType.Int);
            para[0].Value = ItemID;
            return DataLayer.SelectDataR("get_Items_EndDate", para);
        }

        public SqlDataReader get_Items_All_EndDate(int ItemID)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@ItemID", SqlDbType.Int);
            para[0].Value = ItemID;
            return DataLayer.SelectDataR("get_Items_All_EndDate", para);
        }

        public SqlDataReader get_all_items_in_store()
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlDataReader dr;
            dr = DataLayer.SelectDataR("get_all_store", null);
            return dr;
        }
        public DataTable get_all_items_in_storeT()
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            return DataLayer.SelectData("get_all_store", null);
        }

        public SqlDataReader get_items_in_store()
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlDataReader dr;
            dr = DataLayer.SelectDataR("get_store", null);
            return dr;
        }

        public String Get_Item_Qty(int ItemID)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@ItemID", SqlDbType.Int);
            para[0].Value = ItemID;
            return DataLayer.SelectDataS("Get_Item_Qty", para);
        }
        //Get_ItemPrice_Purchase
        public String Get_ItemPrice_Purchase(int ItemID)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@ItemID", SqlDbType.Int);
            para[0].Value = ItemID;
            return DataLayer.SelectDataS("Get_ItemPrice_Purchase", para);
        }
        public DataTable get_Purchase_Price(int ItemID)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@ItemID", SqlDbType.Int);
            para[0].Value = ItemID;
            return DataLayer.SelectData("get_Purchase_Price", para);
        }
        public SqlDataReader Store_BeforeSevenMounths(string months)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@months", SqlDbType.Int);
            para[0].Value = months;
            return DataLayer.SelectDataR("Get_Store_BeforeSevenMounths", para);
        }
        public SqlDataReader Search_Store(string Criterion)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Criterion", SqlDbType.VarChar, 50);
            para[0].Value = Criterion;
            return DataLayer.SelectDataR("Search_Store", para);
        }
        public DataTable Search_StoreT(string Criterion)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Criterion", SqlDbType.VarChar, 50);
            para[0].Value = Criterion;
            return DataLayer.SelectData("Search_Store", para);
        }
        public DataTable GetItemById(string id)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@id", SqlDbType.Int);
            para[0].Value = id;
            return DataLayer.SelectData("GetItemById", para);
        }
        public DataTable GetItemById2(string id)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@id", SqlDbType.Int);
            para[0].Value = id;
            return DataLayer.SelectData("GetItemById2", para);
        }
    }
}
