using items;
using System;

namespace body {
	/**
	 * The players breasts
	 */
	public class Breast : BodyPart {
	    private int Quantity;
	    /**
	     * 0 = flat, 1 = AA, 2 = A, 3 = B, etc
	     */
	    private int Size;

        public int quantity {
            get { return Quantity; }
            set {
                if (value < 0) {
                    this.Quantity = 0;
                } else {
                    this.Quantity = value;
                }
            }
        }
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

        public Breast(Item item, string description, int size) : base(item, description) {
	        this.Size = size;
	        this.Quantity = 2;
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

	    public void increaseQuantity(int amount) {
	        if (amount < 0) {
	            throw new ArgumentException("increase with negative amount");
	        } else {
	            this.quantity += amount;
	        }
	    }

	    public void decreaseQuantity(int amount) {
	        if (amount < 0) {
	            throw new ArgumentException("decrease with negative amount");
	        } else {
	            this.quantity -= amount;
	        }
	    }
	}
}
