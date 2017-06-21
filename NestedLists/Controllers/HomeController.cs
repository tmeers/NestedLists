using System;
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


            return View(BuildData());
        }

        [HttpPost]
        public ActionResult Index([Bind(Include = "Containers")] IndexViewModel index)
        {


            return View(BuildData());
        }

        public ActionResult ListTwo()
        {


            return View(BuildData());
        }
        [HttpPost]
        public ActionResult ListTwo([Bind(Include = "Containers")] IndexViewModel index)
        {


            return View(BuildData());
        }

        private static IndexViewModel BuildData()
        {
            IndexViewModel view = new IndexViewModel();

            view.Containers = new List<ContainerViewModel>();
            view.Containers.Add(new ContainerViewModel
            {
                Id = 1,
                Name = "Container 1",
                Groups = new List<GroupViewModel>(AddGroups(GroupType.High)),
                ContainerType = GroupType.High
            });

            view.Containers.Add(new ContainerViewModel
            {
                Id = 5,
                Name = "Container 5",
                Groups = new List<GroupViewModel>(AddGroups(GroupType.Low)),
                ContainerType = GroupType.Low
            });

            view.Containers.Add(new ContainerViewModel
            {
                Id = 2,
                Name = "Container 2",
                Groups = new List<GroupViewModel>(AddGroups(GroupType.Medium)),
                ContainerType = GroupType.Medium
            });

            view.Containers.Add(new ContainerViewModel
            {
                Id = 3,
                Name = "Container 3",
                Groups = new List<GroupViewModel>(AddGroups(GroupType.Low)),
                ContainerType = GroupType.Low
            });

            view.Containers.Add(new ContainerViewModel
            {
                Id = 4,
                Name = "Container 4",
                Groups = new List<GroupViewModel>(AddGroups(GroupType.Low)),
                ContainerType = GroupType.Low
            });

            return view;
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