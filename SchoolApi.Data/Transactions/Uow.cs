using System.Threading.Tasks;
using SchoolApi.Data.Interfaces;
using SchoolApi.Data.Repositories;

namespace SchoolApi.Data.Transactions
{
    public class Uow : IUow
    {
        public IStudentRepository Students { get; }

        private readonly ApplicationDbContext _context;

        public Uow(ApplicationDbContext context)
        {
            _context = context;

            Students = new StudentRepository(context);
        }

        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }

        public async void Dispose()
        {
            await Disposing(true);
        }

        protected virtual async Task Disposing(bool active)
        {
            if(active)
            {
                await _context.DisposeAsync();
            }
        }
    }
}