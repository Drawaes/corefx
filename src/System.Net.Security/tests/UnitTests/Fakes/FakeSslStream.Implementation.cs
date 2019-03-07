using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.Security
{
    public partial class SslStream
    {
        private SecureChannel _context;

        private void ProcessAuthentication(LazyAsyncResult lazyResult)
        {
            // Stops build error from never assigning to these values
            _context = new SecureChannel();
            _exception = null;
        }

        private void CheckThrow(bool authSuccessCheck, bool shutdownCheck = false)
        {
        }

        private SecureChannel Context => default;

        public bool IsShutdown { get; internal set; }

        public void CloseInternal()
        {
        }

        internal void EndProcessAuthentication(IAsyncResult result)
        {
        }

        internal void ValidateCreateContext(SslClientAuthenticationOptions sslClientAuthenticationOptions, RemoteCertValidationCallback remoteCallback, LocalCertSelectionCallback localCallback)
        {
        }

        internal void ValidateCreateContext(SslAuthenticationOptions sslAuthenticationOptions)
        {
        }

        internal IAsyncResult BeginShutdownInternal(AsyncCallback asyncCallback, object asyncState) => default;

        internal void EndShutdownInternal(IAsyncResult result)
        {
            _shutdown = true;
        }

        internal bool RemoteCertRequired
        {
            get
            {
                return false;
            }
        }
                
        private bool HandshakeCompleted => default;
    }
}
