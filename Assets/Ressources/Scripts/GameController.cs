using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Controla o workflow do jogo
public class GameController : GameElement
{
    public void InitialVelocity()
    {
          app.view.unicorn.rb.velocity += new Vector2(app.model.gameSpeed, 0);
    }

    public void UnicornMotion()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            app.view.unicorn.rb.velocity += new Vector2(0, -app.model.gameSpeed);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            app.view.unicorn.rb.velocity += new Vector2(0, app.model.gameSpeed);
        }
    }

    public void UnicornStartingPosition()
    {
        app.view.unicorn.transform.position = new Vector3(app.view.unicorn.transform.position.x - 11, 0, -1);
 
    }

    // Quando o unicornio colide com uma nuvem
    public void OnUnicornCloudHit()
    {
        app.model.playerLives--; // tira uma vida ao player caso colide com uma nuvem
        Debug.Log("Lives : " + app.model.playerLives);
        if (app.model.playerLives<0) OnGameOver(); // se não houver mais vidas, o jogo acaba
    }

    // Fim do jogo por colisão
    public void OnGameOver()
    {
        try
        {
            app.view.unicorn.rb.velocity = Vector2.zero; ; // para o unicórnio
            app.view.gameOverText.DisplayGameOver(); // pede a view para fazer o display do texto GAME OVER
            Debug.Log("GAME OVER!");
        }
        catch(GameOverViewFailure ex)
        {
            Debug.Log(ex.Message);
        }
    }

    public void OnYouWin()
    {
        app.view.unicorn.rb.velocity = Vector2.zero; ; // para o unicórnio
        app.view.youWinText.DisplayYouWin(); // pede a view para fazer o display do texto GAME OVER
        Debug.Log("YOU WIN!");
    }
}

