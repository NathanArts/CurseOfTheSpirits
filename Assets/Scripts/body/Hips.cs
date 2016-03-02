using items;
using System;

namespace body {
	/**
	 * Le cute hips :3
	 */
	public class Hips : BodyPart {
	    private int Size;

        public int size {
            get { return Size; }
            set {
                if (value < 0) {
                    this.Size = 0;
                } else {
                    this.Size = value;
                }
            }
        }

        public Hips(Item item, string description, int size) : base(item, description) {
	        this.Size = size;
	    }

        public void increaseSize(int amount) {
	        if (amount < 0) {
	            throw new ArgumentException("increase with negative amount");
	        } else {
	            this.size += amount;
	        }
	    }

	    public void decreaseSize(int amount) {
	        if (amount < 0) {
	            throw new ArgumentException("decrease with negative amount");
	        } else {
	            this.size -= amount;
	        }
	    }
	}
}
