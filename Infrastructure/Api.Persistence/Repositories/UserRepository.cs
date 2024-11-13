using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Api.Persistence.Repositories;

public class UserRepository : BaseRepository<User>, IUserRepository
{
    public UserRepository(AppDbContext context) : base(context)
    {}  

    public async Task<User> GetByEmail(string email, CancellationToken cancellationToken)
    {
        return await Context.Users.FirstOrDefaultAsync(x => x.Email == email, cancellationToken);
    }
}
