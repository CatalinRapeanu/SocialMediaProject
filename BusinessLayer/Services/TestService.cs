using BusinessLayer.Contracts;
using DataAccessLayer.Models;
using DataAccessLayer.Repository;

namespace BusinessLayer.Services
{
    public class TestService : ITestService
    {
        private readonly IRepository<TestModel> _repository;

        public TestService(IRepository<TestModel> repository)
        {
            _repository = repository;
        }

        public int CountRecords()
        {
            return _repository.GetAll().Count();
        }
    }
}
