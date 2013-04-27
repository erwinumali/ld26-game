using UnityEngine;
using System.Collections;

public class TextActivatorTrigger : MonoBehaviour {
	public GameObject source;
	public GameObject activatorObject;
	public string message;
	public bool repeatTrigger;

	void Start() {
		if (source == null) {
			source = activatorObject;
		}
	}

	void doActivateTrigger() {
		Activator act = source.transform.GetComponent<Activator>();
		if (act != null) {
			act.Activate(message);
		}
	}

	void OnTriggerEnter(Collider obj) {
		if (obj.gameObject == activatorObject) {
			doActivateTrigger();
		}
	} 
}
