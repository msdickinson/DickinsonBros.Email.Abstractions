using MimeKit;
using System.Threading.Tasks;

namespace DickinsonBros.Email.Abstractions
{
    public interface IEmailService
    {
        Task SendAsync(MimeMessage message);
    }
}
