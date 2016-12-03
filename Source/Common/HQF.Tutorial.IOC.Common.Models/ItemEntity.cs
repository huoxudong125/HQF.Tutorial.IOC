using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HQF.Tutorial.IOC.Common.Models
{
    public class ItemEntity
    {
       
        public int Id { get; set; }

        public string Name { get; set; }

        public int Quiantity { get; set; }

        public bool IsDeleted { get; set; }

        public ItemEntity()
        {
            IsDeleted = false;
        }
    }
}
