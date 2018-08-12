using UnityEngine;
using UnityEngine.UI;

public class CooldownTimer : MonoBehaviour {
    public Ability TrackedAbility;

	void Update () {
		GetComponent<Text>().text = TrackedAbility.RemainingTime.ToString();
    }
}
