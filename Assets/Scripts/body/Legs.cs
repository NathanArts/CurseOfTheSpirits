using items;
using System;

namespace body {
	/**
	 * The players legs
	 */
	public class Legs : BodyPart {
	    private int Quantity;

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

        public Legs(Item item, String description, int quantity) : base(item, description) {
	        this.Quantity = quantity;
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
