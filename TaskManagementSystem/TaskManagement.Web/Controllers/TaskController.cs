using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskManagement.Web.Data;


namespace TaskManagement.Web.Controllers
{
    public class TaskController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public TaskController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult Index()
        {
            List<Task> tasks = _dbContext.Tasks.ToList();
            
            return View(tasks);
        }
    }
}
