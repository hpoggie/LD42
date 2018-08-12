using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RamUsageTracker : MonoBehaviour {
	void Update () {
		var bts = System.GC.GetTotalMemory(false);
		GetComponent<Text>().text = (bts / 8589935000.0f).ToString();
	}
}
