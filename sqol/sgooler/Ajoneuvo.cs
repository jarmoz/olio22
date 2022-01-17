using System;

namespace sgooler {
	class Ajoneuvo {
		public string Nimi { get; set; }
		public int Nopeus { get; set; }
		public int Renkaat { get; set; }

		public void TulostaData() => Console.WriteLine(ToString());

		public string ToString() {
			return $@"Nimi: {Nimi}
Nopeus: {Nopeus}
Renkaat: {Renkaat}";
		}
	}
}
