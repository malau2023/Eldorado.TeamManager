using Eldorado.TeamManager.Application.Dtos;
using Eldorado.TeamManager.Application.Services;
using Eldorado.TeamManager.Web.Models.User;

using Microsoft.AspNetCore.Mvc;

namespace Eldorado.TeamManager.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            var viewModel = new UserListViewModel();
            viewModel.Users = _userService.ListAll();

            return View(viewModel);
        }

        public async Task<IActionResult> Edit(int id) {

            var viewModel = new UserViewModel();
            viewModel.User = await _userService.GetById(id);

            return View("Form", viewModel);
        }

        public IActionResult Create()
        {

            var viewModel = new UserViewModel();
            viewModel.User = new UserDto();

            return View("Form", viewModel);
        }

        public async Task<IActionResult> Save(UserDto user)
        {
            if (user.Id == 0)
            {
                await _userService.Create(user);
                TempData["userSave"] = "Usuário cadastrado com sucesso.";
            }
            else
            {
                await _userService.Update(user);
                TempData["userSave"] = "Usuário editado com sucesso.";
            }
            
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _userService.Delete(id);

            TempData["userDelete"] = "Usuário apagado com sucesso.";

            return RedirectToAction("Index");
        }
    }
}
