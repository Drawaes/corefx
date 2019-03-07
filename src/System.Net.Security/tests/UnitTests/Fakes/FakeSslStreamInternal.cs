using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.Security
{
    internal class SslStreamInternal
    {
        internal SslStreamInternal(object obj)
        {
        }

        internal int Read(byte[] buffer, int offset, int count) => default;

        internal void Write(byte[] buffer, int offset, int count)
        {
        }

        internal ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken) => default;

        internal Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) => default;

        internal int ReadByte() => default;

        internal IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) => default;

        internal int EndRead(IAsyncResult asyncResult) => default;

        internal IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) => default;

        internal void EndWrite(IAsyncResult asyncResult)
        {
        }

        internal ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken) => default;

        internal Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) => default;
    }
}
