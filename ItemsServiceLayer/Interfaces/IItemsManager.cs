using ItemsDAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItemsMicroservice.Repository.Interfaces
{
    public interface IItemsManager
    {
        Task<List<Item>> GetAllItems();
        Task<Item> GetItemById(int id);
        Task SaveItem(Item ItemVal);
        Task UpdateItem(int id, Item ItemVal);
        Task DeleteItem(int id);
    }
}
