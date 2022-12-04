using EMedicineBE.Data;
using EMedicineBE.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace EMedicineBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        
        private ApplicationDbContext _db;
        

        public UsersController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpPost]
        [Route("registration")]
        public Response register(Users users)
        {
            Response response = new Response();
            DAL dal = new DAL();
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("EMedcs").ToString());
            response = dal.register(users, connection);
            return response;
        }
        [HttpPost]
        [Route("login")]
        public Response login(Users users)
        {
            DAL dal = new DAL();
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("EMedcs").ToString());
            
            Response response = dal.login(users, connection);
            return response;
        }
        [HttpPost]
        [Route("viewUser")]
        public Response viewUser(Users users)
        {
            DAL dal = new DAL();
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("EMedcs").ToString());
            Response response = dal.viewUser(users, connection);
            return response;
        }
        [HttpPost]
        [Route("updateProfile")]
        public Response updateProfile(Users users)
        {
            DAL dal = new DAL();
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("EMedcs").ToString());
            Response response = dal.updateProfile(users, connection);
            return response;
        }
    }
}
