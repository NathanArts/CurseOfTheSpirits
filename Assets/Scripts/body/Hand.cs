using items;

namespace body {
	/**
	 * Class to represent an arm.
	 * An arm can hold something and can be a main arm or not.
	 */
	public class Hand : BodyPart {
	    private bool mainArm;

		public Hand(Item item, string description, bool mainArm) : base(item, description) {
	        this.mainArm = mainArm;
	    }
	}
}
