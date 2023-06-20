using StudentRepository.Entities;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;

namespace StudentRepository.Repository;

public class Repository: IRepository<Student>
{
    private LinkedList<Student> _students;
 

    public Repository()
    {
      this._students = new LinkedList<Student>();
    }

    public void Add(Student entity) 
        => this._students.AddFirst(entity);
    

    public void Delete(Student entity)  
        => this._students.Remove(entity);

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }
    
   
    public Student Find(int id)
    {
        return this._students.FirstOrDefault(x => x.Id==id);
    }

    public IEnumerable<Student> GetAll()
        => this._students;


   

    public void Update(Student entity)
    {
        this._students.Single(s=>s.Id==entity.Id).Name=entity.Name;
    }

    public void Display()
    {
        foreach (Student student in _students)
        {
            Console.WriteLine(student);
        }
    }

    public IEnumerable<Student> FindAll(double mark)
    {
        return this._students
            .Where(s => s.Mark >= mark)
            .OrderByDescending(s => s.Mark) //sorted
            .ToList();

            
    }

    public IEnumerable<Student> GetAll(Func<Student, bool> predicate)
    {
        return this._students
            .Where(predicate);
            

            
    }
}
