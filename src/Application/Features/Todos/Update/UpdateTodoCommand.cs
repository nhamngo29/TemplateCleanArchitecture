using CleanArchitecture.Application.Abstractions.Messaging;

namespace CleanArchitecture.Application.Features.Todos.Update;

using Application.Abstractions.Messaging;
using Domain.Common;

public sealed record UpdateTodoCommand(Guid Id, string Title, string? Description) : ICommand;
