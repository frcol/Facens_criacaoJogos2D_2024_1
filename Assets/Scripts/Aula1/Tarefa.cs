using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Enum_Estados
{
    PLAYING,
    PAUSE,
    GAMEOVER,
    WIN
}

public class Tarefa : MonoBehaviour
{
    public Enum_Estados state = Enum_Estados.PLAYING;
    public int pontos = 0;

    public GameObject[] arShips;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            state = Enum_Estados.PLAYING;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            state = Enum_Estados.PAUSE;
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            state = Enum_Estados.GAMEOVER;
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            pontos += 1;

            if (pontos > 5)
            {
                print("YOU WIN");
                state = Enum_Estados.WIN;
            }
        }

        switch (state)
        {
            case Enum_Estados.PLAYING:
                if (Input.GetKeyDown(KeyCode.D))
                {
                    foreach (GameObject go in arShips)
                    {
                        Destroy(go);
                    }
                }
                print("Jogando...");
                break;
            case Enum_Estados.PAUSE:
                print("Em pausa!!!");
                break;
            case Enum_Estados.GAMEOVER:
                print("GAME OVER");
                break;
        }

    }

}
