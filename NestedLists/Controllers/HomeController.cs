﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NestedLists.Infrastructure;
using NestedLists.ViewModels;

namespace NestedLists.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            StartNumber = 0;
        }

        private static int StartNumber { get; set; }
        public ActionResult Index()
        {
            IndexViewModel view = new IndexViewModel();
            
            view.Containers = new List<ContainerViewModel>();
            view.Containers.Add(new ContainerViewModel
            {
                Id = 1,
                Name = "Container 1",
                Groups = new List<GroupViewModel>(AddGroups(GroupType.High))
            });
            view.Containers.Add(new ContainerViewModel
            {
                Id = 2,
                Name = "Container 2",
                Groups = new List<GroupViewModel>(AddGroups(GroupType.Medium))
            });
            view.Containers.Add(new ContainerViewModel
            {
                Id = 3,
                Name = "Container 3",
                Groups = new List<GroupViewModel>(AddGroups(GroupType.Low))
            });

            view.Containers.Add(new ContainerViewModel
            {
                Id = 4,
                Name = "Container 4",
                Groups = new List<GroupViewModel>(AddGroups(GroupType.Low))
            });

            return View(view);
        }

        [HttpPost]
        public ActionResult Index([Bind(Include = "Containers")] IndexViewModel index)
        {


            return View();
        }
        private static List<GroupViewModel> AddGroups(GroupType type)
        {
            var _groups = new List<GroupViewModel>();
            _groups.Add(new GroupViewModel
            {
                Id = StartNumber,
                GroupName = "Group " + StartNumber++,
                Selected = false,
                GroupType = type
            });

            _groups.Add(new GroupViewModel
            {
                Id = StartNumber,
                GroupName = "Group " + StartNumber++,
                Selected = false,
                GroupType = type
            });

            _groups.Add(new GroupViewModel
            {
                Id = StartNumber,
                GroupName = "Group " + StartNumber++,
                Selected = false,
                GroupType = type
            });
            return _groups;
        }
    }
}