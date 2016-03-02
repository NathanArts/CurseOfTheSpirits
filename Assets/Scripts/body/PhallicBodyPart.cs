using entities;
using items;

namespace body {
	/**
	 *
	 */
	public class PhallicBodyPart : BodyPart, Phallic {
	    private int Size;
	    private int Width;
		public PhallicBodyPart(Item item, string description) : base(item, description) {
	    }

		public int size {
			get { return Size; }
			set { this.Size = value; }
		}

		public int width {
			get { return Width; }
			set { this.Width = value; }
		}
	}
}
