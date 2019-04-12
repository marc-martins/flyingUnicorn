using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// GameApplication.cs

// classe base para todos os elementos do jogo
public class GameElement : MonoBehaviour
{
    // Dá acesso ao jogo e a todas as intâncias
    public GameApplication app 
    {
        get
        {
            return GameObject.FindObjectOfType<GameApplication>();
        }
    }
}

// Ponto de entrada do jogo
public class GameApplication : MonoBehaviour
{
    // Referência às instâncias raízes da arquitectura MVC
    public GameModel model;
    public GameView view;
    public GameController controller;

    // Inicialização
    void Awake()
    {

    }
}
