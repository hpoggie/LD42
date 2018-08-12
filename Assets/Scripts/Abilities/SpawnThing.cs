using UnityEngine;

[CreateAssetMenu(menuName = "Abilities/Spawn")]
public class SpawnThing : Ability {
	public GameObject Prefab;

	public override void Use (Vector3 target) {
		if (Usable) {
			var ob = Instantiate(Prefab,
				target,
				Quaternion.identity);
			base.OnUsed();
		} else {
			Debug.Log("On cooldown. " + RemainingTime);
		}
	}
}
