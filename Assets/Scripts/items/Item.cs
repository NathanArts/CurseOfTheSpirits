using body;

namespace items {
	/**
	 * Generic Item class, doesn't do anything yet
	 */
	public class Item {
	    private string Name;
	    private int Value;
	    private BodyPart WornAt;
	    private int MaxSlotCount;

        public string name {
            get { return this.Name; }
        }
        public int value {
            get { return this.Value; }
            set { this.Value = value; }
        }
        public BodyPart wornAt {
            get { return this.WornAt; }
            set { this.WornAt = value; }
        }
        public int maxSlotCount {
            get { return this.MaxSlotCount; }
        }

	    public Item(string name, int value = 0, int maxSlotCount = 1, BodyPart wornAt = null) {
	        this.Name = name;
	        this.Value = value;
	        this.WornAt = wornAt;
	        this.MaxSlotCount = maxSlotCount;
	    }

	    public bool isInBackpack() {
	        return WornAt == null;
	    }

	    public bool equip(BodyPart bodyPart) {
	        if (bodyPart.isHoldingItem()) {
	            return false;
	        } else {
	            bodyPart.item = this;
	            this.WornAt = bodyPart;
	            return true;
	        }
	    }

	    public override bool Equals(System.Object obj) {
			if (this == obj)
				return true;
			if (!(obj is Item))
				return false;

			Item item = (Item) obj;

	        if (Value != item.Value) return false;
	        if (MaxSlotCount != item.MaxSlotCount) return false;
	        return Name.Equals(item.Name);
	    }

	    public override int GetHashCode() {
	        int result = Name.GetHashCode();
	        result = 31 * result + Value;
	        result = 31 * result + MaxSlotCount;
	        return result;
	    }
	}
}