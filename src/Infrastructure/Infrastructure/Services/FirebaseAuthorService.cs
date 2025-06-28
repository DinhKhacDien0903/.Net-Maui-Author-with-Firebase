using Application.Common.Interfaces;

namespace Infrastructure.Services;

public class FirebaseAuthorService() : IAuthorService
{
    public Task<(Result result, string UserId)> SignInAsync(string email, string password)
    {
        throw new NotImplementedException();
    }

    public Task<(Result result, string Token)> SignUpAsync(string email, string password)
    {
        throw new NotImplementedException();
    }
}