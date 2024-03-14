using APIBOXCricket.BAL;
using APIBOXCricket.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIBOXCricket.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]

    public class MST_BOXCricketController : Controller
    {
        #region Get All BOXCricket
        [HttpGet]
        public IActionResult GetAllBOXCricket()
        {
            MST_BOXCricketBALBase balMST_BOXCricketBALBase = new MST_BOXCricketBALBase();
            List<MST_BOXCricketModel> modelMST_BOXCricket = balMST_BOXCricketBALBase.MST_BOXCricket_SelectAll();

            // Make the response in key value pair
            Dictionary<string, dynamic> response = new Dictionary<string, dynamic>();
            if (modelMST_BOXCricket != null && modelMST_BOXCricket.Count > 0)
            {
                response.Add("status", true);
                response.Add("Message", "Data Found.");
                response.Add("data", modelMST_BOXCricket);
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
