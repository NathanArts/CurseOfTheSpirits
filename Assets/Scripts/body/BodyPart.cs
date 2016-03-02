using items;

namespace body {
	/**
	 * Abstract class for bodyParts. Every BodyPart can hold an item and has a description
	 */
	public abstract class BodyPart {
	    private Item item;
	    private string description;

	    public BodyPart(Item item, string description) {
	        this.item = item;
	        this.description = description;
	    }

	    public Item getItem() {
	        return item;
	    }

	    public void setItem(Item item) {
	        this.item = item;
	    }

	    public bool isHoldingItem() {
	        return this.item != null;
	    }
	}
}