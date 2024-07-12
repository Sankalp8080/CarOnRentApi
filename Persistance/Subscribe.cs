using CarOnRentApi.Data;
using CarOnRentApi.Infrastructure;
using CarOnRentApi.Model.InputModel;
using CarOnRentApi.Model.ViewModel;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace CarOnRentApi.Persistance
{
    public class Subscribe : ISubscribe
    {
        private readonly DatabaseDbContext _dbContext;
        public Subscribe(DatabaseDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<SubscribeVM>> GetSubscribeStatus(SubscribeIM sim)
        {
            var param = new SqlParameter("@email", sim.email ?? (object)DBNull.Value);
            try
            {
                var r = await _dbContext.subscribeVMs
                    .FromSqlRaw("EXEC GetSubscribe @Email", param)
                    .ToListAsync();
                return r;
            }
            catch (Exception ex)
            { 
                throw;
            }
        }
    }
}
