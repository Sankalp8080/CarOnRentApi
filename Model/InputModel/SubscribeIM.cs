using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CarOnRentApi.Model.InputModel
{
    [Keyless]
    public class SubscribeIM
    {
        public string? email { get; set; }
    }


}
