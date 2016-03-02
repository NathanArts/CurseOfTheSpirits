using System.Collections.Generic;
using entities;


namespace items {
	
	/**
	* A Backpack can hold as many item types as it has capacity.
	* Also per item type it can hold only as many as the item's maxItemCount.
	*/
	public class Backpack {
		private List<KeyValuePair<Item, Counter>> Items;
		private int Capacity;

        public int capacity {
            get { return this.Capacity; }
            set { this.Capacity = value; }
        }

        public List<KeyValuePair<Item, Counter>> items {
            get { return new List<KeyValuePair<Item, Counter>>(this.Items); }
        }

		public Backpack(int capacity) {
		    this.Capacity = capacity;
			Items = new List<KeyValuePair<Item, Counter>>();
		}

		public bool isFull() {
			return Items.Count >= Capacity;
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
		        foreach (KeyValuePair<Item, Counter> element in Items) {
		            // check if there is already an item of this type in the backpack
		            if (item.Equals(element.key)) {
		                // check if the stack still has room
		                if ((element.key.maxSlotCount) > element.value.getItemCount()) {
		                    element.value.add(1);
		                    return true;
		                }
		            }
		        }
				Items.Add(new KeyValuePair<Item, Counter>(item, new Counter(item.maxSlotCount)));
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
		    foreach (KeyValuePair<Item, Counter> element in Items) {
		        if (element.key.Equals(item)) {
		            element.value.add(-1);
		            if (element.value.isZero()) {
		                Items.Remove(element);
		            }
		            return true;
		        }
		    }
		    return false;
		}



        public List<Phallic> findPhallicItems() {
            List<Phallic> phallics = new List<Phallic>();
            foreach (KeyValuePair<Item, Counter> kvp in this.items) {
                if (kvp.key is Phallic) {
                    phallics.Add((Phallic) kvp.key);
                }
            }
            return phallics;
        }

        public List<Fuckable> findFuckableItems() {
            List<Fuckable> fuckables = new List<Fuckable>();
            foreach (KeyValuePair<Item, Counter> kvp in this.items) {
                if (kvp.key is Fuckable) {
                    fuckables.Add((Fuckable) kvp.key);
                }
            }
            return fuckables;
        }
    }
}
