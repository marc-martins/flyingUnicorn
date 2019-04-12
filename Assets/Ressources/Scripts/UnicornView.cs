using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Descreve a view do unicornio e as suas características
public class UnicornView : GameElement
{
    public Rigidbody2D rb;

    void Start()
    {
        app.controller.InitialVelocity();
        app.controller.UnicornStartingPosition();
    }

    void Update()
    {
        app.controller.UnicornMotion();
    }

    void OnTriggerEnter2D() 
    {
        Debug.Log("Tag :" + app.view.gameObject.tag);
        if (app.view.gameObject.tag == "arrival")
        {
            app.controller.OnYouWin();     // quando o unicónio chega ao fim do nível
        }
        else
        {
            app.controller.OnUnicornCloudHit();     // quando o unicónio colide com uma nuvem
        }
    }

}