using items;
using body;
using System.Collections.Generic;
using events;

namespace entities {
	/**
	 * The player in our little game.
	 * Right now he has some stats, a name, a gorgeous body, his spirit and his backpack.
	 */
	public class Player : SexableEntity {
	    private Spirit spirit;
	    private Backpack backpack;

		public Player(string name) : base (name) {
	        body.bodyParts.Add("Asshole", new Asshole(null, "Your normal virgin asshole"));
	        body.bodyParts.Add("LeftArm", new Hand(null, "Your left arm is currently carrying nothing", false));
	        body.bodyParts.Add("RightArm", new Hand(null, "Your right arm is currently carrying nothing", true));
	        spirit = null;
	        backpack = new Backpack(5);
	    }

	    public Spirit getSpirit() {
	        return spirit;
	    }

	    public void setSpirit(Spirit spirit) {
	        this.spirit = spirit;
	        if (spirit != null) {
	            spirit.setVictim(this);
	        }
	    }

	    public Backpack getBackpack() {
	        return backpack;
        }

        public override void fuckActive(SexableEntity passivePart, Phallic phallus = null, Fuckable orifice = null) {
            List<Phallic> phallicCandidates = new List<Phallic>();
            List<Fuckable> fuckableCandidates = new List<Fuckable>();
            List<Entity> participants = new List<Entity>();
            
            // choose random Phallic if phallus is null
            if (phallus == null) {
                // search for phallic body parts
                phallicCandidates.AddRange(this.body.findPhallicBodyParts());
                // search for phallic items
                phallicCandidates.AddRange(this.backpack.findPhallicItems());
            }
            // choose random Fuckable if orifice is null
            if (orifice == null) {
                if (passivePart != null) {
                    // search for fuckable body Parts
                    fuckableCandidates.AddRange(passivePart.getBody().findFuckableBodyParts());
                }
            }
            // add participants
            if (passivePart != null) {
                participants.Add(passivePart);
            }
            participants.Add(this);

            List<Event> possibleEvents = EventFinder.Instance.findEvent(participants, phallicCandidates, fuckableCandidates);
            if (possibleEvents.Count == 0) {
                throw new NoEventsFoundException("No Events found for the given parameters");
            }
            // TODO ensure that the found events are possible in the current context and choose one even (randomly or by player)
        }

        public override void fuckPassive(SexableEntity activePart, Fuckable orifice = null, Phallic phallus = null) {
            List<Phallic> phallicCandidates = new List<Phallic>();
            List<Fuckable> fuckableCandidates = new List<Fuckable>();
            List<Entity> participants = new List<Entity>();


            // choose random Phallic if phallus is null
            if (phallus == null) {
                if (activePart != null) {
                    // search for fuckable body Parts
                    phallicCandidates.AddRange(activePart.getBody().findPhallicBodyParts());
                }
            }
            // choose random Fuckable if orifice is null
            if (orifice == null) {
                // search for phallic body parts
                fuckableCandidates.AddRange(this.body.findFuckableBodyParts());
                // search for phallic items
                fuckableCandidates.AddRange(this.backpack.findFuckableItems());
            }
            // add participants
            if (activePart != null) {
                participants.Add(activePart);
            }
            participants.Add(this);

            List<Event> possibleEvents = EventFinder.Instance.findEvent(participants, phallicCandidates, fuckableCandidates);
            if (possibleEvents.Count == 0) {
                throw new NoEventsFoundException("No Events found for the given parameters");
            }
            // TODO ensure that the found events are possible in the current context and choose one even (randomly or by player)
        }
    }
}
