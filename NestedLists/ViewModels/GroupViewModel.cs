using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NestedLists.Infrastructure;

namespace NestedLists.ViewModels
{
    public class GroupViewModel
    {
        public int Id { get; set; }
        public string GroupName { get; set; }
        public bool Selected { get; set; }

        public GroupType GroupType { get; set; }
    }
}