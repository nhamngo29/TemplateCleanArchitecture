using CleanArchitecture.Application.Abstractions.Messaging;
using CleanArchitecture.Application.Features.Todos.Get;

namespace CleanArchitecture.Application.Features.Todos.GetAll;

using Application.Abstractions.Messaging;
using Application.Features.Todos.Get;
using Domain.Common;

public sealed record GetAllTodosQuery(int Page = 1, int PageSize = 10) : IQuery<Result<PagedResult<TodoDetailResponse>>>;
