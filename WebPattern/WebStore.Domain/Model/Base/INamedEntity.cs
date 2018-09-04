using System;
using System.Collections.Generic;
using System.Text;

namespace WebStore.Domain.Model.Base
{
    public interface INamedEntity : IBaseEntity
    {
        string Name { get; set; }
    }
}
