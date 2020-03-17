using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ERP.Presentation
{
    class CLS_ITEMS
    {

        public DataTable Get_All_Categories()
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            DataTable dt = new DataTable();
            dt = DataLayer.SelectData("GET_ALL_CATEGORIES", null);
            return dt;
        }

        public DataTable Get_All_ItemsT()
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            DataTable dt = new DataTable();
            dt = DataLayer.SelectData("GET_ALL_ITEMS_T", null);
            return dt;
        }

        public SqlDataReader Get_All_Items()
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlDataReader dr;
            dr = DataLayer.SelectDataR("GET_ALL_ITEMS", null);
            return dr;
        }

        public DataTable VerifyProductName(string Name)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            DataTable dt = new DataTable();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@ItemDescription", SqlDbType.NVarChar, 200);
            para[0].Value = Name;
            dt = DataLayer.SelectData("GET_ITEM_ID", para);
            return dt;
        }
        public DataTable GET_UNIT_ID(string UnitName, DataLayer.DataLayer DataLayer)
        {
            DataTable dt = new DataTable();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@UnitName", SqlDbType.NVarChar, 200);
            para[0].Value = UnitName;
            dt = DataLayer.SelectData_offline("select id from Units where UnitName=@UnitName", para);
            return dt;
        }
        public DataTable GET_UNIT_ID(string UnitName)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            DataLayer.open();
            DataTable dt = new DataTable();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@UnitName", SqlDbType.NVarChar, 200);
            para[0].Value = UnitName;
            dt = DataLayer.SelectData("GET_UNIT_ID", para);
            DataLayer.close();
            return dt;
        }
        public DataTable Search_ItemT(string ID)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            DataTable dt = new DataTable();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Criterion", SqlDbType.VarChar, 50);
            para[0].Value = ID;
            dt = DataLayer.SelectData("Search_Item", para);
            return dt;
        }
        public DataTable GetItemById3(string ID)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            DataTable dt = new DataTable();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@id", SqlDbType.Int);
            para[0].Value = ID;
            dt = DataLayer.SelectData("GetItemById3", para);
            return dt;
        }
        public SqlDataReader Get_Item_IDs()
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlDataReader dr;
            dr = DataLayer.SelectDataR("Get_Item_IDs", null);
            return dr;
        }

        public SqlDataReader Get_All_Units()
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlDataReader dr;
            dr = DataLayer.SelectDataR("Get_All_Units", null);
            return dr;
        }
        public DataTable Get_Units()
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            return DataLayer.SelectData("Get_All_Units", null);
        }

        public SqlDataReader Get_UnitsOfItem(int ItemID)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlDataReader dr;
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@ItemID", SqlDbType.Int);
            para[0].Value = ItemID;
            dr = DataLayer.SelectDataR("Get_UnitsOfItem", para);
            return dr;
        }
        public DataTable Get_UnitsOfItem_DT(int ItemID)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@ItemID", SqlDbType.Int);
            para[0].Value = ItemID;
            return DataLayer.SelectData("Get_UnitsOfItem", para);
        }

        public DataTable Get_Units_Qty_OfItem(int ItemID)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@ItemID", SqlDbType.Int);
            para[0].Value = ItemID;
            return DataLayer.SelectData("Get_Units_Qty_OfItem", para);
        }

        public SqlDataReader Get_QtyOfUnits(int ItemID)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@ItemID", SqlDbType.Int);
            para[0].Value = ItemID;
            return DataLayer.SelectDataR("Get_QtyOfUnits", para);
        }

        public DataTable Get_QtyOfUnits_DT(int ItemID)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@ItemID", SqlDbType.Int);
            para[0].Value = ItemID;
            return DataLayer.SelectData("Get_QtyOfUnits", para);
        }


        public string Get_QtyOfItemUnit_Procedure(int ItemID, string UnitName)
        {
            DataLayer.DataLayer DataLayer = new ERP.DataLayer.DataLayer();
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@ItemID", SqlDbType.Int);
            para[0].Value = ItemID;
            para[1] = new SqlParameter("@UnitName", SqlDbType.NVarChar, 100);
            para[1].Value = UnitName;
            DataLayer.open();
          //  string sqlCommand = "SELECT Item_Unit.Qty FROM  Item_Unit INNER JOIN Units ON Item_Unit.UnitID = Units.id WHERE (Units.UnitName = @UnitName) AND (Item_Unit.ItemID = @ItemID)";
            string s = DataLayer.SelectDataS("Get_QtyOfItemUnit", para);
            return s;
        }

        public string Get_QtyOfItemUnit(int ItemID, string UnitName)
        {
            DataLayer.DataLayer DataLayer = new ERP.DataLayer.DataLayer();
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@ItemID", SqlDbType.Int);
            para[0].Value = ItemID;
            para[1] = new SqlParameter("@UnitName", SqlDbType.NVarChar, 100);
            para[1].Value = UnitName;
            DataLayer.open();
            string sqlCommand = "SELECT Item_Unit.Qty FROM  Item_Unit INNER JOIN Units ON Item_Unit.UnitID = Units.id WHERE (Units.UnitName = @UnitName) AND (Item_Unit.ItemID = @ItemID)";
            string s = DataLayer.SelectDataS_offline(sqlCommand, para);
            DataLayer.close();
            return s;
        }
        public string Get_QtyOfItemUnit(int ItemID)
        {
            DataLayer.DataLayer DataLayer = new ERP.DataLayer.DataLayer();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@ItemID", SqlDbType.Int);
            para[0].Value = ItemID;
            DataLayer.open();
            string sqlCommand = "SELECT Item_Unit.Qty FROM  Item_Unit INNER JOIN Units ON Item_Unit.UnitID = Units.id WHERE (Item_Unit.IsMain = 1) AND (Item_Unit.ItemID = @ItemID)";
            string s = DataLayer.SelectDataS_offline(sqlCommand, para);
            DataLayer.close();
            return s;
        }

        public String Get_ItemPrice_Purchase(int ItemID)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@ItemID", SqlDbType.Int);
            para[0].Value = ItemID;
            return DataLayer.SelectDataS("Get_Item_SalePrice", para);
        }
        public string Get_QtyOfItemUnit(int ItemID, string UnitName, DataLayer.DataLayer DataLayer)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@ItemID", SqlDbType.Int);
            para[0].Value = ItemID;
            para[1] = new SqlParameter("@UnitName", SqlDbType.NVarChar,100);
            para[1].Value = UnitName;
            string sqlCommand = "SELECT Item_Unit.Qty FROM  Item_Unit INNER JOIN Units ON Item_Unit.UnitID = Units.id WHERE (Units.UnitName = @UnitName) AND (Item_Unit.ItemID = @ItemID)";
            string s = DataLayer.SelectDataS_offline(sqlCommand, para);
            return s;
        }
        public string Get_ItemQty(int ItemID, DataLayer.DataLayer DataLayer)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@ItemID", SqlDbType.Int);
                para[0].Value = ItemID;
                string sqlCommand = "SELECT [Qty] FROM [dbo].[Store] WHERE [ItemID]=@ItemID";
                string s = DataLayer.SelectDataS_offline(sqlCommand, para);
                return s;
            }
            catch { return "-1"; }
        }
        public string Get_Max_ItemID(DataLayer.DataLayer DataLayer)
        {
            string s;
            s = DataLayer.SelectDataS_offline("SELECT isnull (MAX(convert(int,[ItemID])),0) FROM [dbo].[Items]", null);
            return s;
        }
        public void Add_Item(string ItemDescription, string ItemDetails, decimal ItemPrice, string ItemPosition, string currency, string ItemBarcode, DataLayer.DataLayer DataLayer)
        {
                SqlParameter[] para = new SqlParameter[6];
                para[0] = new SqlParameter("@ItemDescription", SqlDbType.NVarChar, 100);
                para[0].Value = ItemDescription;
                para[1] = new SqlParameter("@ItemDetails", SqlDbType.NVarChar, 500);
                para[1].Value = ItemDetails;
                para[2] = new SqlParameter("@ItemPrice", SqlDbType.Money);
                para[2].Value = ItemPrice;
                para[3] = new SqlParameter("@ItemPosition", SqlDbType.NVarChar, 50);
                para[3].Value = ItemPosition;
                para[4] = new SqlParameter("@ItemCurrency", SqlDbType.TinyInt);
                para[4].Value = currency;
                para[5] = new SqlParameter("@ItemBarcode", SqlDbType.NVarChar, 50);
                para[5].Value = ItemBarcode;
            DataLayer.ExecuteCommand_offline("INSERT INTO [dbo].[Items] ([ItemDescription]  ,[ItemDetails] ,[ItemPrice] ,[ItemPosition] ,[ItemCurrency],[ItemBarcode] )VALUES(@ItemDescription ,@ItemDetails  ,@ItemPrice,@ItemPosition  ,@ItemCurrency, @ItemBarcode)", para);
        }

        public void Add_Unit(string UnitName)
        {
            try
            {
                DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
                DataLayer.open();
                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@UnitName", SqlDbType.NVarChar, 100);
                para[0].Value = UnitName;
                DataLayer.ExecuteCommand("Add_Unit", para);
                DataLayer.close();
            }
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); }
        }

        public void Add_ItemUnit(string ItemID, string UnitID,string Qty,int IsMain,DataLayer.DataLayer DataLayer)
        {
                SqlParameter[] para = new SqlParameter[4];
                para[0] = new SqlParameter("@ItemID", SqlDbType.Int);
                para[0].Value = ItemID;
                para[1] = new SqlParameter("@UnitID", SqlDbType.Int);
                para[1].Value = UnitID;
                para[2] = new SqlParameter("@Qty", SqlDbType.Real);
                para[2].Value = Qty;
                para[3] = new SqlParameter("@IsMain", SqlDbType.TinyInt);
                para[3].Value = IsMain;
                DataLayer.ExecuteCommand_offline("INSERT INTO [dbo].[Item_Unit] ([ItemID] ,[UnitID]  ,[Qty] ,[IsMain]) VALUES (@ItemID,@UnitID,@Qty,@IsMain)", para);
        }

        public void Delete_Unit(string id)
        {
            try
            {
                DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
                DataLayer.open();
                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@id", SqlDbType.NVarChar, 100);
                para[0].Value = id;
                DataLayer.ExecuteCommand("Delete_Unit", para);
                DataLayer.close();
            }
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); }
        }

        public void Delete_ItemUnit(string ItemID,DataLayer.DataLayer DataLayer)
        {
                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@ItemID", SqlDbType.NVarChar, 100);
                para[0].Value = ItemID;
                DataLayer.ExecuteCommand_offline("delete from Item_Unit  where ItemID=@ItemID", para);
        }
        public void Edit_Item(string Item_ID, string ItemDetails, string ItemDescription, string ItemPosition, decimal ItemPrice, DataLayer.DataLayer DataLayer)
        {
                SqlParameter[] para = new SqlParameter[5];
                para[0] = new SqlParameter("@ItemDescription", SqlDbType.NVarChar, 200);
                para[0].Value = ItemDescription;
                para[1] = new SqlParameter("@ItemID", SqlDbType.Int);
                para[1].Value = Item_ID;
                para[2] = new SqlParameter("@ItemDetails", SqlDbType.NVarChar, 500);
                para[2].Value = ItemDetails;
                para[3] = new SqlParameter("@ItemPosition", SqlDbType.NVarChar, 50);
                para[3].Value = ItemPosition;
                para[4] = new SqlParameter("@ItemPrice", SqlDbType.Money);
                para[4].Value = ItemPrice;
                DataLayer.ExecuteCommand_offline("UPDATE [dbo].[Items] SET [ItemDescription] = @ItemDescription ,[ItemDetails] = @ItemDetails,[ItemPosition]=@ItemPosition,[ItemPrice]=@ItemPrice WHERE [ItemID]=@ItemID", para);
        }

        public DataTable Get_Item_Details(string ItemDescription)
        {
            try
            {
                DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@ItemDescription", SqlDbType.NVarChar, 100);
                para[0].Value = ItemDescription;
                return DataLayer.SelectData("Get_Item_Details", para);
            }
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); }
            return null;
        }

        public SqlDataReader Search_Item(string Criterion)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlDataReader dr;
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Criterion", SqlDbType.VarChar, 50);
            para[0].Value = Criterion;
            dr = DataLayer.SelectDataR("Search_Item", para);
            return dr;
        }
       
        ///////////
        
        public void Edit_Button(string ButtonName,string Text,string Category,int VisiPresentatione)
        {
            try
            {
                DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
                DataLayer.open();
                SqlParameter[] para = new SqlParameter[4];
                para[0] = new SqlParameter("@ButtonName", SqlDbType.NVarChar, 50);
                para[0].Value = ButtonName;
                para[1] = new SqlParameter("@Text", SqlDbType.NVarChar, 50);
                para[1].Value = Text;
                para[2] = new SqlParameter("@VisiPresentatione", SqlDbType.TinyInt);
                para[2].Value = VisiPresentatione;
                para[3] = new SqlParameter("@Category", SqlDbType.NVarChar, 50);
                para[3].Value = Category;
                DataLayer.ExecuteCommand("EDIT_Buttons", para);
                DataLayer.close();
            }
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); }
        }
    }
}
