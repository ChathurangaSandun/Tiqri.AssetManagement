using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tiqri.AssetManagement.Models;

namespace Tiqri.AssetManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssetTypesController : ControllerBase
    {
        private readonly AssetDatabaseContext assetDatabaseContext;
        public AssetTypesController(AssetDatabaseContext assetDatabaseContext)
        {
            this.assetDatabaseContext = assetDatabaseContext;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Asset>> Get(int id)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<AssetType>> GetAll()
        {
            var list = await this.assetDatabaseContext.AssetTypes.ToListAsync<AssetType>();
            return Ok(list);
        }

    }
}