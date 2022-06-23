using System.Runtime.InteropServices;
using Domain.Interface.Generics;
using Infra.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32.SafeHandles;

namespace Infra.Repository.Generics;

public class RepositoryGeneric<T>: IGeneric<T>, IDisposable where T: class
{
    private readonly DbContextOptions<ContextBase> _OptionsBuilder;
    public RepositoryGeneric()
    {
        _OptionsBuilder = new DbContextOptions<ContextBase>();
    }       
    public async Task Add(T obj)
    {
        using (var data = new ContextBase(_OptionsBuilder))
        {
            await data.Set<T>().AddAsync(obj);
            await data.SaveChangesAsync();
        }    
    }

    public async Task Update(T obj)
    {
        using (var data = new ContextBase(_OptionsBuilder))
        {
            data.Set<T>().Update(obj);
            await data.SaveChangesAsync();
        } 
    }

    public async Task Delete(T obj)
    {
        using (var data = new ContextBase(_OptionsBuilder))
        {
            data.Set<T>().Remove(obj);
            await data.SaveChangesAsync();
        } 
    }

    public async Task<T> GetEntityById(int id)
    {
        using (var data = new ContextBase(_OptionsBuilder))
        {
            return await data.Set<T>().FindAsync(id);   
        }
    }

    public async Task<List<T>> List()
    {
        using (var data = new ContextBase(_OptionsBuilder))
        {
            return await data.Set<T>().AsNoTracking().ToListAsync();
        }
    }

    #region Disposed https://docs.microsoft.com/pt-br/dotnet/standard/garbage-collection/implementing-dispose
    // Flag: Has Dispose already been called?
    bool disposed = false;
    // Instantiate a SafeHandle instance.
    SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);



    // Public implementation of Dispose pattern callable by consumers.
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }


    // Protected implementation of Dispose pattern.
    protected virtual void Dispose(bool disposing)
    {
        if (disposed)
            return;

        if (disposing)
        {
            handle.Dispose();
            // Free any other managed objects here.
            //
        }

        disposed = true;
    }
    #endregion

}