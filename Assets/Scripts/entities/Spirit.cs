using items;

namespace entities {
	/**
	 * This class represents the three spirits, which will try to posses the player
	 */
	public class Spirit : Entity {
	    private Player victim;
	    private Backpack backpack;

		public Spirit(string name) : base(name) {
	        victim = null;
	        backpack = new Backpack(10);
	    }

	    public Player getVictim() {
	        return victim;
	    }

	    public void setVictim(Player victim) {
	        this.victim = victim;
	        if (victim != null) {
	            victim.setSpirit(this);
	        }
	    }

	    public Backpack getBackpack() {
	        return backpack;
	    }
	}
}