using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lja.quittung.Business
{
    public abstract class BaseController<T>
    {
        public T View;

        public BaseController(T view)
        {
            View = view;
        }

        public abstract void SubscribeEvents();

        public abstract void UnsubscribeEvents();
    }
    
}
