using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorreccionEj01
{
    interface IAttacker
    {
        int GetDamage();
        void RecieveDmg(int damage);
    }
}
