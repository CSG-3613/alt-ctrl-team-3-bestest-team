using UnityEngine;
using UnityEngine.SceneManagement;

public class GameScene : MonoBehaviour
{
    public void NextsScene()
    {
        SceneManager.LoadScene("MainMenu");
    }
}