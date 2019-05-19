using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

//interface que recupera os dados para controlo


// Dados do model
public class GameModel : GameElement
{
    public int playerLives = 1;

    static public class Animals 
    {
        static public IUnicornModel GiveMeAUnicorn() 
        {
            IUnicornModel UnicornModel = new UnicornSpeed();
            return UnicornModel;
        }
    }


    public interface IUnicornModel
    {
        float Speed { get; set; }
        float Accelerate();
        float Decelerate();
    }

    public class UnicornSpeed : IUnicornModel
    {
        public float gameSpeed = 0.4f;

        public float Speed
        {
            get
            {
                return this.gameSpeed;
            }
            set
            {
                gameSpeed = value;
            }
        }

        public float Accelerate()
        {
            gameSpeed = gameSpeed + 0.1f;
            return gameSpeed;
        }

        public float Decelerate()
        {
            gameSpeed = gameSpeed - 0.1f;
            return gameSpeed;
        }
    }

}

