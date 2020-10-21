using GenericAPIRepo.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace GenericAPIRepo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet("auth/{username}/{password}")]
        public ServiceResult<AuthenticatedUserModel> AuthenticateUser(string username, string password)
        {
            return new ServiceResult<AuthenticatedUserModel>() { 
                ResponseData = new AuthenticatedUserModel { UserName = username, Password = password , UserId = 1}, 
                HttpStatusCode = HttpStatusCode.OK, 
                ErrorMessage = null, 
                IsSuccessful = true };
        }

        [HttpGet("get-user/{id}")]
        public ServiceResult<UserModel> GetUser()
        {
            return new ServiceResult<UserModel>();
        }

        [HttpPost("add-user")]
        public ServiceResult<bool> AddUser([FromBody]UserModel user)
        {
            return new ServiceResult<bool>();
        }

        [HttpPut("update-user/{id}")]
        public ServiceResult<bool> UpdateUser(int id,[FromBody] UserModel user)
        {
            return new ServiceResult<bool>();
        }

        [HttpDelete("delete-user/{id}")]
        public ServiceResult<bool> UpdateUser(int id)
        {
            return new ServiceResult<bool>();
        }
    }
}
