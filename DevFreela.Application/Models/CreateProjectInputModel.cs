
using DevFreela.Core.Entity;

namespace DevFreela.Application.Models
{
    public class CreateProjectInputModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int IdClient { get; set; }
        public int IdFreelancer { get; set; }
        public decimal TotalCost { get; set; }

        public CreateProjectInputModel() { }

        public Project ToEntity() => new Project(Title, Description, IdClient, IdFreelancer, TotalCost);
    }
}
