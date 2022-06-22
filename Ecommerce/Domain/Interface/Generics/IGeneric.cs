namespace Domain.Interface.Generics;

public interface IGeneric<T> where T: class
{
    Task Add(T obj);
    Task Update(T obj);
    Task Delete(T obj);
    Task<List<T>> List();
}