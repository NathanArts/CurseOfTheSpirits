package models.entities;

import models.body.Hand;
import models.body.Asshole;
import models.items.Backpack;

/**
 * The player in our little game.
 * Right now he has some stats, a name, a gorgeous body, his spirit and his backpack.
 */
public class Player extends Entity {
    private Spirit spirit;
    private Backpack backpack;

    public Player(String name) {
        super(name);
        body.addBodyPart("Asshole", new Asshole(null, "Your normal virgin asshole"));
        body.addBodyPart("LeftArm", new Hand(null, "Your left arm is currently carrying nothing", false));
        body.addBodyPart("RightArm", new Hand(null, "Your right arm is currently carrying nothing", true));
        spirit = null;
        backpack = new Backpack(5);
    }

    public Spirit getSpirit() {
        return spirit;
    }

    public void setSpirit(Spirit spirit) {
        this.spirit = spirit;
        if (spirit != null) {
            spirit.setVictim(this);
        }
    }

    public Backpack getBackpack() {
        return backpack;
    }
}
