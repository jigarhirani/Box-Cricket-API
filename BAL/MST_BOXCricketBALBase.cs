using APIBOXCricket.DAL;
using APIBOXCricket.Models;

namespace APIBOXCricket.BAL
{
    public class MST_BOXCricketBALBase
    {
        #region Method: MST_BOXCricket_SelectAll
        public List<MST_BOXCricketModel> MST_BOXCricket_SelectAll()
        {
            try
            {
                MST_BOXCricketDALBase dalMST_BOXCricketDALBase = new MST_BOXCricketDALBase();
                List<MST_BOXCricketModel> modelMST_BOXCricket = dalMST_BOXCricketDALBase.MST_BOXCricket_SelectAll();

                return modelMST_BOXCricket;
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion
    }
}
