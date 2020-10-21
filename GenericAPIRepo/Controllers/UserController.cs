using GenericAPIRepo.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace GenericAPIRepo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet("auth/{id}/{password}")]
        public ServiceResult<User> AuthenticateUser(string id, string password)
        {
            return new ServiceResult<User>() { 
                ResponseData = new User { UserName = "test", Name = "Test User", Surname = "Test Surname", Password = password}, 
                HttpStatusCode = HttpStatusCode.OK, 
                ErrorMessage = null, 
                IsSuccessful = true };
        }
    }
}
