using HQF.Tutorial.IOC.Common.Models;

namespace HQF.Tutorial.IOC.Common.Interface
{
    public interface IItemService
    {
        ItemEntity Add(ItemEntity entity);

        void Delete(int id);
    }
}