using MediatR;

namespace Ordering.Application.Behaviours
{
    public interface ICommand<out TResponse> : IRequest<TResponse>
    {
    }
}