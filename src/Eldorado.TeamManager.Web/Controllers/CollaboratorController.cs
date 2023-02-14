using Eldorado.TeamManager.Application.Dtos;
using Eldorado.TeamManager.Application.Services;
using Eldorado.TeamManager.Domain.Entities;
using Eldorado.TeamManager.Web.Models.Collaborator;

using Microsoft.AspNetCore.Mvc;

namespace Eldorado.TeamManager.Web.Controllers
{
    public class CollaboratorController : Controller
    {
        private readonly ICollaboratorService _collaboratorService;

        private readonly ISkillService _skillService;

        public CollaboratorController(ICollaboratorService collaboratorService, ISkillService skillService)
        {
            _collaboratorService = collaboratorService;
            _skillService = skillService;
        }
        public IActionResult Index()
        {
            var viewModel = new CollaboratorListViewModel();
            viewModel.Collaborators = _collaboratorService.ListAll();

            return View(viewModel);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var viewModel = new CollaboratorViewModel();
            viewModel.Collaborator = await _collaboratorService.GetById(id);
            LoadSkills(viewModel);

            return View("Form", viewModel);
        }

        public IActionResult Create()
        {
            var viewModel = new CollaboratorViewModel();
            viewModel.Collaborator = new CollaboratorDto();
            LoadSkills(viewModel);

            return View("Form", viewModel);
        }

        public async Task<IActionResult> Save(CollaboratorDto collaborator)
        {
            if (collaborator.Id == 0)
            {
                await _collaboratorService.Create(collaborator);
                TempData["collaboratorSave"] = "Colaborador cadastrado com sucesso.";
            }
            else
            {
                await _collaboratorService.Update(collaborator);
                TempData["collaboratorSave"] = "Colaborador editado com sucesso.";
            }

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(int id)
        {
            await _collaboratorService.Delete(id);

            TempData["collaboratorDelete"] = "Colaborador apagado com sucesso.";

            return RedirectToAction("Index");
        }

        private void LoadSkills(CollaboratorViewModel model)
        {
            model.Skills = _skillService.ListAll().ToList();
        }

    }
}


