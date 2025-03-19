namespace WebApplication1.Entities.Repositories
{
    public interface IUnitOfWork : IDisposable, IAsyncDisposable
    {
        Task<int> CompleteAsync();
    
        ICourseRepository CourseRepository { get; }

        IStudentRepository StudentRepository { get; }
        
    }
}
