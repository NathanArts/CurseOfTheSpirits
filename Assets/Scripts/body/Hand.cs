using items;

namespace body {
	/**
	 * Class to represent an arm.
	 * An arm can hold something and can be a main arm or not.
	 */
	public class Hand : BodyPart {
	    private bool MainArm;

        public bool mainArm {
            get { return MainArm; }
        }

		public Hand(Item item, string description, bool mainArm = false) : base(item, description) {
	        this.MainArm = mainArm;
	    }
	}
}
