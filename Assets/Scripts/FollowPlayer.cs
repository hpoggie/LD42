using UnityEngine;
using UnityEngine.AI;

public class FollowPlayer : MonoBehaviour {
	private GameObject _player;
	private UnityEngine.AI.NavMeshAgent _agent;

	// Use this for initialization
	void Start () {
		_player = GameObject.FindWithTag("Player");
		_agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
	}

	// Update is called once per frame
	void Update () {
		_agent.destination = _player.transform.position;
	}
}
