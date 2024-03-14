using APIBOXCricket.DAL;
using APIBOXCricket.Models;

namespace APIBOXCricket.BAL
{
    public class MST_BookingBALBase
    {
        #region Method: PR_INSERT_MST_Booking
        public bool MST_Booking_Insert(BookingModel modelMST_Booking)
        {
            try
            {
                MST_BookingDALBase dalMST_Booking_DALBase = new MST_BookingDALBase();
                if (dalMST_Booking_DALBase.MST_Booking_Insert(modelMST_Booking))
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
