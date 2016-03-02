using items;

namespace entities {
	/**
	 * Abstract class for Monsters that wander around
	 */
	public abstract class Monster : Entity {
        // TODO make weapon and body consistent
	    private Item weapon;

		public Monster(string name, Item weapon ) : base(name) {
            this.weapon = weapon;
            this.Backpack.add(weapon);
        }
    }
}
