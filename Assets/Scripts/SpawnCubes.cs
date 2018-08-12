using UnityEngine;

public class SpawnCubes : MonoBehaviour {
	public GameObject obj;
	public float SpawnDelay;
	public float SpawnInterval;

	void Start () {
		InvokeRepeating("Spawn", SpawnDelay, SpawnInterval);
	}

	void Spawn () {
		Instantiate(obj, transform.position, transform.rotation);
	}
}
