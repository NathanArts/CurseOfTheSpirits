package models.entities;

import models.body.Body;
import models.items.Backpack;

/**
 * This class represents the three spirits, which will try to posses the player
 */
public class Spirit extends Entity {
    private Player victim;
    private Backpack backpack;

    public Spirit(String name) {
        super(name);
        victim = null;
        backpack = new Backpack(10);
    }

    public Player getVictim() {
        return victim;
    }

    public void setVictim(Player victim) {
        this.victim = victim;
        if (victim != null) {
            victim.setSpirit(this);
        }
    }

    public Backpack getBackpack() {
        return backpack;
    }
}
