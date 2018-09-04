using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Domain.Model.Base;

namespace WebPattern.Models
{
    public class SectionViewModel : NameEntity, IOrderEntity
    {
        public SectionViewModel()
        {
            ChildSections = new List<SectionViewModel>();
        }

        public List<SectionViewModel> ChildSections { get; set; }

        public SectionViewModel ParentSection { get; set; }

        public int Order { get; set; }
    }
}
