using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour {
	public Ability[] Abilities;

	private NavMeshAgent _agent;

	bool MouseRay (out RaycastHit hit) {
		return Physics.Raycast(
			Camera.main.ScreenPointToRay(Input.mousePosition),
			out hit,
			Mathf.Infinity);
	}

	void Start () {
		_agent = GetComponent<NavMeshAgent>();
		foreach (Ability ab in Abilities) {
			ab.Reset();
		}
	}

	void Update () {
		RaycastHit hit;
		if (MouseRay(out hit)) {
			if (Input.GetMouseButton(1)) {
				_agent.destination = hit.point;
			}

			if (Input.GetMouseButtonDown(0)
					&& hit.collider.gameObject.CompareTag("Ground")) {
				Abilities[0].Use(hit.point);
			}
		}
	}
}
