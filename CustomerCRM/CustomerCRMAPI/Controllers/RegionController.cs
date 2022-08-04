using CustomerCRM.Core.Contracts.Service;
using CustomerCRM.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerCRMAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionController : ControllerBase
    {
        IRegionServiceAsync regionServiceAsync;

        public RegionController(IRegionServiceAsync _regionServiceAsync)
        {
            regionServiceAsync = _regionServiceAsync;
        }

        [HttpGet]
        public async Task<IActionResult> Get() 
        {
            var result = await regionServiceAsync.GetAllRegions();
            if (result != null)
                return Ok(result);
            else
                return NoContent();
        }
        [HttpPost]
        public async Task<IActionResult> Post(RegionModel region)
        {
            if(await regionServiceAsync.InsertRegion(region)>0)
                return Ok(region);
            return BadRequest();
        }
        [HttpPost]
        [Route("{id:int}")]
        public async Task<IActionResult> Put(int id, RegionModel region) {
           
            if (ModelState.IsValid) 
             {
                if (id == region.Id)
                {
                    if (await regionServiceAsync.UpdateRegionAsync(region) > 0)
                        return Ok(region);
                }
            }
            return BadRequest();
        }

        [HttpDelete]
        public async Task<IActionResult> Delect(int id) {
            if (await regionServiceAsync.DeleteRegionAsync(id) > 0) {
                var msg = new { Message = "Region has been deleted successfully." };
                return Ok(msg);
            }
            return BadRequest();
        }
    }
}
