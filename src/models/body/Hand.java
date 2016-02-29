package models.body;

import models.items.Item;

/**
 * Class to represent an arm.
 * An arm can hold something and can be a main arm or not.
 */
public class Hand extends BodyPart {
    private boolean mainArm;

    public Hand(Item item, String description, boolean mainArm) {
        super(item, description);
        this.mainArm = mainArm;
    }
}
