using DevFreela.Application.Models;
using DevFreela.Infrastructure.Persistence;

namespace DevFreela.Application.Services
{
    public interface IProjectServices
    {
        ResultViewModel<List<ProjectItemViewModel>> GetAll(string search = "");
        ResultViewModel<ProjectViewModel> GetById();
        ResultViewModel<int> Insert(CreateProjectInputModel model);
        ResultViewModel Update(UpdateProjectInputModel model);
        ResultViewModel Delete(int id);
        ResultViewModel Start(int id);
        ResultViewModel Complete(int id);
        ResultViewModel InsertComment(int id, CreateProjecCommentInputModel model);
    }

    public class ProjectsService : IProjectServices
    {

        private readonly DevFreelaDbContext _context;
        public ProjectsService(DevFreelaDbContext context)
        {
            _context = context;
        }
        public ResultViewModel Complete(int id)
        {
            throw new NotImplementedException();
        }

        public ResultViewModel Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ResultViewModel<List<ProjectItemViewModel>> GetAll(string search = "")
        {
            throw new NotImplementedException();
        }

        public ResultViewModel<ProjectViewModel> GetById()
        {
            
            throw new NotImplementedException();
        }

        public ResultViewModel<int> Insert(CreateProjectInputModel model)
        {
            throw new NotImplementedException();
        }

        public ResultViewModel InsertComment(int id, CreateProjecCommentInputModel model)
        {
            throw new NotImplementedException();
        }

        public ResultViewModel Start(int id)
        {
            throw new NotImplementedException();
        }

        public ResultViewModel Update(UpdateProjectInputModel model)
        {
            throw new NotImplementedException();
        }
    }

}