using System;
using System.Collections.Generic;
using System.Text;
using WebStore.Domain.Model.Base;

namespace WebStore.Domain.Model
{
    public class Section : NameEntity, IOrderEntity
    {
        public int Order { get; set; }

        public int? ParentId { get; set; }
    }
}
