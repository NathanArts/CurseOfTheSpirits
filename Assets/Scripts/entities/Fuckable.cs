
namespace entities {
    public interface Fuckable {
        /**
	     * name for identification
         */
        string name {
            get;
        }
        int capacity {
            get;
            set;
        }
        int wettness {
            get;
            set;
        }
        int occupyCount {
            get;
            set;
        }
        bool insert(Phallic phallus);
        bool remove(Phallic phallus);

        bool Equals(object obj);
        int GetHashCode();
    }
}
