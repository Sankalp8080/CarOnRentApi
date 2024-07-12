using CarOnRentApi.Model.InputModel;
using CarOnRentApi.Model.ViewModel;

namespace CarOnRentApi.Infrastructure
{
    public interface IUserContact
    {
        public Task<List<UserContactVM>> GetUserContact(UserContactIM userContact);
    }
}
