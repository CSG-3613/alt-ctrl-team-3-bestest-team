using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroScene : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}