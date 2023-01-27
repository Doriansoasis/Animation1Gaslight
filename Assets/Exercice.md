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



## 3

En conservant un ratio 16:9, dupliquez et modifiez la matrice *OrthoMatrix* en modifiant les deux valeurs supérieures de la dernière colonne (demeurez dans la plage ±1). Que constatez-vous? Qu'arrive-t-il si vous modifiez la troisième valeur de cette colonne? Qu'en est-il de la dernière valeur?

## 4

Dupliquez et modifiez la matrice *OrthoMatrix*, appliquez  les valeurs "-0.2" et "-0.8" aux deux valeurs supérieures de la dernière colonne, et ajoutez les valeurs "-0.01" et "-0.0178" aux deux valeurs supérieures de la troisième colonne. Que constatez-vous?

## 5

Désactivez la caméra *Exercice/Camera* et activez la caméra *Exercice/Camera (1)*. Ajoutez un script au projet, à ajouter sur cette dernière caméra, où vous implémenterez un effet de [Travelling Contrarié](https://fr.wikipedia.org/wiki/Travelling_contrari%C3%A9) centré sur le personnage. Il existe plusieurs références sur le web pour des algorithmes (incluant la page anglaise de l'article ci-dessus), mais vous devriez être en mesure de déduire un algorithme à l'aide d'un peu d'algèbre linéaire en analysant l'effet.