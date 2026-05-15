using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_DZ_24._04
{
    readonly struct CategoryInfo
    {
        public readonly string Name;
        public readonly int Code;

        public CategoryInfo(string name, int code)
        {
            Name = name;
            Code = code;
        }

        public override string ToString()
        {
            return $"{Name} ({Code})";
        }
    }
    // readonly делает ее неизменяемой, а структуры не поддерживают наследование
}
