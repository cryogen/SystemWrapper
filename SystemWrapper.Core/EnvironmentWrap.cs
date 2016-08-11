using System;
using SystemInterface.Core;

namespace SystemWrapper.Core
{
    /// <summary>
    /// Provides information about, and means to manipulate, the current environment and platform.
    /// </summary>
    /// <remarks>
    /// This class provides default implementation using the <see cref="Environment"/> static class.
    /// </remarks>
    public class EnvironmentWrap : IEnvironment
    {
#if NET45

        public int CurrentManagedThreadId
        {
            get { return Environment.CurrentManagedThreadId; }
        }

#endif

        public bool HasShutdownStarted => Environment.HasShutdownStarted;

        public string MachineName => Environment.MachineName;

        public string NewLine => Environment.NewLine;

        public int ProcessorCount => Environment.ProcessorCount;

        public string StackTrace => Environment.StackTrace;

        public int TickCount => Environment.TickCount;
    }
}
