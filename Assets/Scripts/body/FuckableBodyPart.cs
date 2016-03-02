using items;
using entities;

namespace body {
	/**
	 * Abstrac class for all body Parts that are fuckable
	 */
	public abstract class FuckableBodyPart : BodyPart, Fuckable {
        private string Name;
        private int Sensivity;
        private int Capacity;
        private int Wettness;
        private int OccupyCount;

        public string name {
            get { return Name; }
        }
        public int sensivity {
            get { return Sensivity; }
            set { this.Sensivity = value >= 0 ? value : 0; }
        }
        public int capacity {
            get { return Capacity; }
            set { this.Capacity = value >= 0 ? value : 0; }
        }
        public int wettness {
            get { return Wettness; }
            set { this.Wettness = value >= 0 ? value : 0; }
        }
        public int occupyCount {
            get { return OccupyCount; }
            set { this.OccupyCount = value >= 0 ? value : 0; }
        }

        public FuckableBodyPart(Item item, string description, int capacity = 1, int sensivity = 1, int wettness = 0)
				: base (item, description) {
	        this.Capacity = capacity;
	        this.Sensivity = sensivity;
	        this.Wettness = wettness;
            this.OccupyCount = 0;
        }

	    /**
	     * try to insert a phallic into the fuckable body part
	     * @return true, if we got in ;)
	     */
	    public bool insert(entities.Phallic phallus) {
	        if (!isOccupied()) {
	            OccupyCount++;
	            return true;
	        }
	        return false;
	    }

        /**
	     * try to remove a phallic from the fuckable body part
	     * @return true, if we got out ;)
	     */
        public bool remove(entities.Phallic phallus) {
	        if (OccupyCount > 0) {
	            OccupyCount--;
	            return true;
	        }
	        return false;
	    }

	    public bool isOccupied() {
	        return OccupyCount >= Capacity;
        }

        public override bool Equals(object obj) {
            if (this == obj)
                return true;
            if (!(obj is FuckableBodyPart))
                return false;

            FuckableBodyPart orifice = (FuckableBodyPart) obj;

            return name.Equals(orifice.name);
        }

        public override int GetHashCode() {
            return name.GetHashCode();
        }
    }
}
