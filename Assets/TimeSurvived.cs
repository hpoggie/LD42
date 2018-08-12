using UnityEngine;
using UnityEngine.UI;

public class TimeSurvived : MonoBehaviour {
    void Update () {
        // https://answers.unity.com/questions/326311/formatting-a-tostring-for-time.html
        var timeSeconds = (int)Time.time;
		GetComponent<Text>().text = string.Format("You survived {0:00}:{1:00}", timeSeconds / 60, timeSeconds % 60);
	}
}
