using api_cc.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api_cc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    

    public class AdminController : ControllerBase
    {
        private AdminAuthenticationService _adminAuthService;

        public AdminController()
        {
            _adminAuthService = new AdminAuthenticationService();
        }

       
      
      
    }
}
