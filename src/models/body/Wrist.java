package models.body;

import models.items.Item;

/**
 * A player has one wrist per Arm (duh)
 */
public class Wrist extends BodyPart {
    public Wrist(Item item, String description) {
        super(item, description);
    }
}
