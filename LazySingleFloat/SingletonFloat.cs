using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LazySingleFloat
{
    public sealed class SingletonFloat
    {

        private static readonly Lazy<SingletonFloat> instance =
            new Lazy<SingletonFloat>(() => new SingletonFloat());

        public static SingletonFloat Instance => instance.Value;

        public float Number { get; set; }

        private SingletonFloat(){   }

        
    }
}