using UnityEngine;
using UnityEngine.SceneManagement;

public class OutroScene : MonoBehaviour
{
    public void NextsScene()
    {
        SceneManager.LoadScene("MainMenu");
    }
}