
namespace entities {
    public abstract class SexableEntity : Entity {
        public SexableEntity(string name) : base(name) {
        }

        /**
         * Let's this entity have sex with the passivePart Entity.
         * This Entity will take the penetrating part.
         * Use the given Phallic from this Entity if existant and the given Fuckable from the passivePart if existant
         * If Phallic or Fuckable is null, choose a random one or throw NotFoundException
         */
        public abstract void fuckActive(SexableEntity passivePart, Phallic phallus = null, Fuckable orifice = null);


        /**
         * Let's this entity have sex with the activePart Entity.
         * This EntityD will be penetrated.
         * Use the given Fuckable from this Entity if existant and the given Phallic from the passivePart if existant
         * If Phallic or Fuckable is null, choose a random one or throw NotFoundException
         */
        public abstract void fuckPassive(SexableEntity activePart = null, Fuckable orifice = null, Phallic phallus = null);
    }
}
