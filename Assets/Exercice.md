# Exercice Projections
sauvegardée
*Objectif:* Appliquer certains effets de perspective à l'aide des matrices de transformation.

**Modifiez ce fichier pour répondre aux questions**

## Généralité

Un composant `CustomMatrices` a été ajouté à la caméra *Exercice/Camera* de la scène principale. Ce composant applique la matrice de projection configurée en paramètre à la caméra (de façon continue, donc possible de la modifier lors de l'exécution). Cette matrice est sauvegardée dans un object scriptable afin de pouvoir les conserver, et il suffit d'y glisser-déposer un objet scriptable du même type pour essayer diverses configurations.

## 1

Configurez la résolution du jeu pour être en ratio 16:9. Lancez le jeu à l'aide de la matrice *PerspectiveMatrix*. Modifiez le ratio pour une configuration 4:3. Que constatez-vous?

-Bien que le contenu se trouvant dans la fenêtre de jeu ne soit pas modifié, le changement de ratio vers 4:3 a pour effet d'écraser la scène de manière verticale (le personnage a l'air plus mince), justement pour faire entrer toutes les mêmes informations dans une fenêtre moins large.

Remarquez les valeurs de la diagonale de la matrice. Dupliquez l'objet de matrice et paramétrez manuellement les valeurs pour obtenir un résultat satisfaisant. Quelle matrice avez-vous obtenu?

-La nouvelle matrice obtenue est (environ)

1.5 0  0  0
0  1.7 0  0
0   0 -1 -0.6
0   0 -1  0

versus la matrice non modifiée (environ)

1   0  0  0
0  1.7 0  0
0   0 -1 -0.6
0   0 -1  0

-Pour obtenir un résultat satisfaisant, il a suffit de modifier le premier paramètre, ici de 1 à 1.5, ce qui a eu pour effet d'étirer l'image dans l'axe des x, lui donnant un air plus naturel. Toutefois, cela a aussi eu l'effet de cacher certains éléments, comme des voitures et pancartes, qui se sont retrouvés hors champ lors de la modification apportée à la matrice. Ceci est simplement expliqué par le fait que l'écran en 16:9 est simplement plus large que le 4:3, et que si ces deux écrans ont la même hauteur, le premier pourra naturellement contenir plus d'informations visuelles.

## 2

Faites le même exercice que précédemment, mais à l'aide de la matrice *OrthoMatrix*.

-Il se passe exactement la même chose, dans le sens ou le fait de garder les mêmes informations dans une fenêtre plus petite fait en sorte que l'image semble écrasée dans l'axe des x (plus mince)

-Encore une fois, la solution est de modifier le premier paramètre de la matrice orthogonale pour étirer l'image horizontalement, ce qui a encore l'effet de masquer une partie de l'image qui se retrouve hors champ, ce coup ci avec une maison au complet qui disparait du champ de vision


## 3

En conservant un ratio 16:9, dupliquez et modifiez la matrice *OrthoMatrix* en modifiant les deux valeurs supérieures de la dernière colonne (demeurez dans la plage ±1). Que constatez-vous? Qu'arrive-t-il si vous modifiez la troisième valeur de cette colonne? Qu'en est-il de la dernière valeur?

-Les deux valeurs supérieures ajoutent une translation en x ou en y à la scène (ou plutôt à la caméra), en opposition aux valeurs placés dans les autres colonnes, qui changent les proportions de ce qui est vu à l'écran.
-Par déduction, on peut supposer que changer la troisème valeur est supposée appliquer une translation en z à ce qui est vu, mais la projection orthogonale fait en sorte fait en sorte qu'on ne peut deviner ces changements de distance en voyant la taille des objets varier, comme le ferait une vue en perspective. En jouant très précisément avec les valeurs (entre 0.98, 0.97, 0.96) on peut toutefois faire disparaitre certains éléments du champ de vision laissant supposer que les éléments se retrouvent alors derrière la caméra, ou trop loin pour être visibles.
-Le quatrième paramètre de la colonne semble faire bouger la scène dans l'axe des z, choses qui semble contraire à ce que nous remarquions lors du dernier commentaire. Toutefois, comme dans notre hypothèse, la projection orthogonale ne devrait pas affecter la taille des objets dépendamment de leur distance, on peut supposer que ce paramètre affecte le ''zoom'' de la caméra, agrandissant ou rapetissant l'image dans son entièreté de manière physique plutôt que par la perspective

## 4

Dupliquez et modifiez la matrice *OrthoMatrix*, appliquez  les valeurs "-0.2" et "-0.8" aux deux valeurs supérieures de la dernière colonne, et ajoutez les valeurs "-0.01" et "-0.0178" aux deux valeurs supérieures de la troisième colonne. Que constatez-vous?

-Du point de vue de la caméra, on dirait qu'elle aurait été placée en angle au dessus à droite de la scène. On peut donc voir le côté des objets, ainsi que le sol, chose qu'on ne pouvait pas faire avant. On peut toujours dire que la vision est orthogonale, parce que les proportions restent pareilles peu importe la distance à la caméra, comme on peut le voir avec les colonnes soutenant le bâtiment principal, qui sont de la même taille à l'avant et à l'arriére. On peut poser l'hypothèse la modification de ces paramètres agit comme une rotation de la scène.

## 5

Désactivez la caméra *Exercice/Camera* et activez la caméra *Exercice/Camera (1)*. Ajoutez un script au projet, à ajouter sur cette dernière caméra, où vous implémenterez un effet de [Travelling Contrarié](https://fr.wikipedia.org/wiki/Travelling_contrari%C3%A9) centré sur le personnage. Il existe plusieurs références sur le web pour des algorithmes (incluant la page anglaise de l'article ci-dessus), mais vous devriez être en mesure de déduire un algorithme à l'aide d'un peu d'algèbre linéaire en analysant l'effet.

Deux script sont disponible pour tester l'effet. IsBetterTraveling et Traveling. Ils sont tout les deux sur la caméra. Activer celui que vous voulez tester !