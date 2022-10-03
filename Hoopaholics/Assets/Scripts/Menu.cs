using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    public string levelToLoad = "Level1";

    public SceneFader sceneFader;

    public void StartGame()
    {
        sceneFader.FadeTo(levelToLoad);
        PlayerPrefs.DeleteAll();
    }

    public void Levels()
    {
        sceneFader.FadeTo("LevelSelector");
    }

}
