using APIBOXCricket.Models;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data;
using System.Data.Common;

namespace APIBOXCricket.DAL
{
    public class MST_BookingDAL : DAL_Helper
    {
        #region Method: MST_Booking_SelectAll_ByBoxCricketID
        public List<MST_BookingListModel> MST_Booking_SelectAll_ByBoxCricketID(int UserID)
        {
            try
            {
                //Database Connection
                SqlDatabase sqlDb = new SqlDatabase(ConnStr);
                DbCommand cmd = sqlDb.GetStoredProcCommand("PR_MST_Booking_SelectAll_ByUserID");
                sqlDb.AddInParameter(cmd, "@UserID", SqlDbType.Int, UserID);
                List<MST_BookingListModel> modelMST_Booking = new List<MST_BookingListModel>();
                using (IDataReader dr = sqlDb.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        MST_BookingListModel model = new MST_BookingListModel();
                        model.GroundName = dr["GroundName"].ToString();
                        model.BOXCricketName = dr["BOXCricketName"].ToString();
                        model.BookingDate = Convert.ToDateTime(dr["BookingDate"].ToString());
                        model.SlotDetails = dr["SlotDetails"].ToString();
                        model.TotalSlotsBooked = dr["TotalSlotsBooked"].ToString();
                        model.BookingAmount = Convert.ToDecimal(dr["BookingAmount"]);
                        model.Status = dr["Status"].ToString();
                        model.Created = Convert.ToDateTime(dr["Created"].ToString());
                        modelMST_Booking.Add(model);
                    }
                }
                return modelMST_Booking;
            }
            catch (Exception)
            {
                return null;

            }
        }
        #endregion

        #region Method: MST_Slot_Rate_Details_ByDate
        public List<MST_SlotRateDetailsModel> MST_Slot_Rate_Details_ByDate(int GroundID, DateTime BookingDate)
        {
            try
            {
                //Database Connection
                SqlDatabase sqlDB = new SqlDatabase(ConnStr);
                DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_MST_Slot_Rate_Details_ByDate");
                sqlDB.AddInParameter(dbCMD, "@GroundID", SqlDbType.Int, GroundID);
                sqlDB.AddInParameter(dbCMD, "@BookingDate", SqlDbType.DateTime, BookingDate);
                List<MST_SlotRateDetailsModel> modelMST_SlotDropdown_List = new List<MST_SlotRateDetailsModel>();
                using (IDataReader dr = sqlDB.ExecuteReader(dbCMD))
                {
                    while (dr.Read())
                    {
                        MST_SlotRateDetailsModel model = new MST_SlotRateDetailsModel();
                        model.SlotNO = Convert.ToInt32(dr["SlotNO"]);
                        model.SlotDetails = dr["SlotDetails"].ToString();
                        model.HourlyRate = Convert.ToDecimal(dr["HourlyRate"]);
                        modelMST_SlotDropdown_List.Add(model);
                    }
                }
                return modelMST_SlotDropdown_List;
            }
            catch (Exception)
            {
                return null;

            }
        }
        #endregion
    }
}
