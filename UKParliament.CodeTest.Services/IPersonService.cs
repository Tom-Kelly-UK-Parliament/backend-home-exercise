using System;
using System.Threading.Tasks;
using UKParliament.CodeTest.Services.Models;

namespace UKParliament.CodeTest.Services
{
    public interface IPersonService
    {
        Task<PersonInfo> GetAsync(int personId);
    }

    public class PersonService : IPersonService
    {
        public PersonService()
        {
            
        }

        public async Task<PersonInfo> GetAsync(int personId)
        {
            throw new NotImplementedException();
        }
    }
}