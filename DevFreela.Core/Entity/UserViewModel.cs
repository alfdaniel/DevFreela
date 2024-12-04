using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFreela.Core.Entity
{
    public class UserViewModel
    {
        public UserViewModel(string fullName, string email, DateTime birthDate, List<string> skills)
        {
            this.fullName = fullName;
            this.email = email;
            this.BirthDate = birthDate;
            this.Skills = skills;
        }

        public string fullName { get; private set; }
        public string email { get; private set; }
        public DateTime BirthDate { get; private set; }
        public List<string> Skills { get; private set; }

        public static UserViewModel FromEntity(User user)
        {
            var skills = user.Skills.Select(s => s.Skill.Description).ToList();

            return new UserViewModel(user.FullName, user.Email, user.BirthDate, skills);
        }
    }
}