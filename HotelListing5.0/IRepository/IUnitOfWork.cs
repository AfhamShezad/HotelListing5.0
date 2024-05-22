using HotelListing5._0.Data;
using System;
using System.Threading.Tasks;

namespace HotelListing5._0.IRepository
{
    public interface IUnitOfWork : IDisposable
    {

        IGenericRepository<Country> Countries { get;}
        IGenericRepository<Hotel> Hotels { get;}

        Task Save();
    }
}
