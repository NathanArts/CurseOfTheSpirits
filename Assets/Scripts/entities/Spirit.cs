using items;

namespace entities {
	/**
	 * This class represents the three spirits, which will try to posses the player
	 */
	public class Spirit : Entity {
	    private Player Victim;

        public Player victim {
            get { return Victim; }
            set {
                this.Victim = value;
                if (Victim != null) {
                    Victim.spirit = this;
                }
            }
        }

        public Spirit(string name) : base(name, 5) {
	        Victim = null;
	    }
	}
}