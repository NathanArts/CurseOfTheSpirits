package models.body;

import models.items.Item;

/**
 * Abstract class for bodyParts. Every BodyPart can hold an item and has a description
 */
public abstract class BodyPart {
    private Item item;
    private String description;

    public BodyPart(Item item, String description) {
        this.item = item;
        this.description = description;
    }

    public Item getItem() {
        return item;
    }

    public void setItem(Item item) {
        this.item = item;
    }

    public boolean isOccupied() {
        return this.item != null;
    }
}
