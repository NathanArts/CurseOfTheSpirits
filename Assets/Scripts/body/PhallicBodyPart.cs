using entities;
using items;

namespace body {
	/**
	 *
	 */
	public abstract class PhallicBodyPart : BodyPart, Phallic {
	    private int Size;
	    private int Width;
        private bool Busy;

        public int size {
            get { return Size; }
            set { this.Size = value; }
        }

        public int width {
            get { return Width; }
            set { this.Width = value; }
        }

        public bool busy {
            get { return Busy; }
        }

        public PhallicBodyPart(Item item, string description) : base(item, description) {
            this.Busy = false;
	    }
        
        public bool startPenetrating(Fuckable orifice) {
            if (busy) {
                return false;
            } else {
                this.Busy = true;
                return true;
            }
        }
        public bool stopPenetrating(Fuckable orifice) {
            if (!busy) {
                return false;
            } else {
                this.Busy = false;
                return true;
            }
        }
    }
}
