using UnityEngine;

public class RamUser : MonoBehaviour {
	Texture2D tex;
	void Start () {
		GetComponent<Renderer>().material.mainTexture = tex = new Texture2D(4096, 4096);
	}

	void OnDestroy() {
		Destroy(tex);
	}
}
