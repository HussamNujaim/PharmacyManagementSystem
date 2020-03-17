using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace ERP.Presentation
{
    class CLS_DAILY
    {
        public void Add_Daily(string DailyType,string DailyDetails,double Qty,decimal DailyDain
            ,decimal DailyMadin,DateTime Date,string UserName,string ID,DataLayer.DataLayer DataLayer)
        {
                SqlParameter[] para = new SqlParameter[8];
                para[0] = new SqlParameter("@DailyType", SqlDbType.NVarChar, 50);
                para[0].Value = DailyType;
                para[1] = new SqlParameter("@DailyDetails", SqlDbType.NVarChar, 200);
                para[1].Value = DailyDetails;
                para[2] = new SqlParameter("@Qty", SqlDbType.Int);
                para[2].Value = Qty;
                para[3] = new SqlParameter("@DailyDain", SqlDbType.Money);
                para[3].Value = DailyDain;
                para[4] = new SqlParameter("@DailyMadin", SqlDbType.Money);
                para[4].Value = DailyMadin;
                para[5] = new SqlParameter("@Date", SqlDbType.DateTime);
                para[5].Value = Date;
                para[6] = new SqlParameter("@UserName", SqlDbType.NVarChar, 50);
                para[6].Value = UserName;
                para[7] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
                para[7].Value = ID;
                string sql_Command = "INSERT INTO [dbo].[Daily]([DailyType],[DailyDetails],[Qty],[DailyDain],[DailyMadin],[Date] ,[UserName],[ID]) VALUES (@DailyType ,@DailyDetails,@Qty,@DailyDain,@DailyMadin,@Date,@UserName,@ID)";
                DataLayer.ExecuteCommand_offline(sql_Command, para);
        }
    }
}
