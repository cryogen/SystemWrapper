using System;
using System.IO;
using System.Security;

namespace SystemInterface.Core
{
    /// <summary>
    /// Provides information about, and means to manipulate, the current environment and platform.
    /// </summary>
    /// <remarks>
    /// This interface represents the <see cref="Environment"/> class.
    /// </remarks>
    public interface IEnvironment
    {
#if NET45

        /// <summary>
        /// Gets a unique identifier for the current managed thread.
        /// </summary>
        /// <value>
        /// An integer that represents a unique identifier for this managed thread.
        /// </value>
        int CurrentManagedThreadId { get; }

#endif
        /// <summary>
        /// Gets a value that indicates whether the current application
        /// domain is being unloaded or the common language runtime
        /// (CLR) is shutting down.
        /// </summary>
        /// <value>
        /// <c>true</c> if the current application domain is being unloaded or the CLR is shutting down; otherwise, false.
        /// </value>
        /// <remarks>
        /// <para>When the CLR unloads an application domain, it runs the finalizers on all objects
        ///   that have a finalizer method in that application domain. When the CLR shuts down, it starts
        ///   the finalizer thread on all objects that have a finalizer method. The HasShutdownStarted
        ///   property returns true only after the finalizer thread has been started. When the property
        ///   returns true, you can determine whether an application domain is being unloaded or the CLR
        ///   itself is shutting down by calling the <see cref="AppDomain.IsFinalizingForUnload"/> method.
        ///   This method returns true if finalizers are called because the application domain is unloading
        ///   or false if the CLR is shutting down.</para>
        /// <para>The HasShutdownStarted property returns false if the finalizer thread has not been started.</para>
        /// <para>By using this property, you can determine whether to access static variables in your
        ///   finalization code. If either an application domain or the CLR is shutting down, you
        ///   cannot reliably access any object that has a finalization method and that is referenced
        ///   by a static field. This is because these objects may have already been finalized.</para>
        /// </remarks>
        bool HasShutdownStarted { get; }

        /// <summary>
        /// Gets the NetBIOS name of this local computer.
        /// </summary>
        /// <value>
        /// A string containing the name of this computer.
        /// </value>
        /// <exception cref="InvalidOperationException">The name of this computer cannot be obtained.</exception>
        /// <remarks>
        /// The name of this computer is established at system startup when the name is read from the registry. If this computer is a node in a cluster, the name of the node is returned.
        /// </remarks>
        /// <permission cref="EnvironmentPermission">
        /// For read access to the COMPUTERNAME environment variable. Associated enumeration: <see cref="EnvironmentPermissionAccess.Read"/>.
        /// </permission>
        string MachineName { get; }

        /// <summary>
        /// Gets the newline string defined for this environment.
        /// </summary>
        /// <value>
        /// A string containing "\r\n" for non-Unix platforms, or a string containing "\n" for Unix platforms.
        /// </value>
        /// <remarks>
        /// <para>The property value of NewLine is a constant customized specifically for the current platform
        ///   and implementation of the .NET Framework. For more information about the escape characters
        ///   in the property value, see Character Escapes in Regular Expressions.</para>
        /// <para>The functionality provided by NewLine is often what is meant by the terms newline,
        ///   line feed, line break, carriage return, CRLF, and end of line.</para>
        /// <para>NewLine can be used in conjunction with language-specific newline support such as the
        ///   escape characters '\r' and '\n' in Microsoft C# and C/C++, or vbCrLf in Microsoft Visual Basic.</para>
        /// <para>NewLine is automatically appended to text processed by the Console.WriteLine and StringBuilder.AppendLine methods.</para>
        /// </remarks>
        string NewLine { get; }

        /// <summary>
        /// Gets the number of processors on the current machine.
        /// </summary>
        /// <value>
        /// The 32-bit signed integer that specifies the number of processors on the
        /// current machine. There is no default. If the current machine contains multiple
        /// processor groups, this property returns the number of logical processors that are
        /// available for use by the common language runtime (CLR).
        /// </value>
        /// <remarks>
        /// For more information about processor groups and logical processors, see Processor Groups.
        /// </remarks>
        int ProcessorCount { get; }

        /// <summary>
        /// Gets current stack trace information.
        /// </summary>
        /// <value>
        /// A string containing stack trace information. This value can be <see cref="String.Empty"/>.
        /// </value>
        /// <exception cref="ArgumentOutOfRangeException">The requested stack trace information is out of range.</exception>
        string StackTrace { get; }

        /// <summary>
        /// Gets the number of milliseconds elapsed since the system started.
        /// </summary>
        /// <value>
        /// A 32-bit signed integer containing the amount of time in milliseconds that has passed since the last time the computer was started.
        /// </value>
        /// <remarks>
        /// <para>The value of this property is derived from the system timer and is stored as a 32-bit signed integer.
        ///   Consequently, if the system runs continuously, TickCount will increment from zero to Int32.MaxValue for
        ///   approximately 24.9 days, then jump to Int32.MinValue, which is a negative number, then increment back
        ///   to zero during the next 24.9 days.</para>
        /// <para>TickCount is different from the Ticks property, which is the number of 100-nanosecond intervals that
        ///   have elapsed since 1/1/0001, 12:00am.</para>
        /// <para>Use the DateTime.Now property to obtain the current local date and time on this computer.</para>
        /// </remarks>
        int TickCount { get; }
    }
}
