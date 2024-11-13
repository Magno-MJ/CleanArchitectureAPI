using MediatR;

namespace Api.Application.UseCases.UpdateUser;

public sealed record UpdateUserRequest(Guid Id,string Email, string Name) : IRequest<UpdateUserResponse>;
