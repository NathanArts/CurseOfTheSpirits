package models.entities;

import models.items.Item;

/**
 * Abstract class for Monsters that wander around
 */
public abstract class Monster extends Entity {
    private Item weapon;
    public Monster(String name, Item weapon) {
        super(name);
    }

    public abstract void fuck(Player victim);
    public abstract void getFucked(Player victim);
}
