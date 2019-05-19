using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Controla o workflow do jogo
public class GameController : GameElement
{
    public GameModel.IUnicornModel UnicornModel = GameModel.Animals.GiveMeAUnicorn();
        
    public void InitialVelocity()
    {
        app.view.unicorn.rb.velocity += new Vector2(UnicornModel.Speed, 0);
    }

    public void UnicornMotion()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            app.view.unicorn.rb.velocity += new Vector2(0, -UnicornModel.Speed);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            app.view.unicorn.rb.velocity += new Vector2(0, UnicornModel.Speed);
        }
    }

    public void UnicornVelocity()
    {
        if (Input.GetKeyDown(KeyCode.KeypadPlus))
        {
            app.view.unicorn.rb.velocity += new Vector2(UnicornModel.Accelerate(),0);
        }
        else if (Input.GetKeyDown(KeyCode.KeypadMinus))
        {
            app.view.unicorn.rb.velocity += new Vector2(-UnicornModel.Decelerate(),0);
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
            Application.Quit();
        }
    }

    public void OnYouWin()
    {
        app.view.unicorn.rb.velocity = Vector2.zero; ; // para o unicórnio
        app.view.youWinText.DisplayYouWin(); // pede a view para fazer o display do texto GAME OVER
        Debug.Log("YOU WIN!");
    }
}

