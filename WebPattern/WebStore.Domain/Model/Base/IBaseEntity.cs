using System;
using System.Collections.Generic;
using System.Text;

namespace WebStore.Domain.Model.Base
{
    public interface IBaseEntity
    {
        int Id { get; set; }
    }
}
