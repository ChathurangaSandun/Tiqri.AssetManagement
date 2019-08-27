//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using Tiqri.AssetManagement.Models;

//namespace Tiqri.AssetManagement.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class UsersController : ControllerBase
//    {
//        private readonly AssetDatabaseContext assetDatabaseContext;
//        public UsersController(AssetDatabaseContext assetDatabaseContext)
//        {
//            this.assetDatabaseContext = assetDatabaseContext;
//        }

//        [HttpGet]
//        [Route("{id}")]
//        public async Task<ActionResult<User>> Get(int id)
//        {
//            throw new NotImplementedException();
//        }

//        [HttpGet]
//        [Route("")]
//        public async Task<ActionResult<User>> GetAll()
//        {
//            var list = await this.assetDatabaseContext.Users.ToListAsync<User>();
//            return Ok(list);
//        }

//        [HttpPost]
//        [Route("login")]
//        public async Task<ActionResult<User>> Login([FromBody] LoginModel loginModel)
//        {
//            var user = await this.assetDatabaseContext.Users.FirstOrDefaultAsync(o=>o.UserName == loginModel.UserName && o.Password == loginModel.Password);
//            return Ok(user);
//        }


//    }
//}