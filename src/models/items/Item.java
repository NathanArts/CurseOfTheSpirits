package models.items;

import models.body.BodyPart;

/**
 * Generic Item class, doesn't do anything yet
 */
public class Item {
    private String name;
    private int value;
    private BodyPart wornAt;
    private int maxSlotCount;

    public Item(String name, int value, BodyPart wornAt, int maxSlotCount) {
        this.name = name;
        this.value = value;
        this.wornAt = wornAt;
        this.maxSlotCount = maxSlotCount;
    }

    public Item(String name, int value, int maxSlotCount) {
        this(name, value, null, maxSlotCount);
    }

    public boolean isInBackpack() {
        return wornAt == null;
    }

    public String getName() {
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

    public boolean equip(BodyPart bodyPart) {
        if (bodyPart.isOccupied()) {
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

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (!(o instanceof Item)) return false;

        Item item = (Item) o;

        if (value != item.value) return false;
        if (maxSlotCount != item.maxSlotCount) return false;
        return name.equals(item.name);

    }

    @Override
    public int hashCode() {
        int result = name.hashCode();
        result = 31 * result + value;
        result = 31 * result + maxSlotCount;
        return result;
    }
}
