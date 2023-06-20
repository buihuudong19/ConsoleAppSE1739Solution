using StudentRepository.Entities;
using System.Linq.Expressions;

namespace StudentRepository.Repository;

public interface IRepository<T> where T : class
{
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
    void Delete(int id);

    IEnumerable<T> GetAll();
    T Find(int id);
    void Display();
    IEnumerable<T> FindAll(double mark); //return all student ma diem >=7
    IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate);

}