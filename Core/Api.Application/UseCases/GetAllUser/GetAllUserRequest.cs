using MediatR;

namespace Api.Application.UseCases.GetAllUser;

public sealed record GetAllUserRequest : IRequest<List<GetAllUserResponse>>;
