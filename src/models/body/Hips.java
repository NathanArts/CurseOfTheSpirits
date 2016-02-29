package models.body;

import models.items.Item;

/**
 * Le cute hips :3
 */
public class Hips extends BodyPart {
    private int size;

    public Hips(Item item, String description, int size) {
        super(item, description);
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
            throw new IllegalArgumentException("increase with negative amount");
        } else {
            setSize(this.size + amount);
        }
    }

    public void decreaseSize(int amount) {
        if (amount < 0) {
            throw new IllegalArgumentException("decrease with negative amount");
        } else {
            setSize(this.size - amount);
        }
    }
}
