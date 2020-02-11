using System;
using System.Collections.Generic;
using System.Text;

namespace PopPopLib.PPAbstracts
{
    public interface IRepositoryCityAdmin<T>
    {
        IEnumerable<T> ReadInCityAdmin();
        void CreateCityAdmin(T Admin);
        void UpdateCityAdmin(T Admin);
        void DeleteCityAdmin(int Id);
    }
}
