namespace Fortuna.Adapter.Repositories
{
    public class BaseRepository<T> : FortunaBaseRepository
    {
        
        
        protected BaseRepository()
        {
            using (var container = new FortunaEntities())
            {
                
            }
        }

        //public T Find(Object id)
        //{
        //    if (id == null) throw new ArgumentException("id not set.");
        //    return ;
        //}
    }
}
