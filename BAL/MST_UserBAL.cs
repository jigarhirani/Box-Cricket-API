using APIBOXCricket.DAL;
using APIBOXCricket.Models;

namespace APIBOXCricket.BAL
{
    public class MST_UserBAL
    {
        #region Method: MST_User_Select_ByEmailPassword
        public bool MST_User_Select_ByEmailPassword(MST_User_LoginProfileModel modeMST_User_LoginProfile)
        {
            try
            {
                MST_UserDAL user_DAL = new MST_UserDAL();
                if (user_DAL.MST_User_Select_ByEmailPassword(modeMST_User_LoginProfile))
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

        #region Method: MST_User_Password_UpdateByPK
        public bool MST_User_Password_UpdateByPK(MST_User_PasswrodChangeModel modelMST_User_PasswrodChange)
        {
            try
            {
                MST_UserDAL user_DALBase = new MST_UserDAL();
                if (user_DALBase.MST_User_Password_UpdateByPK(modelMST_User_PasswrodChange))
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
