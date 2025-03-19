using WebApplication1.Data_Access.context;
using WebApplication1.Entities.Models;
using WebApplication1.Entities.Repositories;

namespace WebApplication1.Data_Access.RepositoryImplementation
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        private readonly ApplicationDbContext context;
        public StudentRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }
    }
}
