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
//    public class ProjectsController : ControllerBase
//    {
//        private readonly AssetDatabaseContext assetDatabaseContext;
//        public ProjectsController(AssetDatabaseContext assetDatabaseContext)
//        {
//            this.assetDatabaseContext = assetDatabaseContext;
//        }

//        [HttpGet]
//        [Route("{id}")]
//        public async Task<ActionResult<Asset>> Get(int id)
//        {
//            throw new NotImplementedException();
//        }

//        [HttpGet]
//        [Route("")]
//        public async Task<ActionResult<Project>> GetAll()
//        {
//            var list = await this.assetDatabaseContext.Projects.ToListAsync<Project>();
//            return Ok(list);
//        }

//    }
//}