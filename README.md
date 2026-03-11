# apbd-cw1-git-s33197

Ćwiczenia 1 APBD

Teraz był merge bez fast-forward, bo main miał zcommitowane zmiany przed zmergowaniem feature-max, obie gałęzie musiały zostać zmergowane by pogodzić oba zestawy zmian.

Teraz będzie rebase.

1. Kiedy Git wykona fast-forward, a kiedy powstaje merge commit?

Fast-forward - gdy branch, do którego mergujemy NIE MIAŁ commitów od stworzenia naszego drugiego brancha
Merge commit - gdy branch, do którego mergujemy MIAŁ commity od stworzenia naszego drugiego brancha

2. Czym w praktyce różni się merge od rebase?

Merge zachowuje w historii informację o tym, że commity były wykonywane na osobnym branchu. Rebase "zakłamuje historię" ukrywając fakt że istniał jakikolwiek inny branch, sprawiając wrażenie, że commity były wszystkie dodane po sobie na głównym branchu.

3. W jaki sposób został rozwiązany konflikt w Twoim repozytorium?

Połączyłem zmiany z feature brancha i maina w sensowny sposób, tak żeby aplikacja działała i zawierała obie funkcjonalności w sensowny sposób.
