using APIBOXCricket.Models;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data;
using System.Data.Common;

namespace APIBOXCricket.DAL
{
    public class MST_BOXCricketDALBase : DAL_Helper
    {
        #region Method: MST_BOXCricket_SelectAll
        public List<MST_BOXCricketModel> MST_BOXCricket_SelectAll()
        {
            try
            {
                //Database Connection
                SqlDatabase sqlDb = new SqlDatabase(ConnStr);
                DbCommand cmd = sqlDb.GetStoredProcCommand("PR_MST_BOXCricket_SelectAll");
                List<MST_BOXCricketModel> modelMST_BOXCricket = new List<MST_BOXCricketModel>();
                using (IDataReader dr = sqlDb.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        MST_BOXCricketModel model = new MST_BOXCricketModel();
                        model.BOXCricketID = Convert.ToInt32(dr["BOXCricketID"]);
                        model.BOXCricketName = dr["BOXCricketName"].ToString();
                        model.OwnerName = dr["OwnerName"].ToString();
                        model.Address = dr["Address"].ToString();
                        model.Contact = dr["Contact"].ToString();
                        model.CountryName = dr["CountryName"].ToString();
                        model.StateName = dr["StateName"].ToString();
                        model.CityName = dr["CityName"].ToString();
                        model.BOXCricketImagePath1 = dr["BOXCricketImagePath1"].ToString();
                        model.BOXCricketImagePath2 = dr["BOXCricketImagePath2"].ToString();
                        modelMST_BOXCricket.Add(model);
                    }
                }
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
