using System.Collections.Generic;
using entities;

namespace events {
    class EventFinder {
        private static EventFinder instance;

        private EventFinder() { }

        public static EventFinder Instance {
            get {
                if (instance == null) {
                    instance = new EventFinder();
                }
                return instance;
            }
        }

        public List<Event> findEvent(List<Entity> participants, List<Phallic> phallics, List<Fuckable> fuckables) {
            return new List<Event>();
        }
    }
}
