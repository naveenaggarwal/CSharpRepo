using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class EarlySingleton
    {
        private static EarlySingleton singletonInstance = new EarlySingleton();

        private EarlySingleton()
        {
        }

        public EarlySingleton getInstance()
        {
            return singletonInstance;
        }        
    }
}
