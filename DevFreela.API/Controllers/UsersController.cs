
using DevFreela.Application.Models;
using DevFreela.Core.Entity;
using DevFreela.Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DevFreela.API.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        private readonly DevFreelaDbContext _context;

        public UsersController(DevFreelaDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var user = _context.Users.Include(u => u.Skills).ThenInclude(u => u.Skill).SingleOrDefault(u => u.Id == id);

            if (user == null)
            {
                return NotFound();
            }

            var userViewModel = UserViewModel.FromEntity(user);
            return Ok(userViewModel);
        }    

        [HttpPost]
        public IActionResult Post(CreateUserInputModel model)
        {
            var user = new User(model.FullName, model.Email, model.BirthDate);

            _context.Users.Add(user);
            _context.SaveChanges();
            return Ok();
        }

        [HttpPost("{id}/skills")]
        public IActionResult PostSkill(int id, UserSkillsInputModel model)
        {
            var userSkill = model.SkillIds.Select(s => new UserSkill(id, s)).ToList();

            _context.UserSkills.AddRange(userSkill);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpPut("{id}/profile-picture")]
        public IActionResult PostProfilePicture(int id, IFormFile file)
        {
            var user = _context.Users.SingleOrDefault(u => u.Id == id);
            var description = $"File: {file.FileName}, Size: {file.Length}";

            return Ok(description);
        }
    }
}
