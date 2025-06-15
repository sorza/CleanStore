using CleanStore.Application.SharedContext.Specifications;
using CleanStore.Domain.AccountContext.Entities;
using System.Linq.Expressions;

namespace CleanStore.Application.AccountContext.UseCases.Get.Specifications
{
    public class GetByIdSpecification(Guid id) : ISpecification<Account>
    {       
        public Expression<Func<Account, bool>> Criteria { get; } = account => account.Id == id;

        public bool IsSatisfiedBy(Account entity)
            => entity.Id == id;
    }
}
