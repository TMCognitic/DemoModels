namespace DemoCqs.Domain.Abstractions
{
    public interface ICommandHandler<TCommand>
        where TCommand : ICommandDefinition
    {
        bool Execute(TCommand command);
    }
}
