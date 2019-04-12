using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouWinView : GameElement
{
    public GameObject ywText;

    void Start()
    {
        ywText.SetActive(false); // a mensagem YOU WIN é escondida
    }

    public void DisplayYouWin()
    {
        ywText.SetActive(true); // a mensagem YOU WIN fica activa
    }
}
