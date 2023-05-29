using WebApplication2.repository;

namespace WebApplication2.service
{

    public interface IService<T>
    {
        T Get(int id);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);

    }

    public class Service<T> : IService<T>
    {
        private readonly IRepository<T> _repository;

        public Service(IRepository<T> repository)
        {
            _repository = repository;
        }

        public T Get(int id)
        {
            return _repository.GetById(id);
        }

        public void Create(T entity)
        {
            _repository.Add(entity);
        }

        public void Update(T entity)
        {
            _repository.Update(entity);
        }

        public void Delete(T entity)
        {
            _repository.Delete(entity);
        }

    }
}
