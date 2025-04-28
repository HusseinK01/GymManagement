using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Application.Common
{
    public interface IUnitOfWork
    {
        public Task CommitChangesAsync();
    }
}
