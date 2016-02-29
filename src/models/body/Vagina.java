package models.body;

import models.items.Item;

/**
 * Vagina, duh
 */
public class Vagina extends Fuckable {
    public Vagina(Item item, String description) {
        super(item, description);
    }

    public Vagina(Item item, String description, int capacity, int sensivity, int wettness) {
        super(item, description, capacity, sensivity, wettness);
    }
}
