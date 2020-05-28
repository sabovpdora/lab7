 using System;
using System.Collections.Generic;
using System.Text;

namespace lab7
{
    abstract class AbsHandler : IHandler
    {
        private IHandler _nextHandler;
        public virtual float Handle(float request)
        {
            if (this._nextHandler != null)
                return this._nextHandler.Handle(request);
            else
                return request;
        }

        public IHandler SetNext(IHandler handler)
        {
            this._nextHandler = handler;
            return handler;
        }
    }
}
