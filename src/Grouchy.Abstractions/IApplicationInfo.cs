namespace Grouchy.Abstractions
{
   public interface IApplicationInfo
   {
      string Name { get; }
      
      string Version { get; }
      
      string Environment { get; }
      
      string OperatingSystem { get; }
   }
}