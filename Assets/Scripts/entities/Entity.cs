using body;

namespace entities {

	/**
	 * Abstract class for all entities in the game.
	 * Includes minimum stats set, a body and a name
	 */
	public abstract class Entity {
	    protected string Name;
	    protected Attribute Strength;
	    protected Attribute Dexterity;
	    protected Attribute Endurance;
	    protected Attribute Intelligence;
	    protected Attribute Will;
	    protected Attribute Charisma;
	    protected Attribute Libido;
	    protected Attribute Sensitivity;
	    protected Attribute Lust;
	    protected Body Body;

        public string name {
            get { return this.Name; }
        }
        public Attribute strength {
            get { return Strength; }
        }
        public Attribute dexterity {
            get { return Dexterity; }
        }
        public Attribute endurance {
            get { return Endurance; }
        }
        public Attribute intelligence {
            get { return Intelligence; }
        }
        public Attribute will {
            get { return Will; }
        }
        public Attribute charisma {
            get { return Charisma; }
        }
        public Attribute libido {
            get { return Libido; }
        }
        public Attribute sensitivity {
            get { return Sensitivity; }
        }
        public Attribute lust {
            get { return Lust; }
        }
        public Body body {
            get { return Body; }
        }

        public Entity(string name) {
	        this.Name = name;
	        Strength = new Attribute(0, 100);
	        Dexterity = new Attribute(0, 100);
	        Endurance = new Attribute(0, 100);
	        Intelligence = new Attribute(0, 100);
	        Will = new Attribute(0, 100);
	        Charisma = new Attribute(0, 100);
	        Libido = new Attribute(0, 100);
	        Sensitivity = new Attribute(0, 100);
	        Lust = new Attribute(0, 100);
	        Body = new Body();
	    }

	    public override bool Equals(System.Object obj) {
			if (this == obj) return true;
			if (!(obj is Entity)) return false;

	        Entity entity = (Entity) obj;

	        return Name.Equals(entity.Name);

	    }

	    public override int GetHashCode() {
	        return Name.GetHashCode();
	    }
	}
}
