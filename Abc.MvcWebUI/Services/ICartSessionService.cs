using Abc.Entities.Concrete;

namespace Abc.MvcWebUI.Services
{
    public interface ICartSessionService
    {
        Cart GetCart();
        void SertCart(Cart cart);
    }
}