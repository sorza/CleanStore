using CleanStore.Domain.SharedContext.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanStore.Domain.AccountContext.Exceptions
{
    public class EmailNullOrEmptyException(string message) : DomainException(message);
}
