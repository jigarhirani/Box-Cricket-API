using APIBOXCricket.DAL;
using APIBOXCricket.Models;

namespace APIBOXCricket.BAL
{
    public class MST_GroundBAL
    {
        #region Method: MST_Ground_SelectAll By BOXCricket ID
        public List<MST_GroundModel> MST_Ground_SelectAll_ByBoxCricketID(int BOXCricketID)
        {
            try
            {
                MST_GroundDAL dalMST_GroundDAL = new MST_GroundDAL();
                List<MST_GroundModel> modelMST_Ground = dalMST_GroundDAL.MST_Ground_SelectAll_ByBoxCricketID(BOXCricketID);

                return modelMST_Ground;
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion
    }
}
