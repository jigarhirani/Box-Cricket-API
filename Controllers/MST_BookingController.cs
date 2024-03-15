using APIBOXCricket.BAL;
using APIBOXCricket.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIUserID.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class MST_BookingController : Controller
    {
        #region Get All Bookings of User
        [HttpGet("{UserID}")]
        public IActionResult GetAllBookingsByUser(int UserID)
        {
            MST_BookingBAL balMST_BookingBAL = new MST_BookingBAL();
            List<MST_BookingListModel> modelMST_Booking = balMST_BookingBAL.MST_Booking_SelectAll_ByBoxCricketID(UserID);

            // Make the response in key value pair
            Dictionary<string, dynamic> response = new Dictionary<string, dynamic>();
            if (UserID != 0 && modelMST_Booking != null && modelMST_Booking.Count > 0)
            {
                response.Add("status", true);
                response.Add("Message", "Data Found.");
                response.Add("data", modelMST_Booking);
                return Ok(response);
            }
            else
            {
                response.Add("status", false);
                response.Add("Message", "Data Not Found.");
                response.Add("data", null);
                return NotFound(response);
            }
        }
        #endregion

        #region Post Booking (Add new Booking)
        [HttpPost]
        public IActionResult PostBooking([FromForm] BookingModel modelMST_Booking)
        {
            MST_BookingBALBase balMST_BookingBALBase = new MST_BookingBALBase();
            bool IsSuccess = balMST_BookingBALBase.MST_Booking_Insert(modelMST_Booking);

            // Make the response in key value pair
            Dictionary<string, dynamic> response = new Dictionary<string, dynamic>();
            if (IsSuccess)
            {
                response.Add("status", true);
                response.Add("Message", "Data Inserted Successfully.");
                response.Add("data", IsSuccess);
                return Ok(response);
            }
            else
            {
                response.Add("status", false);
                response.Add("Message", "Some Error has an occured.");
                response.Add("data", null);
                return NotFound(response);
            }

        }
        #endregion

        #region Get Aviailable Slots With Rate By GroundID and BookingDate
        [HttpGet]
        public IActionResult GetAvailableSlotsWithRate(int GroundID, DateTime BookingDate)
        {
            MST_BookingBAL balMST_BookingBAL = new MST_BookingBAL();
            List<MST_SlotRateDetailsModel> modelMST_SlotDropDown = balMST_BookingBAL.MST_Slot_Rate_Details_ByDate(GroundID, BookingDate);

            // Make the response in key value pair
            Dictionary<string, dynamic> response = new Dictionary<string, dynamic>();
            if (modelMST_SlotDropDown != null && modelMST_SlotDropDown.Count > 0)
            {
                response.Add("status", true);
                response.Add("Message", "Data Found.");
                response.Add("data", modelMST_SlotDropDown);
                return Ok(response);
            }
            else
            {
                response.Add("status", false);
                response.Add("Message", "Data Not Found.");
                response.Add("data", null);
                return NotFound(response);
            }
        }
        #endregion
    }
}
