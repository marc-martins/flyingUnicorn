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
        try // gestão de erros
        {
            goText.SetActive(true); // a mensagem GAME OVER fica activa
        }
        catch
        {
            Debug.Log("Game over View not displayed!");
        }
    }
}
