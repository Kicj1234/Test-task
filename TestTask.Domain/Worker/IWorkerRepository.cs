using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Aspose.Domain.Worker
{
    public interface IWorkerRepository
    {
        Task<Worker> GetById(Guid id);
        Task<ICollection<Worker>> GetAll();
        Task Add(Worker worker);
    }
}
