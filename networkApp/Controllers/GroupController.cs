using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using networkApp.Models;
using networkApp.ViewModels.Groups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace networkApp.Controllers
{
    [Authorize(Roles = "admin")]
    public class GroupController : Controller
    {
        ApplicationContext context;
        UserManager<User> _userManager;

        public GroupController(ApplicationContext context, UserManager<User> userManager)
        {
            this.context = context;

            _userManager = userManager;
        }

        [HttpGet]
        public async Task<ActionResult> Index()
        {
            var groups = context.GroupInfo.ToList();

            return View("Index", groups);
        }

        [Authorize(Roles = "admin")]
        public IActionResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create(CreateGroupViewModel model)
        {
            if (ModelState.IsValid)
            {
                GroupInfo groupInfo = new GroupInfo { GroupNum = model.GroupNum, Specialize = model.Specialize };
                context.GroupInfo.Add(groupInfo);
                await context.SaveChangesAsync();

                return RedirectToAction("Index");
            }
            return View(model);
        }

        public async Task<IActionResult> Edit(string id)
        {
            GroupInfo group = context.GroupInfo
                .Where(g => g.GroupInfoId == Convert.ToInt32(id)).FirstOrDefault();
            if (group == null)
                return NotFound();
            EditGroupViewModel model = new EditGroupViewModel { GroupInfoId = group.GroupInfoId, GroupNum = group.GroupNum, Specialize = group.Specialize };
                return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditGroupViewModel model, int oldGroup)
        {
            if (ModelState.IsValid)
            {
                GroupInfo group = context.GroupInfo
                    .Where(g => g.GroupInfoId == Convert.ToInt32(model.GroupInfoId)).FirstOrDefault();
                if (group != null)
                {
                    group.GroupInfoId = model.GroupInfoId;
                    group.GroupNum = model.GroupNum;
                    group.Specialize = model.Specialize;

                    List<User> users = _userManager.Users.ToList();

                    foreach (var user in users)
                    {
                        if (user.Group == oldGroup)
                        {
                            user.Group = model.GroupNum;

                            context.UserInfo.Update(user);
                        }
                    }

                    context.GroupInfo.Update(group);
                    await context.SaveChangesAsync();
                }
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<ActionResult> Delete(string id)
        {
            GroupInfo group = context.GroupInfo
                .Where(g => g.GroupInfoId == Convert.ToInt32(id)).FirstOrDefault();

            context.GroupInfo.Remove(group);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
