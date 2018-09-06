using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WebStore.Domain.Model.Base;

namespace WebStore.Domain.Model
{
    public class Section : NameEntity, IOrderEntity
    {
        public int Order { get; set; }

        public int? ParentId { get; set; }

        [ForeignKey("ParentId")]
        public virtual Section ParentSection { get; set; }
    }
}
