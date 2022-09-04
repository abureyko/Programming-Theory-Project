using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public bool gameOver = false;
    public static GameManager Instance;
    public TextMeshProUGUI gameoverText;
    
    private void Awake()
    {
        Instance = this;
    }

    void Update()
    {
        if (gameOver)
        {
            gameoverText.gameObject.SetActive(true);
            ReturnToMenu();
        }
    }

    private void ReturnToMenu()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneLoader.LoadMenuScene();
        }
    }
}
