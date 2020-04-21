namespace GEM.Web.Controllers
{
    using GEM.Web.Data;
    using GEM.Web.Data.Entities;
    using GEM.Web.Helpers;
    using GEM.Web.Models;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using System.Threading.Tasks;

    public class ClientsController : Controller
    {
        private readonly DataContext dataContext;
        private readonly ICombosHelper combosHelper;

        public ClientsController(DataContext dataContext, ICombosHelper combosHelper)
        {
            this.dataContext = dataContext;
            this.combosHelper = combosHelper;
        }

        public async Task<IActionResult> Index()
        {
            return View(await dataContext.Clients.ToListAsync());
        }

        public IActionResult Create()
        {
            var model = new ClientViewModel
            {
                Genders = combosHelper.GetComboGenders()
                
            };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ClientViewModel model)
        {
            if (ModelState.IsValid)
            {
                var client = new Client
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Height = model.Height,
                    Width = model.Width,
                    Gender = await dataContext.Genders.FirstOrDefaultAsync(m => m.Id == model.GenderId)
                };
                dataContext.Clients.Add(client);
                await dataContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(model);

        }
    }
}
