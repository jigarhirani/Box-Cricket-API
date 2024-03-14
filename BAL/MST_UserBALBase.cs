using APIBOXCricket.DAL;
using APIBOXCricket.Models;

namespace APIBOXCricket.BAL
{
    public class MST_UserBALBase
    {
        #region Method: MST_User_SelectByPK
        public MST_UserModel MST_User_SelectByPK(int UserID)
        {
            try
            {
                MST_UserDALBase user_DALBase = new MST_UserDALBase();
                MST_UserModel UserModel = user_DALBase.MST_User_SelectByPK(UserID);
                return UserModel;
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
                MST_UserDALBase user_DALBase = new MST_UserDALBase();
                if (user_DALBase.MST_User_UpdateByPK(modelMST_User_ProfileUpdate))
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

        #region Method: MST_User_Insert
        public bool MST_User_Insert(MST_User_ProfileAddModel modelMST_User_ProfileAdd)
        {
            try
            {
                MST_UserDALBase user_DALBase = new MST_UserDALBase();
                if (user_DALBase.MST_User_Insert(modelMST_User_ProfileAdd))
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
