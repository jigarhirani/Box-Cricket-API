using APIBOXCricket.Models;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data;
using System.Data.Common;

namespace APIBOXCricket.DAL
{
    public class MST_BookingDALBase : DAL_Helper
    {
        #region Method: MST_BOXCricket_SelectAll
        public bool MST_Booking_Insert(BookingModel modelMST_Booking)
        {
            try
            {
                //Database Connection
                SqlDatabase sqlDb = new SqlDatabase(ConnStr);
                DbCommand cmd = sqlDb.GetStoredProcCommand("PR_MST_Booking_Insert");
                sqlDb.AddInParameter(cmd, "@BOXCricketID", SqlDbType.Int, modelMST_Booking.BOXCricketID);
                sqlDb.AddInParameter(cmd, "@GroundID", SqlDbType.Int, modelMST_Booking.GroundID);
                sqlDb.AddInParameter(cmd, "@BookedBy", SqlDbType.Int, modelMST_Booking.UserID);
                sqlDb.AddInParameter(cmd, "@BookingDate", SqlDbType.DateTime, modelMST_Booking.BookingDate);
                sqlDb.AddInParameter(cmd, "@Slots", SqlDbType.NVarChar, modelMST_Booking.Slots);
                sqlDb.AddInParameter(cmd, "@BookingAmount", SqlDbType.Decimal, modelMST_Booking.BookingAmount);
                sqlDb.AddInParameter(cmd, "@Status", SqlDbType.VarChar, modelMST_Booking.Status);
                sqlDb.AddInParameter(cmd, "@Remarks", SqlDbType.VarChar, modelMST_Booking.Remarks);
                sqlDb.AddInParameter(cmd, "Created", SqlDbType.DateTime, DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss"));
                sqlDb.AddInParameter(cmd, "Modified", SqlDbType.DateTime, DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss"));
                if (Convert.ToBoolean(sqlDb.ExecuteNonQuery(cmd)))
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }

            catch (Exception)
            {
                return false;
            }
        }
        #endregion
    }
}
