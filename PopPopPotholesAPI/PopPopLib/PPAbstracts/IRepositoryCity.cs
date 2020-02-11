using System;
using System.Collections.Generic;
using System.Text;

namespace PopPopLib.PPAbstracts
{
    public interface IRepositoryCity<T>
    {
        IEnumerable<T> ReadInCity();
        void CreateCity(T City);
        void UpdateCity(T City);
        void DeleteCity(int Id);
    }
}
