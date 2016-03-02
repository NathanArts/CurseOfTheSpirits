using items;

namespace entities {
	/**
	 * Abstract class for Monsters that wander around
	 */
	public abstract class Monster : Entity {
	    private Item weapon;

		public Monster(string name) : base(name) {}

	    public abstract void fuck(Player victim);
	    public abstract void getFucked(Player victim);
	}
}
