using UnityEngine;

public class SpawnCubes : MonoBehaviour {
	public GameObject obj;
	public float SpawnDelay;
	public float SpawnInterval;
    public float SpawnIntervalDecreaseRate;

    private bool hasSpawned;
    private float timer;

	void Update () {
		timer += Time.deltaTime;
        if ((hasSpawned && timer > SpawnInterval) 
            || (!hasSpawned && timer > SpawnDelay))
        {
            timer = 0;
            Spawn();
            SpawnInterval *= SpawnIntervalDecreaseRate;
            hasSpawned = true;
        }
	}

	void Spawn () {
		Instantiate(obj, transform.position, transform.rotation);
	}
}
