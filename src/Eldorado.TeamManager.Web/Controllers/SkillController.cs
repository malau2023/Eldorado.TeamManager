using Eldorado.TeamManager.Application.Dtos; 
using Eldorado.TeamManager.Application.Services;
using Eldorado.TeamManager.Web.Models.Skill;

using Microsoft.AspNetCore.Mvc;

namespace Eldorado.TeamManager.Web.Controllers
{
    public class SkillController : Controller
    {
        private readonly ISkillService _skillService;

        public SkillController(ISkillService skillService)
        {
            _skillService = skillService;
        }

        public IActionResult Index()
        {
            var viewModel = new SkillListViewModel();
            //viewModel.Skills = _skillService.ListAll();

            return View(viewModel);
        }

        public async Task<IActionResult> Edit(int id){
            var viewModel = new SkillViewModel();
            viewModel.Skill = await _skillService.GetById(id);

            return View("Form", viewModel);
        }

        public IActionResult Create(){
            var viewModel = new SkillViewModel();
            viewModel.Skill = new SkillDto();

            return View("Form", viewModel);
        }

        public async Task<IActionResult> Save(SkillDto skill){
            if (skill.Id == 0)
            {
                await _skillService.Create(skill);
                TempData["skillSave"] = "Skill cadastrada com sucesso.";
            }
            else
            {
                await _skillService.Update(skill);
                TempData["skillSave"] = "Skill editada com sucesso.";
            }

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id){
            await _skillService.Delete(id);
            TempData["skillDelete"] = "Skill apagada com sucesso.";

            return RedirectToAction("Index");
        }
    }
}