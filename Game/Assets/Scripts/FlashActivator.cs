using UnityEngine;
using System.Collections;

public class FlashActivator : Activator {
	public bool isActive;
	private float limit = 150.0f;
	private float newRange;
	private Light light;

	public override void Activate() {
		isActive = true;
	}

	public override void Deactivate() {
		isActive = false;
	}

	void Start () {
		light = this.transform.GetComponentInChildren<Light>();
		newRange = light.range;
	}
	// Update is called once per frame
	void Update () {
		if (isActive) {
			if (newRange < limit) {
				newRange += 100.0f * Time.deltaTime;
				light.range = newRange;
			}
			else {
				Application.LoadLevel (0);
			}
		}
	}
}
