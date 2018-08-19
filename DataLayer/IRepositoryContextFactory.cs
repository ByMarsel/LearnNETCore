namespace DataLayer
{
    public interface IRepositoryContextFactory
    {
        RepositoryContext CreateDbContext(string connectionString);
    }
}