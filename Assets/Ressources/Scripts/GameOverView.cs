using System;
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
            throw new GameOverViewFailure("goText");
        }
    }
}

//Criação duma excepção personalizada
class GameOverViewFailure:Exception
{
    public GameOverViewFailure()
    {

    }
    public GameOverViewFailure(string name): base(String.Format("Game over View not displayed!", name))
    {

    }
}
