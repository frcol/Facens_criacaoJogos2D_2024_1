using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Enum_Estados_Jogo
{
    PLAYING,
    PAUSE,
    GAMEOVER,
    INVENTARIO
}

public class Player : MonoBehaviour
{
    public Enum_Estados_Jogo state = Enum_Estados_Jogo.PLAYING;
    public int vida = 5;

    private void Start()
    {
        /* int x = 0;
        
        while(x <= 100)
        {
            print(x);
            x++;
        }*/

        for (int i = 0; i <= 1000; i++)
        {
            print(i);
        }
    }

    private void Update()
    {
        TestaVida();

        if (Input.GetKeyDown(KeyCode.Q))
        {
            state = Enum_Estados_Jogo.PLAYING;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            state = Enum_Estados_Jogo.PAUSE;
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            state = Enum_Estados_Jogo.GAMEOVER;
        }
        else if (Input.GetKeyDown(KeyCode.I))
        {
            state = Enum_Estados_Jogo.INVENTARIO;
        }

        switch (state)
        {
            case Enum_Estados_Jogo.PLAYING:
                print("Jogando...");
                break;
            case Enum_Estados_Jogo.PAUSE:
                print("Em pausa!!!");
                break;
            case Enum_Estados_Jogo.GAMEOVER:
                print("GAME OVER");
                break;
            case Enum_Estados_Jogo.INVENTARIO:
                print("INVENTARIO ABERTO");
                break;
        }

    }

    private void TestaVida()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            vida--;

            if (vida <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
