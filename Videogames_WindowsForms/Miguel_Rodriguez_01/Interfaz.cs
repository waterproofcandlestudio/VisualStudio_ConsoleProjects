/*
 *  Creador: Miguel Rodríguez Gallego
 *  Fecha: 25.enero.2021
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miguel_Rodriguez_01
{
    interface IAttacker
    {
        int GetDmg();
        Character.CharacterType GetDmgType();
        void ReceiveDmg(int dmg, Character.CharacterType AttType);
    }
}
