using MediatR;

namespace Api.Application.UseCases.DeleteUser;

public sealed record DeleteUserRequest(Guid Id): IRequest<DeleteUserResponse>;
