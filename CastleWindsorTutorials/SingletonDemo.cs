using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleWindsorTutorials
{
    public class SingletonDemo : ISingletonDemo
    {
        public Guid ObjectId { get; }

        public SingletonDemo()
        {
            ObjectId = Guid.NewGuid();
        }
    }
}
