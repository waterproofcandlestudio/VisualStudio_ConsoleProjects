/*
 *  Creador: Miguel Rodríguez Gallego
 *  Fecha: 25.enero.2021
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_MPOO_Miguel_RodríguezGallego
{
    interface IAttacker
    {
        int GetDmg();
        Character.CharacterType GetDmgType();
    }

    interface IDefender
    {
        void ReceiveDmg(int dmg, Character.CharacterType AttType);
    }
}
