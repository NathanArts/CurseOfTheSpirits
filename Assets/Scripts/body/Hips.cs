using items;
using System;

namespace body {
	/**
	 * Le cute hips :3
	 */
	public class Hips : BodyPart {
	    private int size;

		public Hips(Item item, string description, int size) : base(item, description) {
	        this.size = size;
	    }

	    public int getSize() {
	        return size;
	    }

	    private void setSize(int size) {
	        if (size < 0) {
	            this.size = 0;
	        } else {
	            this.size = size;
	        }
	    }

	    public void increaseSize(int amount) {
	        if (amount < 0) {
	            throw new ArgumentException("increase with negative amount");
	        } else {
	            setSize(this.size + amount);
	        }
	    }

	    public void decreaseSize(int amount) {
	        if (amount < 0) {
	            throw new ArgumentException("decrease with negative amount");
	        } else {
	            setSize(this.size - amount);
	        }
	    }
	}
}
