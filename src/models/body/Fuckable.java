package models.body;

import models.items.Item;

/**
 * Abstrac class for all body Parts that are fuckable
 */
public abstract class Fuckable extends BodyPart {
    private int capacity;
    private int sensivity;
    private int wettness;
    private int occupyCount;

    public Fuckable(Item item, String description) {
        super(item, description);
        this.capacity = 1;
        this.sensivity = 1;
        this.wettness = 0;
        this.occupyCount = 0;
    }

    public Fuckable(Item item, String description, int capacity, int sensivity, int wettness) {
        super(item, description);
        this.capacity = capacity;
        this.sensivity = sensivity;
        this.wettness = wettness;
    }

    public int getCapacity() {
        return capacity;
    }

    public void setCapacity(int capacity) {
        this.capacity = capacity;
    }

    public int getSensivity() {
        return sensivity;
    }

    public void setSensivity(int sensivity) {
        this.sensivity = sensivity;
    }

    public int getWettness() {
        return wettness;
    }

    public void setWettness(int wettness) {
        this.wettness = wettness;
    }

    public int getOccupyCount() {
        return occupyCount;
    }

    /**
     * try to add an occupant to the fuckable body part
     * @return true, if we got in ;)
     */
    public boolean occupy() {
        if (!isOccupied()) {
            occupyCount++;
            return true;
        }
        return false;
    }

    /**
     * try to remove an occupant from the fuckable body part
     * @return true, if we got out ;)
     */
    public boolean deoccupy() {
        if (occupyCount > 0) {
            occupyCount--;
            return true;
        }
        return false;
    }

    public boolean isOccupied() {
        return occupyCount >= capacity;
    }
}
