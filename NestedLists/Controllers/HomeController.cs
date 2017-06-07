using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NestedLists.ViewModels;

namespace NestedLists.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IndexViewModel view = new IndexViewModel();

            view.Containers = new List<ContainerViewModel>();
            view.Containers.Add(new ContainerViewModel
            {
                Id = 1,
                Name = "Container 1",
                Groups = new List<GroupViewModel>(AddGroups())
            });
            view.Containers.Add(new ContainerViewModel
            {
                Id = 1,
                Name = "Container 2",
                Groups = new List<GroupViewModel>(AddGroups())
            });

            return View(view);
        }

        [HttpPost]
        public ActionResult Index([Bind(Include = "Containers")] IndexViewModel index)
        {


            return View();
        }
        private static List<GroupViewModel> AddGroups()
        {
            var _groups = new List<GroupViewModel>();
            _groups.Add(new GroupViewModel
            {
                Id = 1,
                GroupName = "Group 1",
                Selected = false
            });

            _groups.Add(new GroupViewModel
            {
                Id = 2,
                GroupName = "Group 2",
                Selected = false
            });

            _groups.Add(new GroupViewModel
            {
                Id = 3,
                GroupName = "Group 3",
                Selected = false
            });
            return _groups;
        }
    }
}