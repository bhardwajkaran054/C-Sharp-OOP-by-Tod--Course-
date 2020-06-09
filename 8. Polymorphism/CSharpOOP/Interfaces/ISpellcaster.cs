using Characters;
using Characters.Warriors;
using CSharpOOP.Weapons;

namespace Interfaces
{
    public interface ISpellcaster
    {
        Spell MySpell { get; set; }
        int Mana { get; set; }

        void CastSpell(Character character);
    }
}
