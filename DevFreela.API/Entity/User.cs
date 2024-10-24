using DevFreela.API.Enuns;

namespace DevFreela.API.Entity
{
    public class User : BaseEntity
    {
        public User(string fullName, string email, DateTime birthDate) : base()
        {
            FullName = fullName;
            Email = email;
            BirthDate = birthDate;
            Active = true;

            Skills = [];
            OwnedProjects = [];
            FreelanceProjects = [];
        }
        public string FullName { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }
        public bool Active { get; private set; }  

        public List<UserSkill> Skills { get; private set; }
        public List<Project> OwnedProjects { get; private set; }
        public List<Project> FreelanceProjects { get; private set; }
        public List<ProjectComments> Comments { get; private set; }

    }
}