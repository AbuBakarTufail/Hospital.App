﻿using Hospital.Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Library.Repository
{
    public interface ICountry
    {
        public Task<List<Country>> GetCountries();
        public Task<Country?> GetCountry(int countryId);
        public Task<bool> SaveCountry(Country country);
        public Task<bool> DeleteCountry(int countryId);        
        public Task<bool> DeleteCountries(List<int> countryIds);
    }
}
