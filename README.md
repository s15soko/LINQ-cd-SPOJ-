### Dany jest niepusty napis reprezentujący kolejno czasy trwania utworów na płycie CD, np.: 4:12,2:43,3:51,4:29,3:24,3:14,4:46,3:25,4:52,3:27.

---

- Format zapisu czasu: ```m:ss``` (np. ```0:59```, ```4:02``` lub ```32:01```) - czas trwania utworu nie przekracza godziny.
- Format ciągu: lista czasów, oddzielona przecinkami, bez spacji.

Napisz program, który dla podanego ciągu czasów utworów zwróci w jednym wierszu, oddzielone pojedynczą spacją, kolejno:

- liczbę utworów,
- średni czas utworu zaokrąglony w górę do pełnych sekund, w formacie m:ss,
- czas trwania wszystkich utworów na płycie (czas odtwarzania całego albumu), w formacie m:ss jeśli nie przekracza godziny, lub h:mm:ss jeśli trwa godzinę lub więcej.

### Example 
```
Wejście:
4:12,2:43,3:51,4:29,3:24,3:14,4:46,3:25,4:52,3:27

Wyjście:
10 3:51 38:23
```