using GeekShopping.Email.Messages;

namespace GeekShopping.OrderAPI.Repository
{
    public interface IEmailRepository
    {
        Task LogEmail(UpdatePaymentResultMessage message);
    }
}
