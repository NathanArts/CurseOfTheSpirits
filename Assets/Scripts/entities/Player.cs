using body;
using System.Collections.Generic;
using events;

namespace entities {
    /**
	 * The player in our little game.
	 * Right now he has some stats, a name, a gorgeous body, his spirit and his backpack.
	 */
    public class Player : SexableEntity {
        private Spirit Spirit;

        public Spirit spirit {
            get { return Spirit; }
            set {
                this.Spirit = value;
                if (Spirit != null) {
                    Spirit.victim = this;
                }
            }
        }

        public Player(string name) : base(name, 5) {
            Body.bodyParts.Add("Asshole", new Asshole(null, "Your normal virgin asshole"));
            Body.bodyParts.Add("LeftArm", new Hand(null, "Your left arm is currently carrying nothing", false));
            Body.bodyParts.Add("RightArm", new Hand(null, "Your right arm is currently carrying nothing", true));
            Spirit = null;
        }
    }
}
