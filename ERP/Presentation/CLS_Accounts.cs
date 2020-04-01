using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ERP.Presentation
{
    class CLS_Accounts
    {
        //Interfaces
        public void Add_Interface(string Name)
        {
            
                DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
                DataLayer.open();
                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
                para[0].Value = Name;
                DataLayer.ExecuteCommand("Add_Interface", para);
                DataLayer.close();
           
        }
        public DataTable Get_Interfaces()
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            return DataLayer.SelectData("Get_Interfaces", null);
        }

        // primaryAccounts
        public string Get_Max_pAccountId()
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            string dt;
            dt = DataLayer.SelectDataS("Get_Max_pAccountId", null);
            return dt;
        }
        public void Add_PrimaryAccount(string Name,int [] interfaces)
        {
           
                DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
                DataLayer.open();
                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
                para[0].Value = Name;
                DataLayer.ExecuteCommand("Add_PrimaryAccount", para);
                // add account to interfaces
                string pAcc = this.Get_Max_pAccountId();
                for (int i = 0; i < interfaces.Length; i++)
                {
                    para = new SqlParameter[2];
                    para[0] = new SqlParameter("@pAccountId", SqlDbType.Int);
                    para[0].Value = pAcc;
                    para[1] = new SqlParameter("@interfaceId", SqlDbType.Int);
                    para[1].Value = interfaces[i];
                    DataLayer.ExecuteCommand("Add_pAccount_interface", para);
                }
                DataLayer.close();
           
        }
        public void Edit_PrimaryAccount(string id, string Name, int[] interfaces)
        {
            
                DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
                DataLayer.open();
                SqlParameter[] para = new SqlParameter[2];
                para[0] = new SqlParameter("@id", SqlDbType.Int);
                para[0].Value = id;
                para[1] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
                para[1].Value = Name;
                DataLayer.ExecuteCommand("Edit_PrimaryAccount", para);
               
                //delete accountinterfaces
                Delete_pAccountInterface(id);

                // add account to interfaces
                for (int i = 0; i < interfaces.Length; i++)
                {
                    para = new SqlParameter[2];
                    para[0] = new SqlParameter("@pAccountId", SqlDbType.Int);
                    para[0].Value = id;
                    para[1] = new SqlParameter("@interfaceId", SqlDbType.Int);
                    para[1].Value = interfaces[i];
                    DataLayer.ExecuteCommand("Add_pAccount_interface", para);
                }
                DataLayer.close();
           
        }

        public DataTable Get_PrimaryAccounts()
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            return DataLayer.SelectData("Get_PrimaryAccounts", null);
        }
        public DataTable Get_PrimaryAccount(string Id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Id", SqlDbType.NVarChar, 50);
            para[0].Value = Id;
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            return DataLayer.SelectData("Get_PrimaryAccount", para);
        }

        //secondaryAccounts
        public void Add_SecondaryAccount(string Id, string fatherAccount, string name, decimal dain, decimal mading, string details, int currency, DataLayer.DataLayer DataLayer)
        {
           
              //  DataLayer.DataAccessLayer DataLayer = new DataLayer.DataAccessLayer();
              //  DataLayer.open();
                SqlParameter[] para = new SqlParameter[7];
                para[0] = new SqlParameter("@Id", SqlDbType.NVarChar, 20);
                para[0].Value = Id;
                para[1] = new SqlParameter("@fatherAccount", SqlDbType.Int);
                para[1].Value = fatherAccount;
                para[2] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
                para[2].Value = name;
                para[3] = new SqlParameter("@dain", SqlDbType.Money);
                para[3].Value = dain;
                para[4] = new SqlParameter("@madin", SqlDbType.Money);
                para[4].Value = mading;
                para[5] = new SqlParameter("@details", SqlDbType.NVarChar, 200);
                para[5].Value = details;
                para[6] = new SqlParameter("@currency", SqlDbType.TinyInt);
                para[6].Value = currency;
                string sqlCommand = "INSERT INTO  [dbo].[secondaryAccounts]([Id],[fatherAccount],[name],[dain],[madin],[details],[Currency]) VALUES (@Id,@fatherAccount,@name,@dain,@madin,@details,@currency)";
                DataLayer.ExecuteCommand_offline(sqlCommand, para);
          
        }
        public void Edit_SecondaryAccount(string Id, decimal dain, decimal madin, DataLayer.DataLayer DataLayer)
        {

            // DataLayer.DataAccessLayer DataLayer = new DataLayer.DataAccessLayer();
            //   DataLayer.open();
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@Id", SqlDbType.NVarChar, 20);
            para[0].Value = Id;
            para[1] = new SqlParameter("@dain", SqlDbType.Money);
            para[1].Value = dain;
            para[2] = new SqlParameter("@madin", SqlDbType.Money);
            para[2].Value = madin;
            string sqlCommand = "UPDATE  [dbo].[secondaryAccounts] SET [dain] = @dain, [madin] = @madin  WHERE [Id] = @Id ";
            DataLayer.ExecuteCommand_offline(sqlCommand, para);

        }

        public void Edit_SecondaryAccount2(string Id, int fatherId , string name, string details )
        {

            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            DataLayer.open();
            SqlParameter[] para = new SqlParameter[4];
            para[0] = new SqlParameter("@Id", SqlDbType.NVarChar, 20);
            para[0].Value = Id;
            para[1] = new SqlParameter("@fatherId", SqlDbType.Int);
            para[1].Value = fatherId;
            para[2] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            para[2].Value = name;
            para[3] = new SqlParameter("@details", SqlDbType.NVarChar, 100);
            para[3].Value = details;
            DataLayer.ExecuteCommand("Edit_SecondaryAcc", para);
            DataLayer.close();
        }

        public DataTable Get_SecondaryAccounts(string fatherAccount)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlParameter[] para = new SqlParameter[1]; 
            para[0] = new SqlParameter("@fatherAccount", SqlDbType.NVarChar, 50);
            para[0].Value = fatherAccount;
            return DataLayer.SelectData("Get_SecondaryAccounts", para);
        }
        public DataTable Get_SecondaryAccount(string Id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Id", SqlDbType.NVarChar, 20);
            para[0].Value = Id;
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            DataTable d= DataLayer.SelectData("Get_SecondaryAccount", para);
            DataLayer.close();
            return d;
        }
        public DataTable Get_SecondaryAccount(string Id, DataLayer.DataLayer DataLayer)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Id", SqlDbType.NVarChar, 50);
            para[0].Value = Id;
            return DataLayer.SelectData_offline("SELECT [Id] ,[fatherAccount],[name],[dain] ,[madin],[details] FROM  [dbo].[secondaryAccounts] WHERE [Id] =@Id", para);
        }

        public DataTable Search_SecondaryAccounts(string fatherAccount, string Criterion)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@fatherId", SqlDbType.Int);
            para[0].Value = fatherAccount;
            para[1] = new SqlParameter("@Criterion", SqlDbType.NVarChar, 50);
            para[1].Value = Criterion;
            return DataLayer.SelectData("Search_SecondaryAcc", para);
        }

        public string Get_Max_sAccountId(string fatherAccount)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            string dt;
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@fatherAccount", SqlDbType.Int);
            para[0].Value = fatherAccount;
            dt = DataLayer.SelectDataS("Get_Max_sAccountId", para);
            return dt;
        }
        public DataTable Get_sAccounts_byInterfaceId(string interfaceId)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@interfaceId", SqlDbType.NVarChar, 50);
            para[0].Value = interfaceId;
            return DataLayer.SelectData("Get_sAccounts_byInterfaceId", para);
        }
        public SqlDataReader Get_sAccounts_byInterfaceIdR(string interfaceId)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@interfaceId", SqlDbType.NVarChar, 50);
            para[0].Value = interfaceId;
            return DataLayer.SelectDataR("Get_sAccounts_byInterfaceId", para);
        }

        //pAccountInterface
        public DataTable Get_pAccountInterface(string Id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("Id", SqlDbType.NVarChar, 50);
            para[0].Value = Id;
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            return DataLayer.SelectData("Get_pAccountInterface", para);
        }
        public void Delete_pAccountInterface(string Id)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            DataLayer.open();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Id", SqlDbType.Int);
            para[0].Value = Id;
            DataLayer.ExecuteCommand("Delete_pAccountInterface", para);
            DataLayer.close();
        }

