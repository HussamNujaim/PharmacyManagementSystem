using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ERP.Presentation
{
    class CLS_Brushs
    {
        public void Add_BrushBound(string Id, decimal Total, string Date, string UserName, DataLayer.DataLayer DataLayer)
        {
            SqlParameter[] para = new SqlParameter[4];
            para[0] = new SqlParameter("@Id", SqlDbType.NVarChar, 20);
            para[0].Value = Id;
            para[1] = new SqlParameter("@Total", SqlDbType.Money);
            para[1].Value = Total;
            para[2] = new SqlParameter("@Date", SqlDbType.NVarChar, 50);
            para[2].Value = Date;
            para[3] = new SqlParameter("@UserName", SqlDbType.NVarChar, 50);
            para[3].Value = UserName;
            string sqlCommand = "INSERT INTO  [dbo].[BrushBound] ([Id],[Total],[Date], [UserName]) VALUES (@Id, @Total, @Date, @UserName)";
            DataLayer.ExecuteCommand_offline(sqlCommand, para);
        }
        public void Add_BrushOrder(string brushId, decimal AccId, string price, string notes, DataLayer.DataLayer DataLayer)
        {
            SqlParameter[] para = new SqlParameter[4];
            para[0] = new SqlParameter("@brushId", SqlDbType.NVarChar, 20);
            para[0].Value = brushId;
            para[1] = new SqlParameter("@AccId", SqlDbType.Int);
            para[1].Value = AccId;
            para[2] = new SqlParameter("@price", SqlDbType.Money);
            para[2].Value = price;
            para[3] = new SqlParameter("@notes", SqlDbType.NVarChar, 200);
            para[3].Value = notes;
            string sqlCommand = "INSERT INTO  [dbo].[BrushOrder] ([brushId],[AccId],[price], [notes]) VALUES (@brushId, @AccId, @price, @notes)";
            DataLayer.ExecuteCommand_offline(sqlCommand, para);
        }
        public string Get_Max_BrushId(DataLayer.DataLayer DataLayer)
        {
            return DataLayer.SelectDataS_offline("SELECT isnull (MAX(convert(int,[Id])),0) from  [dbo].[BrushBound] ", null);
        }

    }
}
