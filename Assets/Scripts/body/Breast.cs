using items;
using System;

namespace body {
	/**
	 * The players breasts
	 */
	public class Breast : BodyPart {
	    private int quantity;
	    /**
	     * 0 = flat, 1 = AA, 2 = A, 3 = B, etc
	     */
	    private int size;
		public Breast(Item item, string description, int size) : base(item, description) {
	        this.size = size;
	        this.quantity = 2;
	    }

	    public int getQuantity() {
	        return quantity;
	    }

	    private void setQuantity(int quantity) {
	        if (quantity < 0) {
	            this.quantity = 0;
	        } else {
	            this.quantity = quantity;
	        }
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

	    public void increaseQuantity(int amount) {
	        if (amount < 0) {
	            throw new ArgumentException("increase with negative amount");
	        } else {
	            setQuantity(this.quantity + amount);
	        }
	    }

	    public void decreaseQuantity(int amount) {
	        if (amount < 0) {
	            throw new ArgumentException("decrease with negative amount");
	        } else {
	            setQuantity(this.quantity - amount);
	        }
	    }
	}
}
