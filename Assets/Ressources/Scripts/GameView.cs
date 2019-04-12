using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Contém todas as views relacionadas com o jogo
public class GameView : GameElement
{
    // Referência às partes gráficas activas do jogo (unicónio e textos)
    public UnicornView unicorn;
 //   public BackgroundView background;
    public GameOverView gameOverText;
    public YouWinView youWinText;
}
