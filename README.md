Using README file to test non-fast-forward-merge.
This time around, the merge wasn't fast-forward 
because main had been modified (had its own commits) since the creation of feature-max.
In order to combine their histories,
Git created a merge commit.

Small update for testing rebase.

--------FINAL ANSWERS
1.Kiedy Git wykona fast-forward a kiedy powstaje merge commit?
Git wykona fast-forward, jeśli wykonujemy tylko commit na naszej nowej gałęzi,
nie modyfikując (commitując) gałęzi głównej main.
Merge commit powstanie kiedy na gałęzi głównej 'main' wykonujemy nowe commit-y,
po stworzeniu nowej gałęzi funkcjonalnej. Git tworzy wtedy osobny commit który łączy ich historie.

2.Czym w praktyce różni się merge od rebase?
Merge tworzy nowy commit merge i łączy historie gałęzi.
Rebase przepisuje commity jednej gałęzi na koniec drugiej.

3.W jaki sposób został rozwiązany konflikt w Twoim repozytorium.
Konflikt pojawił się gdy zmieniłam nazwę tej samej zmiennej ('digits') z gałęzi feature-conflict i main.
Rozwiązałam konflikt ręcznie poprzez usuwanie markerów, potem dodałam plik do staged (git add) i wykonałam commit który zakończył merge.