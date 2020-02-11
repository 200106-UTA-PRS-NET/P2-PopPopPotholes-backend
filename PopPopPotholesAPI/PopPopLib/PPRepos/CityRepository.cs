using System;
using System.Collections.Generic;
using System.Text;
using PopPopLib.UseModels;
using PopPopLib.PPAbstracts;

namespace PopPopLib.PPRepos
{
    class CityRepository : IRepositoryCity<CityAdmin1>
    {
        public CityRepository()
        {

        }



        public void CreateCity(CityAdmin1 City)
        {
            throw new NotImplementedException();
        }

        public void DeleteCity(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CityAdmin1> ReadInCity()
        {
            throw new NotImplementedException();
        }

        public void UpdateCity(CityAdmin1 City)
        {
            throw new NotImplementedException();
        }
    }
}
