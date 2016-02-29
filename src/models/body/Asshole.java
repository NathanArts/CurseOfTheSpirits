package models.body;

import models.items.Item;

/**
 * well, it's an asshole. What do you expect
 */
public class Asshole extends Fuckable {
    public Asshole(Item item, String description) {
        super(item, description);
    }

    public Asshole(Item item, String description, int capacity, int sensivity, int wettness) {
        super(item, description, capacity, sensivity, wettness);
    }
}
