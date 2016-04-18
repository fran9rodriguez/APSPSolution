using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NewShore.APSP.Common
{
    /// <summary>
    /// Class that implements the attributes of the method service answer
    /// </summary>
    public class QueryResultAsync: IAsyncResult
    {
        public object AsyncState
        {
            get;
            private set;
        }

        private ManualResetEvent _completed = new ManualResetEvent(false);

        public System.Threading.WaitHandle AsyncWaitHandle
        {
            get { return _completed; }
        }

        public bool CompletedSynchronously
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsCompleted
        {
            get { throw new NotImplementedException(); }
        }

        internal void Complete()
        {
            _completed.Set();
        }

        public QueryResultAsync(object asyncState)
        {
            this.AsyncState = asyncState;
        }

    }
}
