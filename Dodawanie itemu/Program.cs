using LolClasses;

//stwórz nowego champa - garena
Garen g = new Garen();
//opdal emotke dla garena
g.ctrl3();

//stworz instacje przedmiotu - rubycrystal
RubyCrystal rb = new RubyCrystal();
LongSword ls = new LongSword();
//sprawdz ile ma hp garen
g.showHP();
//kup mu item
g.buyItem(rb);
//sprawdz ile ma teraz hp
g.showHP();
//kup mu drugi item
g.buyItem(rb);

g.buyItem(ls);
//sprawdz ile ma teraz hp
g.showHP();
g.showAD();
