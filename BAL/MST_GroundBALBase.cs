using APIBOXCricket.Models;
using APIGround.DAL;

namespace APIGround.BAL
{
    public class MST_GroundBALBase
    {
        #region Method: MST_Ground_SelectAll
        public List<MST_GroundModel> MST_Ground_SelectAll()
        {
            try
            {
                MST_GroundDALBase dalMST_GroundDALBase = new MST_GroundDALBase();
                List<MST_GroundModel> modelMST_Ground = dalMST_GroundDALBase.MST_Ground_SelectAll();

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
