using UnityEngine;

public class HoopsGenerator : MonoBehaviour {

    public GameObject Hoop;
    public Transform end;
    public Transform Player;

    public int numberOfHoops = 10000;
    public float levelWidth = 3f;
    public float minY = .02f;
    public float maxY = 1f;
   // public float minZ = 10f;
   // public float maxZ = 5223f;

    // Use this for initialization
    void Start () {

        Vector3 spawnPosition = new Vector3(0, 1, 0);
        
        for (int i = 0; i < numberOfHoops; i++)
        {
            spawnPosition.z += Random.Range(Player.position.z, end.position.z);
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(Hoop, spawnPosition, Quaternion.identity);
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
