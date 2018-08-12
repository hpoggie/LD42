using UnityEngine;
using FuckingSingletons.ScriptableObjects.Primitives;

public class Ability : ScriptableObject {
	public SOFloatReference cooldown;
	private bool firstUse = true;

	private float lastTimeUsed;

	public bool Usable {
		get {
			return Time.time - lastTimeUsed > cooldown || firstUse;
		}
	}

	public float RemainingTime {
		get {
			return cooldown - (Time.time - lastTimeUsed);
		}
	}

	public void Reset () {
		firstUse = true;
	}

	public virtual void Use (Vector3 target) {
	}

	protected void OnUsed () {
		lastTimeUsed = Time.time;
		firstUse = false;
	}
}
