These were more or less copy and paste from the course material. You just needed to find the right consept from the course material and implement that to your code. This was good way to get started with programming. There is also alot of different tools that i learned that are C# spesific. 

# Kilpailu
C# harjoitus. Ohjelma sisältää rajapinnan Osallistujat jolla on ominaisuuksinaan id ja nimi. Luokka henkilö toteuttaa rajapinnan Osallistujat luokka sisältää ominaisuudet etunimi ja sukunimi ja nämä arvot sijoitetaan rajapinnan arvoon nimi. Luokka joukkue toteuttaa rajapinnan Osallistujat. Geneerinen luokka Suoritus sisältää kaksi tyyppiparametriä, joilla tyypitetään luokan automaattiset muuttujat. Luokka kilpailu on myös geneerinen ja sisältää kaksi tyyppiparametriä joita käytetään suoritus luokan tyypittämiseen. Kilpailu sisältää kaksi kappaletta automaattisia ominaisuuksia ja konstruktorin joka alustaa ominaisuudet. Luokka yksilökilpailu periytyy luokalta kilpailu sen tyyppiparametreillä on arvot Henkilö ja double. 

Program luokassa luodaan random olio. Main metodissa ajetaan algoritmi ehdoilla. Algoritmissä tehdään joko yksilö tai joukkuekilpailu, seuraavaksi kysytään kyseisen kilpailun maksimi ja mini tulosta. Metodilla luodaan kilpailu tai yksilökilpailu. Kysytään nimeä käyttäjältä ja arvotaan suoritus tulokset aikaisemmin kysyttyjen pisteidän väliltä. Tulostetaan kilpailun tulokset käyttäjälle. 

# EnumAutomerkit
C# harjoitus. Harjoituksessa oli tarkoituksena opetella käyttämään enum luottelotyyppiä. Luotiin luettelo jossa oli automerkkejä ja joikaisella niistä on annettu oma id. Käyttäjältä pyydettiin, joko merkkiä
tai id:tä, joista annettu kohdistettiin listassa olleesseen arvoon.

# GeneerinenPari
C# harjoitus. Ohjelmassa on geneerinen rajapinta, IPari<T,U> joka sisältää ominaisuudet T jonka nimi on A ja U, jonka ominaisuuden nimi on B molemmat ominaisuudet ovat automaattisia. Geneerinen rajapinta IPari<T> toteuttaa rajapinnan IPari<T,T>. Luokka Pari<T> toetuttaa rajapinnan IPari<T> siinä on automaattisia T tyyppisiä muuttujia A sekä B sekä konstruktori, joka antaa arvot muuttujille. ToString metodi tulostaa arvot. Luokka SekaPari<T,U> toetuttaa rajapinnan <T,U> ja sisältää samat asia kuin edellä mainittu metodi Luokka. 
  
  Main metodi sisältää metodin nimeltä Algoritmi, joka vastaa ohjelman toiminnoista. Metodissa luodaan olioita kysytään käyttäjältä niiden arvoja ja tehdään niistä pareja, jonka jälkeen tulostetaan parien tiedot.

# Tuotteet
C# harjoitus. Harjoituksessa on rajapinta id sekä nimi, joista jälkimäisessä on automaattinen ominaisuus nimi. 
Luokka Verokanta toteuttaa rajapinnan nimi ja siinä on kenttämuuttuja _veroprosentti, ominausuuksina on automaattinen Veroprosentti joka kapseloi kenttämuuttujan, 
Verokerroin ja automaattinen Nimi. Metodi joka palauttaa Veroprosentin. Luokka Tuoteryhmä, joka toteuttaa rajapinnat id ja nimi. Se sisältää myös ominaisuuksia id ja nimi, 
jotka alustetaan konstruktorissa. Metodi joka tulostaa arvot id:lle ja nimelle. Luokka Tuote joka toteuttaa rajapinnat id ja nimi kenttä muuttuja _hinta ja ominaisuuksia,
id, nimi, verokanta alvkanta, hinta ja verollinenhinta. Konstruktori, joka asettaa arvot id:lle, nimelle ja hinnalle. Metodi, joka palauttaa arvoja.
Main osassa toteutetaan algoritmi niminen metodi, joka luo verokantoja, tuoteryhmiä ja tuotteita sen jälkeen käyttäjä voi asettaa niille arvot.

# NoppaPeli
C# harjoitus. Harjoitus, jossa simuloidaan noppapeli. Peliin osallistuu kaksi pelaaja, jotka molemmat heittävät kahta noppaa.

Ohjelmassa on rajapinta nimi. Siinä on myös kolme luokkaa Pelaaja, Nopat ja Sovellus. Pelaaja luokka touteuttaa rajapinnan nimi ja asettaa pelaajalle konstruktorissa aloituspisteet, joista molemmat ovat automaattisia ominaisuuksia. Noppa luokassa on automaattiset ominaisuudet Lukema ja HeittojenLkm sekä konstruktori joka alustaa nopan. Metodilla Heita voidaan heittää noppaa tulokseksi tulee random numero ja samalla heittojen lukumäärää kasvatetaan yhdellä. Luokassa Sovellus on voitonpisteraja muuttuja ja Aja metodi joka toteuttaa pelin. Pelissä luodaan olioita ja kutsutaan tarvittavia toimintoja ja tarkistetaan asioita if lauseilla.

# Palindromi
C# harjoitus. Ohjelmassa pyydetään käyttäjää syöttämään päätteeseen teksti ja ohjelma tarkistaa onko teksti palindromi. Ohjelmassa käytetään kahta metodia ja muutaa ehtolausetta. 

# LuhninAlgoritmi
C# harjoitus. Tarkistussumman laskemiseen käytetty kaava, jota käytetään varmistamaan erillaisia tunnistenumeroita
kuten luottokortti- ja IMEI-numeroita. Ohjelma on suhteellisen yksinkertainen, siihen sisältyy muutama metodi
joissa suoritetaan ehtolauseita. Varmistetaan, että käyttäjän antama syöte on oikeanlainen jonka jälkeen se
tarkistetaan Luhnin algoritmillä. 
