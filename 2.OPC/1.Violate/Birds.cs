using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPC.Violate
{
    public static class Birds
    {
        public static void Add(object[] Birds)
        {
           foreach(var i in Birds)
            {
                
                if (i.GetType().IsInstanceOfType(new Duck()))
                {
                    ((Duck)i).Fly();
                    ((Duck)i).Jump();
                    ((Duck)i).Walk();
                }

                if (i.GetType().IsInstanceOfType(new Pigeon()))
                {   
                    ((Pigeon)i).Jump();
                    ((Pigeon)i).Walk();
                }

                if (i.GetType().IsInstanceOfType(new Eagle()))
                {
                    ((Eagle)i).Fly();
                    ((Eagle)i).Jump();
                    ((Eagle)i).Walk();
                } 
                /// Si deseamos agregar mas tendriamos que modificar esta clase,
                /// y al modificarla estamos rompiendo el princio.
                /// ..
                /// ..
            }
        }

        
        
    }
}
