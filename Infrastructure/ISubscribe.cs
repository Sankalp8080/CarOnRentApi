using CarOnRentApi.Model.InputModel;
using CarOnRentApi.Model.ViewModel;

namespace CarOnRentApi.Infrastructure
{
    public interface ISubscribe
    {
        public Task<List<SubscribeVM>> GetSubscribeStatus(SubscribeIM sim);
    }
}
