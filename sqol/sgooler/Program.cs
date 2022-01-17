namespace sgooler {
	class Program {
		static void Main(string[] args) {
			Ajoneuvo a = new Ajoneuvo()
			{
				Nimi = "Audi",
				Nopeus = 160,
				Renkaat = 4
			};
			a.TulostaData();
		}
	}
}
