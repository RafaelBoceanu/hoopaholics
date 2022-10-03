using UnityEngine;
using UnityEngine.SceneManagement;

public class ReplayGame : MonoBehaviour
{ 
    public void Replay()
    {
        SceneManager.LoadScene("Menu");
    }
}
