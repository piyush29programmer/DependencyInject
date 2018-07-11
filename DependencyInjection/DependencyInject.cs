using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class DependencyInject
    {
        private IAnimal obj;
        public DependencyInject(IAnimal obj)
        {
            this.obj = obj;
        }

        public void print() 
        {
            obj.print();
        }
    }
}
