using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Loader : MonoBehaviour {

	void Start () {
		GetComponent<Button>().onClick.AddListener(Load);
	}
	
	void Load () {
		SceneManager.LoadScene(1);
	}
}
