package models.body;

import models.entities.Phallic;
import models.items.Item;

/**
 *
 */
public class PhallicBodyPart extends BodyPart implements Phallic {
    private int size;
    private int width;
    public PhallicBodyPart(Item item, String description) {
        super(item, description);
    }

    @Override
    public int getSize() {
        return this.size;
    }

    @Override
    public int getWidth() {
        return this.width;
    }
}
