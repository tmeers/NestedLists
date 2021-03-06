﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NestedLists.Infrastructure;

namespace NestedLists.ViewModels
{
    public class ContainerViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<GroupViewModel> Groups { get; set; }

        public GroupType ContainerType { get; set; }

        public ContainerViewModel()
        {
            Groups = new List<GroupViewModel>();
        }
    }
}