using APIBOXCricket.DAL;
using APIBOXCricket.Models;

namespace APIBOXCricket.BAL
{
    public class MST_BookingBAL
    {
        #region Method: MST_Booking_SelectAll By BOXCricket ID
        public List<MST_BookingListModel> MST_Booking_SelectAll_ByBoxCricketID(int UserID)
        {
            try
            {
                MST_BookingDAL dalMST_BookingDAL = new MST_BookingDAL();
                List<MST_BookingListModel> modelMST_Booking = dalMST_BookingDAL.MST_Booking_SelectAll_ByBoxCricketID(UserID);

                return modelMST_Booking;
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion
    }
}
