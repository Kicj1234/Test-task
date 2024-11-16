using TestTask.Domain.Worker;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Infrastructure.InMemoryAccess.Repositories
{
    public class WorkerRepository : IWorkerRepository
    {
        private InMemoryContext _context;
        public WorkerRepository(InMemoryContext context)
        {
            this._context = context;
        }

        public async Task Add(Worker worker)
        {
            _context.Workers.Add(worker);
        }

        public async Task<ICollection<Worker>> GetAll()
        {
            return this._context.Workers;
        }

        public async Task<Worker> GetById(Guid id)
        {
            return _context.Workers.FirstOrDefault(x => x.Id == id);
        }
    }
}
