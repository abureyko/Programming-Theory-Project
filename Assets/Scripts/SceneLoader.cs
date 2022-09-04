using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public static void LoadMainScene()
    {
        SceneManager.LoadScene(1);
    }

    public static void LoadMenuScene()
    {
        SceneManager.LoadScene(0);
    }
}
