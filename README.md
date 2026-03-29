# Odpowiedzi

## 1. Kiedy Git wykona fast-forward, a kiedy powstaje merge commit?

- **Fast-forward**:
  - gdy ga³¹Ÿ docelowa nie ma nowych commitów od momentu utworzenia drugiej ga³êzi
  - historia jest liniowa
  - Git tylko przesuwa wskaŸnik ga³êzi do przodu
  - nie powstaje nowy commit

- **Merge commit**:
  - gdy obie ga³êzie maj¹ w³asne, niezale¿ne commity
  - historie siê rozchodz¹
  - Git musi utworzyæ nowy commit który pol¹czy obie ga³êzie
  - powstaje commit z dwoma rodzicami
	

## 2. Czym w praktyce ró¿ni siê merge od rebase?

- **Merge**:
  - ³¹czy ga³êzie, zachowuj¹c ich oryginaln¹ strukturê
  - tworzy merge commit (jeœli nie mo¿e byæ fast-forward)
  - historia jest rozga³êziona
  - nie zmienia dotychczasowych commitów

- **Rebase**:
  - przenosi commity na now¹ bazê
  - przepisuje historiê (zmienia hashe commitów)
  - daje liniow¹ i czytelniejsz¹ historiê
  - nie tworzy merge commita (po rebase zazwyczaj jest fast-forward)


## 3. W jaki sposób zosta³ rozwi¹zany konflikt w Twoim repozytorium?

- konflikt powsta³, poniewa¿ ta sama linia w pliku `Program.cs` zosta³a zmieniona w dwóch ga³êziach:
  `main` i `feature-conflict`

- Git oznacza konflikt w pliku za pomoc¹ znaczników: `<<<<<<<` ... `>>>>>>>`

- konflikt zosta³ rozwi¹zany rêcznie poprzez:
  - usuniêcie znaczników konfliktu
  - po³¹czenie obu wersji w jeden komunikat

- po rozwi¹zaniu konfliktu:
  - plik zosta³ dodany
  - wykonano commit koñcz¹cy merge


## Zad. 5
Merge nie by³ fast-forward, poniewa¿ main i feature-max mia³y nowe commity,
ich historie rozesz³y siê.
Git musia³ utworzyæ merge commit.


## Zad. 6

Merge/Rebase

Merge zachowuje oryginaln¹ strukturê ga³êzi. Czêsto powstaje dodatkowy commit (merge commit) w 
przypadku gdy historie ga³êzi rozesz³y siê.

Rebase przepisuje historiê ga³êzi, odtwarza commity na nowszej bazie,
co prowadzi do bardziej liniowej historii - wygl¹da to czyœciej.





# APBD CW1 - Git and GitHub

Simple .NET console application.

Features:
- sum calculation
- average calculation
- maximum calculation