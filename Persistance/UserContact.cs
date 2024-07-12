using CarOnRentApi.Data;
using CarOnRentApi.Infrastructure;
using CarOnRentApi.Model.InputModel;
using CarOnRentApi.Model.ViewModel;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace CarOnRentApi.Persistance
{
    public class UserContact:IUserContact
    {
        public readonly DatabaseDbContext _databaseDb;
        public UserContact(DatabaseDbContext db)
        {
            _databaseDb = db;
        }
        public async Task<List<UserContactVM>> GetUserContact(UserContactIM userContact)
        {
            var param = new List<SqlParameter>();
            param.Add(new SqlParameter("@uname", userContact.uname));
            param.Add(new SqlParameter("@phone", userContact.phone));
            param.Add(new SqlParameter("@email", userContact.email));
            param.Add(new SqlParameter("@comment", userContact.comment));
            try
            {
                var r = await _databaseDb.userContactVMs.FromSqlRaw("EXEC AddUserContact @uname, @phone, @email, @comment",param.ToArray()).ToListAsync();
                return r;
            }
            catch { throw; }

        }
    }
}
