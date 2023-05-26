

using StudentRepository.Entities;

namespace StudentRepository.Repo;

public class Repository : IRepository
{
    private Student[] _students;
    private int _size;

    public Repository()
    {
        _students = new Student[2];
        _size = 0;
    }

    public void Add(Student entity)
    {
        if (this._size >= this._students.Length)
        {
            //mo rong mang _students
            Student[] temp = new Student[_size * 2];
            //di chuyen toan bo du lieu tu _students sang temp
            Array.Copy(_students, 0, temp, 0, this._size);
            this._students = temp;

        }
        this._students[this._size++] = entity;
    }

    public void Delete(Student entity)
    {
        Student s = Find(entity.Id);
        if (s != null)
        {
            //1. tim vi tri cua s
            int pos = _getPos(s);//lay vi tri can xoa

            for(int i = pos+1; i < _size; i++)
            {
                _students[i-1] = _students[i];
            }
            _students[--_size] = null;

        }

    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }
    private int _getPos(Student s)
    {
        for (int i = 0; i < _size; i++)
        {
            if (_students[i].Id.Equals(s.Id))
            {
                return i;
            }

        }
        return -1;

    }

    public Student Find(int id)
    {
        for(int i = 0; i < _size; i++)
        {
            if (_students[i].Id.Equals(id))
            {
                return _students[i];
            }
            
        }
        return null;
    }

    public Student[] GetAll()
    {
        return _students;
    }

    public void Update(Student entity)
    {
        throw new NotImplementedException();
    }

    public void Display()
    {
        foreach (Student student in _students)
        {
            Console.WriteLine(student);
        }
    }
}
