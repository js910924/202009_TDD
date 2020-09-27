using System.Collections.Generic;

namespace _202009_TDD.UnitTests
{
    public interface IBudgetRepository
    {
        public List<Budget> GetAll();
    }
}