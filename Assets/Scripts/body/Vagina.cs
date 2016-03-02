using items;

namespace body {
	/**
	 * Vagina, duh
	 */
	public class Vagina : Fuckable {
		public Vagina(Item item, string description) : base(item, description) {
	    }

	    public Vagina(Item item, string description, int capacity, int sensivity, int wettness) 
			: base(item, description, capacity, sensivity, wettness) {
	    }
	}
}