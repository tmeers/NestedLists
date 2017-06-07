using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NestedLists.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string GroupName { get; set; }
        public virtual Container Container { get; set; }
    }
}