using body;

namespace items {
	/**
	 * Generic Item class, doesn't do anything yet
	 */
	public class Item {
	    private string name;
	    private int value;
	    private BodyPart wornAt;
	    private int maxSlotCount;

	    public Item(string name, int value, BodyPart wornAt, int maxSlotCount) {
	        this.name = name;
	        this.value = value;
	        this.wornAt = wornAt;
	        this.maxSlotCount = maxSlotCount;
	    }

	    public Item(string name, int value, int maxSlotCount) : this(name, value, null, maxSlotCount) {
	    }

	    public bool isInBackpack() {
	        return wornAt == null;
	    }

	    public string getName() {
	        return name;
	    }

	    public int getValue() {
	        return value;
	    }

	    public void setValue(int value) {
	        this.value = value;
	    }

	    public BodyPart getWornAt() {
	        return wornAt;
	    }

	    public void setWornAt(BodyPart wornAt) {
	        this.wornAt = wornAt;
	    }

	    public bool equip(BodyPart bodyPart) {
	        if (bodyPart.isHoldingItem()) {
	            return false;
	        } else {
	            bodyPart.setItem(this);
	            this.wornAt = bodyPart;
	            return true;
	        }
	    }

	    public int getMaxSlotCount() {
	        return maxSlotCount;
	    }

	    public override bool Equals(System.Object obj) {
			if (this == obj)
				return true;
			if (!(obj is Item))
				return false;

			Item item = (Item) obj;

	        if (value != item.value) return false;
	        if (maxSlotCount != item.maxSlotCount) return false;
	        return name.Equals(item.name);

	    }

	    public override int GetHashCode() {
	        int result = name.GetHashCode();
	        result = 31 * result + value;
	        result = 31 * result + maxSlotCount;
	        return result;
	    }
	}
}