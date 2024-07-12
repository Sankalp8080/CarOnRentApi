using Microsoft.EntityFrameworkCore;

namespace CarOnRentApi.Model.InputModel
{
    [Keyless]
    public class UserContactIM
    {
        public string? uname { get; set; }
        public string? email { get; set; }
        public string? phone { get; set; }
        public string? comment { get; set; }
    }
}
