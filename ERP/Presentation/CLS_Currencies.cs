using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ERP.Presentation
{
    class CLS_Currencies
    {


        public DataTable Get_Currencies()
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            return DataLayer.SelectData("Get_Currencies", null);
        }

        public void Edit_ExchangeRate(int Id, decimal ExchangeRate)
        {

             DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
             DataLayer.open();
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@Id", SqlDbType.Int);
            para[0].Value = Id;
            para[1] = new SqlParameter("@ExchangeRate", SqlDbType.Money);
            para[1].Value = ExchangeRate;
            DataLayer.ExecuteCommand("Edit_ExchangeRate", para);
            DataLayer.close();
        }

        public void AddCurrency(string name, int isMain, decimal exchangeRate)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            DataLayer.open();
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@Name", SqlDbType.NVarChar,50);
            para[0].Value = name;
            para[1] = new SqlParameter("@IsMain", SqlDbType.TinyInt);
            para[1].Value = isMain;
            para[2] = new SqlParameter("@ExchangeRate", SqlDbType.Money);
            para[2].Value = exchangeRate;
            DataLayer.ExecuteCommand("AddCurrency", para);
            DataLayer.close();
        }

        public decimal Get_ExchangeRate(int CurrencyId, DataLayer.DataLayer DataLayer)
        {
            string s;
            s = DataLayer.SelectDataS_offline("SELECT ExchangeRate FROM [dbo].[Currencies] Where [Id] = "+CurrencyId, null);
            return decimal.Parse(s);
        }

        public decimal Get_ExchangeRate(int CurrencyId)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            DataLayer.open();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Id", SqlDbType.Int);
            para[0].Value = CurrencyId;
            string s;
            s = DataLayer.SelectDataS("Get_ExchangeRate", para);
            DataLayer.close();
            return decimal.Parse(s);
        }


    }
}
