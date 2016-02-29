package models.body;

import models.items.Item;

/**
 * The players legs
 */
public class Legs extends BodyPart {
    private int quantity;

    public Legs(Item item, String description, int quantity) {
        super(item, description);
        this.quantity = quantity;
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

    public void increaseQuantity(int amount) {
        if (amount < 0) {
            throw new IllegalArgumentException("increase with negative amount");
        } else {
            setQuantity(this.quantity + amount);
        }
    }

    public void decreaseQuantity(int amount) {
        if (amount < 0) {
            throw new IllegalArgumentException("decrease with negative amount");
        } else {
            setQuantity(this.quantity - amount);
        }
    }
}
