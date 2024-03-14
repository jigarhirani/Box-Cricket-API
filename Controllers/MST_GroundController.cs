using APIBOXCricket.BAL;
using APIBOXCricket.Models;
using APIGround.BAL;
using Microsoft.AspNetCore.Mvc;

namespace APIGround.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class MST_GroundController : Controller
    {
        #region Get All Ground
        [HttpGet]
        public IActionResult GetAllGround()
        {
            MST_GroundBALBase balMST_GroundBALBase = new MST_GroundBALBase();
            List<MST_GroundModel> modelMST_Ground = balMST_GroundBALBase.MST_Ground_SelectAll();

            // Make the response in key value pair
            Dictionary<string, dynamic> response = new Dictionary<string, dynamic>();
            if (modelMST_Ground != null && modelMST_Ground.Count > 0)
            {
                response.Add("status", true);
                response.Add("Message", "Data Found.");
                response.Add("data", modelMST_Ground);
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

        #region Get All Ground By BOXCricket
        [HttpGet("{BOXCricketID}")]
        public IActionResult GetAllGroundByBOXCricket(int BOXCricketID)
        {
            MST_GroundBAL balMST_GroundBAL = new MST_GroundBAL();
            List<MST_GroundModel> modelMST_Ground = balMST_GroundBAL.MST_Ground_SelectAll_ByBoxCricketID(BOXCricketID);

            // Make the response in key value pair
            Dictionary<string, dynamic> response = new Dictionary<string, dynamic>();
            if (BOXCricketID != 0 && modelMST_Ground != null && modelMST_Ground.Count > 0)
            {
                response.Add("status", true);
                response.Add("Message", "Data Found.");
                response.Add("data", modelMST_Ground);
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
