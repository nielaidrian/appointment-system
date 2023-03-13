namespace SbcCapstone.Contracts
{
    public interface IBaseRepositoryUser<TEntity>
    {
        Task Create(TEntity t);
        Task GetOne(object id);
        Task<IEnumerable<TEntity>> GetAll();
        Task Update(object id, object model);
        Task Delete(object id);
    }

  
}