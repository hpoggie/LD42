using UnityEngine;

public class KillEnemyOnContact : MonoBehaviour {
	void OnTriggerEnter (Collider col) {
        if (col.gameObject.CompareTag("Enemy"))
        {
            Destroy(col.gameObject);
        }
    }
}
