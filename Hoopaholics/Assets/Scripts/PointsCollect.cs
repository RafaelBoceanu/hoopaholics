using UnityEngine;

public class PointsCollect : MonoBehaviour {

    public GameObject coinSprite1;
    public GameObject coinSprite2;
    public GameObject coinSprite3;


    private void OnTriggerEnter(Collider other)
    {
        Score.points += 1;
        Destroy(gameObject);

        if (Score.points == 1)
        {
            coinSprite1.SetActive(true);
        }
        if (Score.points == 2)
        {
            coinSprite2.SetActive(true);
        }
        if (Score.points == 3)
        {
            coinSprite3.SetActive(true);
        }

    }
}
