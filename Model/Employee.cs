using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncFluentValidation.Model
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Gender { get; set; }
        public decimal? Experience { get; set; }
        public string EmailAddress { get; set; }
        public PermanentAddress PermanentAddress { get; } = new PermanentAddress();
    }
    public class PermanentAddress
    {
        public string AddressLine1 { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
    }

    public class Countries
    {
        public string Name { get; set; }
        public string Code { get; set; }

        public List<Countries> GetCountries()
        {
            List<Countries> Country = new List<Countries>
            {
                new Countries() { Name = "Australia", Code = "AU" },
                new Countries() { Name = "United Kingdom", Code = "UK" },
                new Countries() { Name = "United States", Code = "US" },
            };
            return Country;
        }
    }
    public class Cities
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string CountryCode { get; set; }
        public List<Cities> GetCities()
        {
            List<Cities> CityName = new List<Cities>
            {
                new Cities() { Name = "New York", CountryCode = "US", Code="US-101" },
                new Cities() { Name = "Virginia", CountryCode = "US", Code="US-102" },
                new Cities() { Name = "Washington", CountryCode = "US", Code="US-103" },
                new Cities() { Name = "Victoria", CountryCode = "AU", Code="AU-101" },
                new Cities() { Name = "Tasmania", CountryCode = "AU", Code="AU-102" },
                new Cities() { Name = "Queensland", CountryCode = "AU", Code="AU-103" },
                new Cities() { Name = "London", CountryCode = "UK", Code="UK-101" },
                new Cities() { Name = "Manchester", CountryCode = "UK", Code="UK-102" },
                new Cities() { Name = "Ashford", CountryCode = "UK", Code="UK-103" }
            };
            return CityName;
        }
    }
}
