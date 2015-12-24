using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Enumerations;

namespace GasmaskGraves
{
    public static class SpellManager
    {
        // You will need to edit the types of spells you have for each champ as they
        // don't have the same type for each champ, for example Xerath Q is chargeable,
        // right now it's  set to Active.
        public static Spell.Skillshot Q { get; private set; }
        public static Spell.Skillshot W { get; private set; }
        public static Spell.Active E { get; private set; }
        public static Spell.Skillshot R { get; private set; }

        static SpellManager()
        {
            // Initialize spells
            Q = new Spell.Skillshot(SpellSlot.Q, 950, SkillShotType.Linear, 250, 100, 120);
            W = new Spell.Skillshot(SpellSlot.W, 950, SkillShotType.Circular, 250, 100, 250);
            E = new Spell.Active(SpellSlot.E, 425);
            R = new Spell.Skillshot(SpellSlot.R, 1000, SkillShotType.Cone, 250, 100, 800);
        }

        public static void Initialize()
        {
            // Let the static initializer do the job, this way we avoid multiple init calls aswell
        }
    }
}

