using System.Collections;

namespace items {
	
	/**
	* A Backpack can hold as many item types as it has capacity.
	* Also per item type it can hold only as many as the item's maxItemCount.
	*/
	public class Backpack {
		private ArrayList items;
		private int capacity;

		public Backpack(int capacity) {
		    this.capacity = capacity;
			items = new ArrayList();
		}

		public void setCapacity(int capacity) {
		    this.capacity = capacity;
		}

		public bool isFull() {
			return items.Count >= capacity;
		}

		/**
		 * add an item to the backpack, if there is space
		 * will either be added into the first found item stack or into a new, if none was found or all are full
		 * @param item item to be added to the backpack
		 * @return true, if the item was successfully added
		 */
		public bool add(Item item) {
		    if (this.isFull()) {
		        return false;
		    } else {
		        foreach (KeyValuePair<Item, Counter> element in items) {
		            // check if there is already an item of this type in the backpack
		            if (item.Equals(element.getKey())) {
		                // check if the stack still has room
		                if ((element.getKey().getMaxSlotCount()) >= element.getValue().getItemCount()) {
		                    element.getValue().add(1);
		                    return true;
		                }
		            }
		        }
				items.Add(new KeyValuePair<Item, Counter>(item, new Counter(item.getMaxSlotCount())));
		        return true;
		    }
		}

		/**
		 * remove an item from the backpack by decreasing the item counter on the stack.
		 * if this was the last element of the found stack, the stack will be removed.
		 * @param item item to be removed from the backpack, if present
		 * @return true, if the item was found and removed from the backpack
		 */
		public bool remove(Item item) {
		    foreach (KeyValuePair<Item, Counter> element in items) {
		        if (element.getKey().Equals(item)) {
		            element.getValue().add(-1);
		            if (element.getValue().isZero()) {
		                items.Remove(element);
		            }
		            return true;
		        }
		    }
		    return false;
		}
	}
}