/////////////////////////// AccountsReport
        public void Add_AccountsReport(string AccId, string DocType, int DocId, string TransactionDate, string Details, decimal Dain, decimal Madin, decimal Palance, DataLayer.DataLayer DataLayer)
        {
            
               // DataLayer.DataAccessLayer DataLayer = new DataLayer.DataAccessLayer();
             //   DataLayer.open();
                SqlParameter[] para = new SqlParameter[9];
                para[0] = new SqlParameter("@AccId", SqlDbType.NVarChar, 20);
                para[0].Value = AccId;
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
                para[7] = new SqlParameter("@Palance", SqlDbType.Money);
                para[7].Value = Palance;
                para[8] = new SqlParameter("@rTime", SqlDbType.Time);
                para[8].Value = DateTime.Now.TimeOfDay;
                string sqlCommand = "INSERT INTO  [dbo].[AccountsReport]([AccId],[DocType],[DocId],[TransactionDate],[Details],[Dain],[Madin],[Palance],[rTime]) VALUES (@AccId,@DocType,@DocId,@TransactionDate,@Details,@Dain,@Madin,@Palance,@rTime)";
                DataLayer.ExecuteCommand_offline(sqlCommand, para);
        }
/////////////////  

        public void Del_AccRep(string cardId, DataLayer.DataLayer DataLayer)
        {

            //Delete 
            SqlParameter[] pa = new SqlParameter[1];
            pa[0] = new SqlParameter("@cardId", SqlDbType.NVarChar, 50);
            pa[0].Value = cardId;
            string sqlCommand = "DELETE FROM  [dbo].[AccountsReport] WHERE [DocId] =@cardId and [DocType]= N'كرت مبيعات' ";
            DataLayer.ExecuteCommand_offline(sqlCommand, pa);
        }

        ///////////////////////////// ReceiversReport 

        public void Add_ReceiversReport(string AccId, string DocType, int DocId, string TransactionDate, string Details, decimal Dain, decimal Madin, DataLayer.DataLayer DataLayer)
        {

            // DataLayer.DataAccessLayer DataLayer = new DataLayer.DataAccessLayer();
            //   DataLayer.open();
            SqlParameter[] para = new SqlParameter[8];
            para[0] = new SqlParameter("@AccId", SqlDbType.NVarChar, 20);
            para[0].Value = AccId;
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
            string sqlCommand = "INSERT INTO  [dbo].[ReceiversReport]([AccId],[DocType],[DocId],[TransactionDate],[Details],[Dain],[Madin],[rTime]) VALUES (@AccId,@DocType,@DocId,@TransactionDate,@Details,@Dain,@Madin,@rTime)";
            DataLayer.ExecuteCommand_offline(sqlCommand, para);
        }
        public void Del_ReceiverRep(string cardId, DataLayer.DataLayer DataLayer)
        {

            //Delete 
            SqlParameter[] pa = new SqlParameter[1];
            pa[0] = new SqlParameter("@cardId", SqlDbType.NVarChar, 50);
            pa[0].Value = cardId;
            string sqlCommand = "DELETE FROM  [dbo].[ReceiversReport] WHERE [DocId] =@cardId ";
            DataLayer.ExecuteCommand_offline(sqlCommand, pa);
        }
        /////////////////  
        public string Get_Sum_AccDain(string AccId,string EndDate)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@AccId", SqlDbType.NVarChar, 20);
            para[0].Value = AccId;
            para[1] = new SqlParameter("@EndDate", SqlDbType.VarChar, 50);
            para[1].Value = EndDate;
            string data = DataLayer.SelectDataS("Get_Sum_AccDain", para);
            DataLayer.close();
            return data;
        }
        public string Get_Sum_AccMadin(string AccId, string EndDate)
        {
            DataLayer.DataLayer DataLayer = new DataLayer.DataLayer();
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@AccId", SqlDbType.NVarChar, 20);
            para[0].Value = AccId;
            para[1] = new SqlParameter("@EndDate", SqlDbType.VarChar, 50);
            para[1].Value = EndDate;
            string data = DataLayer.SelectDataS("Get_Sum_AccMadin", para);
            DataLayer.close();
            return data;
        }
    }
}
