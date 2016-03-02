using items;

namespace body {
	/**
	 * Abstract class for bodyParts. Every BodyPart can hold an item and has a description
	 */
	public abstract class BodyPart {
        private Item Item;
        private string Description;
        public Item item {
            get { return Item; }
            set { this.Item = value; }
        }
        public string description {
            get { return Description; }
        }

        public BodyPart(Item item, string description) {
	        this.Item = item;
	        this.Description = description;
	    }

	    public bool isHoldingItem() {
	        return this.Item != null;
	    }
	}
}