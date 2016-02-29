package models.items;


import java.util.ArrayList;

/**
 * A Backpack can hold as many item types as it has capacity.
 * Also per item type it can hold only as many as the item's maxItemCount.
 */
public class Backpack {
    private ArrayList<KeyValuePair<Item, Counter>> items;
    private int capacity;

    public Backpack(int capacity) {
        this.capacity = capacity;
        items = new ArrayList<>();
    }

    public void setCapacity(int capacity) {
        this.capacity = capacity;
    }

    public boolean isFull() {
        return items.size() >= capacity;
    }

    /**
     * add an item to the backpack, if there is space
     * will either be added into the first found item stack or into a new, if none was found or all are full
     * @param item item to be added to the backpack
     * @return true, if the item was successfully added
     */
    public boolean add(Item item) {
        if (this.isFull()) {
            return false;
        } else {
            for (KeyValuePair<Item, Counter> element : items) {
                // check if there is already an item of this type in the backpack
                if (item.equals(element.getKey())) {
                    // check if the stack still has room
                    if ((element.getKey().getMaxSlotCount()) >= element.getValue().getItemCount()) {
                        element.getValue().add(1);
                        return true;
                    }
                }
            }
            items.add(new KeyValuePair<>(item, new Counter(item.getMaxSlotCount())));
            return true;
        }
    }

    /**
     * remove an item from the backpack by decreasing the item counter on the stack.
     * if this was the last element of the found stack, the stack will be removed.
     * @param item item to be removed from the backpack, if present
     * @return true, if the item was found and removed from the backpack
     */
    public boolean remove(Item item) {
        for (KeyValuePair<Item, Counter> element : items) {
            if (element.getKey().equals(item)) {
                element.getValue().add(-1);
                if (element.getValue().isZero()) {
                    items.remove(element);
                }
                return true;
            }
        }
        return false;
    }
}
