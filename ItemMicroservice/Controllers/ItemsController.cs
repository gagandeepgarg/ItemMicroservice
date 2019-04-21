using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItemsDAL.Entity;
using ItemsMicroservice.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ItemsMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IItemsManager _itemsManager;

        public ItemsController(IItemsManager itemsManager)
        {
            _itemsManager = itemsManager;
        }
        // GET api/Items
        [HttpGet]
        public async Task<IEnumerable<Item>> Get()
        {
            return await _itemsManager.GetAllItems();
        }

        // GET api/Items/1
        [HttpGet("{id}")]
        public async Task<Item> Get(int id)
        {
            return await _itemsManager.GetItemById(id);
        }

        // POST api/values
        [HttpPost]
        public async void Post([FromBody] Item ItemVal)
        {
            await _itemsManager.SaveItem(ItemVal);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async void Put(int id, [FromBody] Item ItemVal)
        {
            await _itemsManager.UpdateItem(id, ItemVal);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async void Delete(int id)
        {
            await _itemsManager.DeleteItem(id);
        }
    }
}
