
using APIBOXCricket.Models;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data;
using System.Data.Common;

namespace APIBOXCricket.DAL
{
    public class MST_UserDALBase : DAL_Helper
    {
        #region Method: MST_User_Insert
        public bool MST_User_Insert(MST_User_ProfileAddModel modelMST_User_ProfileAdd)
        {
            try
            {
                //Database Connection
                SqlDatabase sqlDB = new SqlDatabase(ConnStr);
                DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_MST_User_Insert");
                sqlDB.AddInParameter(dbCMD, "FirstName", SqlDbType.VarChar, modelMST_User_ProfileAdd.FirstName);
                sqlDB.AddInParameter(dbCMD, "LastName", SqlDbType.VarChar, modelMST_User_ProfileAdd.LastName);
                sqlDB.AddInParameter(dbCMD, "Password", SqlDbType.VarChar, modelMST_User_ProfileAdd.Password);
                sqlDB.AddInParameter(dbCMD, "Email", SqlDbType.VarChar, modelMST_User_ProfileAdd.Email);
                sqlDB.AddInParameter(dbCMD, "Contact", SqlDbType.VarChar, modelMST_User_ProfileAdd.Contact);
                sqlDB.AddInParameter(dbCMD, "@CountryID", SqlDbType.Int, modelMST_User_ProfileAdd.CountryID);
                sqlDB.AddInParameter(dbCMD, "@StateID", SqlDbType.Int, modelMST_User_ProfileAdd.StateID);
                sqlDB.AddInParameter(dbCMD, "@CityID", SqlDbType.Int, modelMST_User_ProfileAdd.CityID);
                sqlDB.AddInParameter(dbCMD, "ProfilePhotoPath", SqlDbType.NVarChar, modelMST_User_ProfileAdd.ProfilePhotoPath);
                sqlDB.AddInParameter(dbCMD, "Created", SqlDbType.DateTime, DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss"));
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

        #region Method: MST_User_SelectByPK
        public MST_UserModel MST_User_SelectByPK(int UserID)
        {
            try
            {
                //Database Connection
                SqlDatabase sqlDb = new SqlDatabase(ConnStr);
                DbCommand cmd = sqlDb.GetStoredProcCommand("PR_MST_User_SelectByPK");
                sqlDb.AddInParameter(cmd, "@UserID", SqlDbType.Int, UserID);
                MST_UserModel model = new MST_UserModel();
                using (IDataReader dr = sqlDb.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        model.UserID = Convert.ToInt32(dr["UserID"]);
                        model.FirstName = dr["FirstName"].ToString();
                        model.LastName = dr["LastName"].ToString();
                        model.Email = dr["Email"].ToString();
                        model.Contact = dr["Contact"].ToString();
                        model.CountryID = Convert.ToInt32(dr["CountryID"].ToString());
                        model.StateID = Convert.ToInt32(dr["StateID"].ToString());
                        model.CityID = Convert.ToInt32(dr["CityID"].ToString());
                        model.ProfilePhotoPath = dr["ProfilePhotoPath"].ToString();
                    }
                }
                return model;
            }
            catch (Exception)
            {

                return null;

            }
        }
        #endregion

        #region Method: MST_User_UpdateByPK
        public bool MST_User_UpdateByPK(MST_User_ProfileUpdateModel modelMST_User_ProfileUpdate)
        {
            try
            {
                //Database Connection
                SqlDatabase sqlDB = new SqlDatabase(ConnStr);
                DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_MST_User_UpdateByPK");
                sqlDB.AddInParameter(dbCMD, "UserID", SqlDbType.Int, modelMST_User_ProfileUpdate.UserID);
                sqlDB.AddInParameter(dbCMD, "FirstName", SqlDbType.VarChar, modelMST_User_ProfileUpdate.FirstName);
                sqlDB.AddInParameter(dbCMD, "LastName", SqlDbType.VarChar, modelMST_User_ProfileUpdate.LastName);
                sqlDB.AddInParameter(dbCMD, "@Email", SqlDbType.VarChar, modelMST_User_ProfileUpdate.Email);
                sqlDB.AddInParameter(dbCMD, "@Contact", SqlDbType.VarChar, modelMST_User_ProfileUpdate.Contact);
                sqlDB.AddInParameter(dbCMD, "@CountryID", SqlDbType.Int, modelMST_User_ProfileUpdate.CountryID);
                sqlDB.AddInParameter(dbCMD, "@StateID", SqlDbType.Int, modelMST_User_ProfileUpdate.StateID);
                sqlDB.AddInParameter(dbCMD, "@CityID", SqlDbType.Int, modelMST_User_ProfileUpdate.CityID);
                sqlDB.AddInParameter(dbCMD, "ProfilePhotoPath", SqlDbType.NVarChar, modelMST_User_ProfileUpdate.ProfilePhotoPath);
                sqlDB.AddInParameter(dbCMD, "@Modified", SqlDbType.DateTime, DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss"));
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
