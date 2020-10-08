using MimeKit;
using System.Threading.Tasks;

namespace DickinsonBros.Email.Abstractions
{
    public interface IEmailService
    {
        Task SendAsync(MimeMessage message);
        Task<bool> ValidateEmailDomain(string emailDomain);
        bool IsValidEmailFormat(string email);
    }
}
