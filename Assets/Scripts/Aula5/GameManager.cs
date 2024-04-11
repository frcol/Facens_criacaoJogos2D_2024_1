using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    #region Singleton
    public static GameManager Instance;

    void Awake()
    {
        if (!Instance)
        {
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    #endregion

    public SO_GameData gameData;
    public EnemyManager5 enemyManager;

    public void SetScore(int value)
    {
        gameData.score += value;
    }

    public void DestroyAllEnemies()
    {
        enemyManager.DestroyAll();
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
