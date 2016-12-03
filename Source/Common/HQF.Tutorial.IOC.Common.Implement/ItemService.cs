using System;
using HQF.Tutorial.IOC.Common.Interface;
using HQF.Tutorial.IOC.Common.Models;

namespace HQF.Tutorial.IOC.Common.Implement
{
    public class ItemService : IItemService
    {
        public ItemEntity Add(ItemEntity entity)
        {
            if (entity == null)
                throw new ArgumentException("entity is null");

            return entity;
        }

        public void Delete(int id)
        {
            //if (item == null)
            //    throw new ArgumentException("Item does not exist");
            //if (item.IsDeleted)
            //    throw new ArgumentException("Item already deleted");

            //item.IsDeleted = true;
        }
    }
}