using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Enumerations;

namespace GasmaskShyvana
{
    public static class SpellManager
    {
        // You will need to edit the types of spells you have for each champ as they
        // don't have the same type for each champ, for example Xerath Q is chargeable,
        // right now it's  set to Active.
        public static Spell.Active Q { get; private set; }
        public static Spell.Active W { get; private set; }
        public static Spell.Skillshot E { get; private set; }
        public static Spell.Skillshot R { get; private set; }

        static SpellManager()
        {
            // Initialize spells
            Q = new Spell.Active(SpellSlot.Q, 125);
            W = new Spell.Active(SpellSlot.W, 163);
            E = new Spell.Skillshot(SpellSlot.E, 925, SkillShotType.Linear, 250, 100, 120);
            R = new Spell.Skillshot(SpellSlot.R, 1000, SkillShotType.Linear, 250, 100, 120);
        }

        public static void Initialize()
        {
            // Let the static initializer do the job, this way we avoid multiple init calls aswell
        }
    }
}
