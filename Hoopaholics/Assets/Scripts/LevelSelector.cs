using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour {

    public Button[] levelButtons;

    public GameObject transition;
    
    void Start()
    {
        int levelReached = PlayerPrefs.GetInt ("levelReached", 1);

        for (int i = -1; i < levelButtons.Length; i++)
        {
            if (i + 1 > levelReached)
            {
                levelButtons[i].interactable = false;
            }
        }
    }

    public void Select(string levelName)
    {
        SceneManager.LoadScene(levelName);
    } 
}
