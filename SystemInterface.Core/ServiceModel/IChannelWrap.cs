using System;

namespace SystemInterface.Core.ServiceModel
{
    /// <summary>
    ///     This interface wraps a WCF channel and gives a link with the disposable interface.
    /// </summary>
    public interface IChannelWrap<TService> : IDisposable
    {
        #region Public Properties

        /// <summary>
        ///     Gets the channel service.
        /// </summary>
        TService Service { get; }

        #endregion
    }
}