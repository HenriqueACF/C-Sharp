namespace App.Interfaces.InterfaceGenerics;

public interface IGenericApp<T> where T : class
{
    Task Add(T Obj);
    Task Update(T Obj);
    Task Delete(T Obj);
    Task<T> GetEntityById(int id);
    Task<List<T>> List();
}