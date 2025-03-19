using WebApplication1.Data_Access.context;
using WebApplication1.Entities.Repositories;

namespace WebApplication1.Data_Access.RepositoryImplementation
{
    public class UnitOfWork : IUnitOfWork {
        private readonly ApplicationDbContext context;
  
        public ICourseRepository CourseRepository{ get; private set; }

     

        public IStudentRepository StudentRepository { get; private set; }


        public UnitOfWork(ApplicationDbContext context) {
            this.context = context;

            this.CourseRepository = new CourseRepository(this.context);
        
            this.StudentRepository = new StudentRepository(this.context);
        }
        public async Task<int> CompleteAsync()
        {
            return await context.SaveChangesAsync();
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public async ValueTask DisposeAsync()
        {
            await context.DisposeAsync();
        }
    }
}
