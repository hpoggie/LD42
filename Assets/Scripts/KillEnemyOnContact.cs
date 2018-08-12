using UnityEngine;

public class KillEnemyOnContact : MonoBehaviour {
	void OnTriggerEnter (Collider col) {
		Destroy(col.gameObject);
	}
}
