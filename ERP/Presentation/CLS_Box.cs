using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ERP.Presentation
{
    class CLS_Box
    {
        public string Get_BoxPalance()
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            return DataLayer.SelectDataS("Get_BoxPalance", null);
        }

        public string Get_BoxPalance(DataLayer.DataLayer DataLayer)
        {
            string sqlCommand = "select AccPalance from Box where AccID=200011";
            return DataLayer.SelectDataS_offline(sqlCommand, null);
        }
        public void Edit_BoxPalance(decimal AccPalance,DataLayer.DataLayer DataLayer)
        {
                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@Palance", SqlDbType.Money);
                para[0].Value = AccPalance;
                string sqlCommand = "update box set AccPalance=@Palance where AccID=200011";
                DataLayer.ExecuteCommand_offline(sqlCommand, para);
        }

        public void Edit_BoxPalance(string AccID,decimal AccPalance)
        {
            try
            {
                DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
                DataLayer.open();
                SqlParameter[] para = new SqlParameter[2];
                para[0] = new SqlParameter("@AccID", SqlDbType.Int);
                para[0].Value = AccID;
                para[1] = new SqlParameter("@Palance", SqlDbType.Money);
                para[1].Value = AccPalance;
                DataLayer.ExecuteCommand("Edit_BoxPalance", para);
                DataLayer.close();
            }
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); }
        }

        public DataTable Get_BoxDetais()
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            return DataLayer.SelectData("Get_BoxDetais", null);
        }
    }
}
