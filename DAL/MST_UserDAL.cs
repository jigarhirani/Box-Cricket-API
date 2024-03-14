using APIBOXCricket.Models;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data;
using System.Data.Common;

namespace APIBOXCricket.DAL
{
    public class MST_UserDAL : DAL_Helper
    {
        #region Method: MST_User_Password_UpdateByPK
        public bool MST_User_Password_UpdateByPK(MST_User_PasswrodChangeModel modelMST_User_PasswrodChange)
        {
            try
            {
                //Database Connection
                SqlDatabase sqlDB = new SqlDatabase(ConnStr);
                DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_MST_User_Password_UpdateByPK");
                sqlDB.AddInParameter(dbCMD, "UserID", SqlDbType.Int, modelMST_User_PasswrodChange.UserID);
                sqlDB.AddInParameter(dbCMD, "CurruntPassword", SqlDbType.VarChar, modelMST_User_PasswrodChange.CurruntPassword);
                sqlDB.AddInParameter(dbCMD, "NewPassword", SqlDbType.VarChar, modelMST_User_PasswrodChange.NewPassword);
                sqlDB.AddInParameter(dbCMD, "Modified", SqlDbType.DateTime, DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss"));
                if (Convert.ToBoolean(sqlDB.ExecuteNonQuery(dbCMD)))
                    return true;

                else
                    return false;
            }

            catch (Exception)
            {
                return false;

            }
        }
        #endregion
    }
}
