namespace BookStore.Models.Repositories
{
    public interface IBookstoreRepository <TEntity>
    {
        IList<TEntity> List();
        TEntity Find(int id);
        void Add(TEntity entity);
        void Update(int Id,TEntity entity);
        void Delete(int id);
    }
}
