using System.Reflection;

namespace SystemWrapper.Core
{
    public static class SystemWrapperHelpers
    {
        public static IAssemblyName ToInterface(this AssemblyName assemblyName)
        {
            return new AssemblyNameWrap(assemblyName);
        }
    }
}
