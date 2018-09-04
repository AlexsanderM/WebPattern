using System;
using System.Collections.Generic;
using System.Text;
using WebStore.Domain.Model.Base;

namespace WebStore.Domain.Model
{
    public class Brand : NameEntity, IOrderEntity
    {
        public int Order { get; set; }
    }
}
