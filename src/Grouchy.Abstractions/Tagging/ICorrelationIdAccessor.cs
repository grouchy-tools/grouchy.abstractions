namespace Grouchy.Abstractions.Tagging
{
   public interface ICorrelationIdAccessor
   {
      string CorrelationId { get; }
   }
}