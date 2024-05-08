using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScene : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("Intro");
    }
}