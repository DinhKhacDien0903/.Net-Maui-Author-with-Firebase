using Domain.Common;
using Domain.Entities;

namespace Domain.Events;

public class UserCreatedEvent(UserEntity user) : BaseEvent
{
    public UserEntity User { get; } = user;
}