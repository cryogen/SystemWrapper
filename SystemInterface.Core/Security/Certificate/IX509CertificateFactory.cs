﻿using System.Security.Cryptography.X509Certificates;

namespace SystemInterface.Core.Security.Certificate
{
    /// <summary>
    /// This interface wraps the X509Certificate creation in order to be mock-able.
    /// </summary>
    public interface IX509CertificateFactory
    {
        #region Public Methods and Operators

        /// <summary>
        /// Wraps the X509Certificate creation method.
        /// </summary>
        /// <param name="rawData">
        /// Byte array containing data from an X.509 certificate.
        /// </param>
        /// <param name="password">
        /// The password needed to access private key. Can be null if the certificate specified as bytes does not require password decryption.
        /// </param>
        /// <returns>
        /// The <see cref="IX509Certificate"/>.
        /// </returns>
        X509Certificate Create(byte[] rawData,
                               string password = null);

        #endregion
    }
}