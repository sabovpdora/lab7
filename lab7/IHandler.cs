 using System;
using System.Collections.Generic;
using System.Text;

namespace lab7
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        float Handle(float request);
        void Block();
    }
}
