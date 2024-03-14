using APIBOXCricket.DAL;
using APIBOXCricket.Models;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data;
using System.Data.Common;

namespace APIGround.DAL
{
    public class MST_GroundDALBase : DAL_Helper
    {
        #region Method: MST_Ground_SelectAll
        public List<MST_GroundModel> MST_Ground_SelectAll()
        {
            try
            {
                //Database Connection
                SqlDatabase sqlDb = new SqlDatabase(ConnStr);
                DbCommand cmd = sqlDb.GetStoredProcCommand("PR_MST_Ground_SelectAll");
                List<MST_GroundModel> modelMST_Ground = new List<MST_GroundModel>();
                using (IDataReader dr = sqlDb.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        MST_GroundModel model = new MST_GroundModel();
                        model.GroundID = Convert.ToInt32(dr["GroundID"]);
                        model.GroundName = dr["GroundName"].ToString();
                        model.GroundNickName = dr["GroundNickName"].ToString();
                        model.BOXCricketID = Convert.ToInt32(dr["BOXCricketID"]);
                        model.GroundCapacity = Convert.ToInt32(dr["GroundCapacity"]);
                        model.GroundHeight = Convert.ToDecimal(dr["GroundHeight"]);
                        model.GroundWidth = Convert.ToDecimal(dr["GroundWidth"]);
                        model.GroundLength = Convert.ToDecimal(dr["GroundWidth"]);
                        model.ContactPersonName = dr["ContactPersonName"].ToString();
                        model.ContactPersonNumber = dr["ContactPersonNumber"].ToString();
                        model.ActualHourlyRate = Convert.ToDecimal(dr["ActualHourlyRate"]);
                        model.DiscountedHourlyRate = Convert.ToDecimal(dr["DiscountedHourlyRate"]);
                        model.GroundImagePath1 = dr["GroundImagePath1"].ToString();
                        model.GroundImagePath2 = dr["GroundImagePath2"].ToString();
                        model.GroundImagePath3 = dr["GroundImagePath3"].ToString();
                        model.GroundImagePath4 = dr["GroundImagePath4"].ToString();
                        modelMST_Ground.Add(model);
                    }
                }
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
