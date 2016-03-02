using System.Collections.Generic;
using events;

namespace entities {
    public abstract class SexableEntity : Entity {
        public SexableEntity(string name, int backpackCapacity = 1) : base(name, backpackCapacity) {
        }

        /**
         * Let's this entity have sex with the passivePart Entity.
         * This Entity will take the penetrating part.
         * Use the given Phallic from this Entity if existant and the given Fuckable from the passivePart if existant
         * If Phallic or Fuckable is null, choose a random one or throw NotFoundException
         */
        public virtual void fuckActive(SexableEntity passivePart = null, Phallic phallus = null, Fuckable orifice = null) {
            List<Event> possibleEvents = findPossibleSexEvents(passivePart, this, orifice, phallus);
            if (possibleEvents.Count == 0) {
                throw new NoEventsFoundException("No Events found for the given parameters");
            }
            // TODO ensure that the found events are possible in the current context and choose one even (randomly or by player)
        }


        /**
         * Let's this entity have sex with the activePart Entity.
         * This Entity will be penetrated.
         * Use the given Fuckable from this Entity if existant and the given Phallic from the passivePart if existant
         * If Phallic or Fuckable is null, choose a random one or throw NotFoundException
         */
        public virtual void fuckPassive(SexableEntity activePart = null, Fuckable orifice = null, Phallic phallus = null) {
            List<Event> possibleEvents = findPossibleSexEvents(this, activePart, orifice, phallus);
            if (possibleEvents.Count == 0) {
                throw new NoEventsFoundException("No Events found for the given parameters");
            }
            // TODO ensure that the found events are possible in the current context and choose one even (randomly or by player)
        }

        /**
         * Find all possible Sexevents between 2 SexableEntities and 
         */
        public List<Event> findPossibleSexEvents(SexableEntity passivePart = null, SexableEntity activePart = null, Fuckable orifice = null, Phallic phallus = null) {
            List<Phallic> phallicCandidates = new List<Phallic>();
            List<Fuckable> fuckableCandidates = new List<Fuckable>();
            List<Entity> participants = new List<Entity>();
            
            // choose random Phallic if phallus is null
            if (phallus == null) {
                if (activePart != null) {
                    // search for fuckable body Parts
                    phallicCandidates.AddRange(activePart.body.findPhallicBodyParts());
                    // search for phallic items
                    phallicCandidates.AddRange(activePart.backpack.findPhallicItems());
                }
            } else if (activePart != null && activePart.hasPhallic(phallus)) { // check if the activePart has the given Phallic
                phallicCandidates.Add(phallus);
            } else if (!passivePart.hasPhallic(phallus)) { // no active part but phallic -> masturbation -> ensure possesion
                throw new PhallicNotFoundException("activePart " + activePart.name + " does not have Phallic " + phallus.name);
            }
            // choose random Fuckable if orifice is null
            if (orifice == null) {
                if (passivePart != null) {
                    // search for phallic body parts
                    fuckableCandidates.AddRange(passivePart.body.findFuckableBodyParts());
                    // search for phallic items
                    fuckableCandidates.AddRange(passivePart.backpack.findFuckableItems());
                }
            } else if (passivePart != null && passivePart.hasFuckable(orifice)) { // check if the passivePart has the given Orifice
                fuckableCandidates.Add(orifice);
            } else if (!activePart.hasFuckable(orifice)) { // no passive part but orifice -> masturbation -> ensure possesion
                throw new FuckableNotFoundException("passivePart " + passivePart.name + " does not have Fuckable " + orifice.name);
            }
            // add participants
            if (activePart != null) {
                participants.Add(activePart);
            }
            if (passivePart != null) {
                participants.Add(passivePart);
            }

            return EventFinder.Instance.findEvent(participants, phallicCandidates, fuckableCandidates);
        }

        public bool hasFuckable(Fuckable orifice) {
            if (this.body.findFuckableBodyParts().Contains(orifice)) {
                return true;
            }
            if (this.backpack.findFuckableItems().Contains(orifice)) {
                return true;
            }
            return false;
        }

        public bool hasPhallic(Phallic phallus) {
            if (this.body.findPhallicBodyParts().Contains(phallus)) {
                return true;
            }
            if (this.backpack.findPhallicItems().Contains(phallus)) {
                return true;
            }
            return false;
        }
    }
}
