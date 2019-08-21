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
    public class AssetsController : ControllerBase
    {
        private readonly AssetDatabaseContext assetDatabaseContext;
        public AssetsController(AssetDatabaseContext assetDatabaseContext)
        {
            this.assetDatabaseContext = assetDatabaseContext;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Asset>> Get(int id)
        {
            var list = await this.assetDatabaseContext.Assets
                .FirstOrDefaultAsync<Asset>(o => o.Id == id);
            return Ok(list);
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<Asset>> GetAll()
        {
            var list = await this.assetDatabaseContext.Assets.ToListAsync<Asset>();
            return Ok(list);
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Asset>> Save([FromBody] Asset asset)
        {
            var inserted = await this.assetDatabaseContext.Assets.AddAsync(asset);
            return Ok(inserted);
        }

    }
}