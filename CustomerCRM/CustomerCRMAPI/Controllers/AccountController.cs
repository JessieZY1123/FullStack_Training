using CustomerCRM.Core.Contracts.Service;
using CustomerCRM.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace CustomerCRMAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountServiceAsync accountServiceAsync;
        public AccountController(IAccountServiceAsync _accountServiceAsync)
        {
            accountServiceAsync = _accountServiceAsync;
        }
        [HttpPost]
        [Route("SignUp")]
        public async Task<IActionResult> SignUpAsync(SignUpModel model) {
            if (!ModelState.IsValid)
                return BadRequest();
            var result = await accountServiceAsync.SignUpAsync(model);
            if (result.Succeeded)
            {
                return Ok(new { Message = "User has been created successfully."});
            }
            else {
                StringBuilder sb = new StringBuilder();
                foreach (var item in result.Errors) {
                    sb.Append(item.Description);
                }
                return BadRequest(sb.ToString());
            }
           
        }
    }
}
