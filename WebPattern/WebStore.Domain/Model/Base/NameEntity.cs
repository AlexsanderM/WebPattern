using System;
using System.Collections.Generic;
using System.Text;

namespace WebStore.Domain.Model.Base
{
    public class NameEntity : BaseEntity, INamedEntity
    {
        public string Name { get; set; }
    }
}
