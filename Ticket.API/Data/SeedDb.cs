using Ticket.Shared.Entities;

namespace Ticket.API.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;
        public SeedDb(DataContext context) 
        {
            _context= context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckTicketsAsync();
        }

        private async Task CheckTicketsAsync()
        {
            if (!_context.Tickets.Any())
            {

                for (int i = 0; i < 50000; i++)
                {
                    _context.Tickets.Add(new Shared.Entities.Ticket
                    {
                        Date = null,
                        Used = false,
                        Zone = null
                    });
                }
                
                await _context.SaveChangesAsync();
            }
        }
    }
}
