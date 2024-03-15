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

        #region Method: MST_Slot_Rate_Details_ByDate
        public List<MST_SlotRateDetailsModel> MST_Slot_Rate_Details_ByDate(int GroundID, DateTime BookingDate)
        {
            try
            {
                MST_BookingDAL dalMST_BookingDAL = new MST_BookingDAL();
                List<MST_SlotRateDetailsModel> modelMST_SlotDropdown_List = dalMST_BookingDAL.MST_Slot_Rate_Details_ByDate(GroundID, BookingDate);

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
