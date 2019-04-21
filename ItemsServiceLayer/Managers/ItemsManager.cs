using ItemsDAL.DBContexts;
using ItemsDAL.Entity;
using ItemsMicroservice.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItemsMicroservice.Repository.Managers
{
    public class ItemsManager : IItemsManager
    {
        private readonly ItemContext _dbContext;

        public ItemsManager(ItemContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Item>> GetAllItems()
        {
            return await _dbContext.Items.ToListAsync();
        }

        public async Task<Item> GetItemById(int id)
        {
            return await _dbContext.Items.Where(o => o.Id == id).FirstOrDefaultAsync();
        }

        public async Task SaveItem(Item ItemVal)
        {
            _dbContext.Add(ItemVal);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateItem(int id, Item ItemVal)
        {
            _dbContext.Update(ItemVal);
            await _dbContext.SaveChangesAsync();
        }
        public async Task DeleteItem(int id)
        {
            var Item = await GetItemById(id);
            _dbContext.Items.Remove(Item);
        }
    }
}
