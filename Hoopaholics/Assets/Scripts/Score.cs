using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public static int points = 0;
    public Text scoreText;

    void Start()
    {
        scoreText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update ()
    {
        scoreText.text = points.ToString();
	}
}
