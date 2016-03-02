namespace items {
	/**
	 * Generic key value pair for the backpack
	 */
	public class KeyValuePair<K, V> {
		private K Key;
		private V Value;

        public K key {
            get { return key; }
            set { this.Key = value; }
        }
        public V value {
            get { return Value; }
            set { this.Value = value; }
        }

        public KeyValuePair(K key, V value) {
			this.Key = key;
			this.Value = value;
		}
	}
}