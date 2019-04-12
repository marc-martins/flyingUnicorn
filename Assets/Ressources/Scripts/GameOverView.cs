using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverView : GameElement
{
    public GameObject goText;

	void Start ()
    {
        goText.SetActive(false); // a mensagem GAME OVER é escondida
    }

    public void DisplayGameOver()
    {
        goText.SetActive(true); // a mensagem GAME OVER fica activa
    }
}
