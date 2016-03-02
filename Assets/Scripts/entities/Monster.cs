using items;
using body;

namespace entities {
	/**
	 * Abstract class for Monsters that wander around
	 */
	public abstract class Monster : Entity {
	    private Item weapon;

		public Monster(string name, Item weapon ) : base(name) { }
    }
}
