# zadanie-08.01
Stwórz hierarchię klas reprezentujących różne produkty dostępne w sklepie internetowym. Każdy produkt powinien zawierać informacje, takie jak cena, dostępność, opis itp. 

Użyj interfejsu IProdukt, aby zdefiniować metody WyświetlInfo(), AktualnaCena() oraz DostępnaIlosc().

Stwórz klasy dziedziczące po Produkt takie jak Ksiazka, Elektronika, Odziez zaimplementuj metody interfejsu oraz odpowiednie pola, Następnie utwórz klasę abstrakcyjna Osoba która zawiera pola takie jak imie, nazwisko itd.

Na końcu utwórz klasę Klient która dziedziczy po osobie oraz zawiera Listę IProdukt o nazwie koszyk, metody do dodawania produktów do listy w której sprawdzana jest ilość danego produktu oraz metodę do Wyświetlania ceny podanego produktu oraz obliczania kosztu całego koszyka. 
