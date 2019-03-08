using System;
using System.Collections.Generic;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace System.Net.Security
{
    internal class SecureChannel
    {
        internal SslConnectionInfo ConnectionInfo => default;

        internal SslApplicationProtocol NegotiatedApplicationProtocol => default;

        internal ChannelBinding GetChannelBinding(ChannelBindingKind kind) => default;

        internal X509Certificate LocalClientCertificate => default;

        internal X509Certificate LocalServerCertificate => default;

        internal bool IsRemoteCertificateAvailable => default;

        internal bool IsServer => default;

        internal X509RevocationMode CheckCertRevocationStatus => default;

        internal bool IsValidContext => default;
    }
}
