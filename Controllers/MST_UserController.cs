using APIBOXCricket.BAL;
using APIBOXCricket.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIBOXCricket.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]

    public class MST_UserController : Controller
    {
        #region Post UserLogin (Login User)
        [HttpPost]
        public IActionResult PostLoginUser([FromForm] MST_User_LoginProfileModel modeMST_User_LoginProfile)
        {
            MST_UserBAL bal = new MST_UserBAL();
            bool IsSuccess = bal.MST_User_Select_ByEmailPassword(modeMST_User_LoginProfile);

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

        #region Post User (SignUp User)
        [HttpPost]
        public IActionResult PostSignUpUser([FromForm] MST_User_ProfileAddModel modelMST_User_ProfileAdd)
        {
            MST_UserBALBase bal = new MST_UserBALBase();
            bool IsSuccess = bal.MST_User_Insert(modelMST_User_ProfileAdd);

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

        #region Get User Details By UserID
        [HttpGet("{UserID}")]
        public IActionResult GetUserProfileDetails(int UserID)
        {
            MST_UserBALBase bal = new MST_UserBALBase();
            MST_UserModel Users = bal.MST_User_SelectByPK(UserID);

            // Make the response in key value pair
            Dictionary<string, dynamic> response = new Dictionary<string, dynamic>();
            if (Users.UserID != 0)
            {
                response.Add("status", true);
                response.Add("Message", "Data Found.");
                response.Add("data", Users);
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

        #region Put User Details By UserID
        [HttpPut]
        public IActionResult PutUserDetailsUpdate([FromForm] MST_User_ProfileUpdateModel modelMST_UserProfileUpdate)
        {
            MST_UserBALBase bal = new MST_UserBALBase();
            bool IsSuccess = bal.MST_User_UpdateByPK(modelMST_UserProfileUpdate);

            // Make the response in key value pair
            Dictionary<string, dynamic> response = new Dictionary<string, dynamic>();
            if (IsSuccess)
            {
                response.Add("status", true);
                response.Add("Message", "Data Updated Successfully.");
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

        #region Put User Password Change
        [HttpPut]
        public IActionResult PutUserPasswordChange([FromForm] MST_User_PasswrodChangeModel modelMST_User_PasswrodChange)
        {
            MST_UserBAL bal = new MST_UserBAL();
            bool IsSuccess = bal.MST_User_Password_UpdateByPK(modelMST_User_PasswrodChange);

            // Make the response in key value pair
            Dictionary<string, dynamic> response = new Dictionary<string, dynamic>();
            if (IsSuccess)
            {
                response.Add("status", true);
                response.Add("Message", "Data Updated Successfully.");
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
    }
}
