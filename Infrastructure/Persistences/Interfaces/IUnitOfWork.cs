namespace POS.Infrastructure.Persistences.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        //Declaración o matrícula de nuestras interfaces a nivel de repo
        ICategoryRepository Category {  get; }
        void SaveChanges();
        Task SaveChangesAsync();
    }
}
