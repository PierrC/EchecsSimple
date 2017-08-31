using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopUpTesting
{
    class SupriseEvent
    {
        public event EventHandler Surprise;

        protected virtual void OnSurprise(EventArgs e)
        {
            EventHandler handler = Surprise;

            if(handler != null)
            {
                handler(this, e);
            }


        }


    }
}
