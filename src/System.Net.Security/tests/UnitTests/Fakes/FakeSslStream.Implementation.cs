using System;
using System.Collections.Generic;
using System.IO;
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
            _nestedWrite = 0;
            _internalOffset = 0;
            _internalBuffer = new byte[0];
            _internalBufferCount = 0;
            _handshakeCompleted = true;
            if(_internalOffset == 0 && _internalBufferCount == 0 && _internalBuffer.Length == 0 && _nestedWrite == 0)
            {
            }
        }

        private void CheckThrow(bool authSuccessCheck, bool shutdownCheck = false)
        {
        }

        internal Stream InternalInnerStream => default;

        private void ReturnReadBufferIfEmpty()
        {
        }

        public bool IsShutdown { get; internal set; }

        internal void CheckEnqueueWrite()
        {
        }

        public void CloseInternal()
        {
        }

        internal void EndProcessAuthentication(IAsyncResult result)
        {
        }

        internal void ValidateCreateContext(SslClientAuthenticationOptions sslClientAuthenticationOptions, RemoteCertValidationCallback remoteCallback, LocalCertSelectionCallback localCallback)
        {
        }

        private ValueTask WriteAsyncInternal<TWriteAdapter>(TWriteAdapter writeAdapter, ReadOnlyMemory<byte> buffer)
            where TWriteAdapter : struct, ISslWriteAdapter => default;

        internal IAsyncResult BeginReadInternal(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) => default;

        private ValueTask<int> ReadAsyncInternal<TReadAdapter>(TReadAdapter adapter, Memory<byte> buffer)
            where TReadAdapter : ISslReadAdapter => default;

        internal IAsyncResult BeginWriteInternal(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) => default;

        internal int ReadInternal(byte[] buffer, int offset, int count) => default;

        internal int EndReadInternal(IAsyncResult asyncResult) => default;

        internal int CheckEnqueueRead(Memory<byte> buffer) => default;

        internal ValueTask<int> CheckEnqueueReadAsync(Memory<byte> buffer) => default;

        internal Task CheckEnqueueWriteAsync() => default;

        private void ValidateParameters(byte[] buffer, int offset, int count)
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
