using UnityEngine;
using System.Collections;

public class ActivatorTrigger : MonoBehaviour {
	public GameObject source;
	public GameObject activatorObject;
	public bool repeatTrigger;

	void Start() {
		if (source == null) {
			source = activatorObject;
		}
	}

	void doActivateTrigger() {
		//Debug.Log("entered");
		Activator act = source.transform.GetComponent<Activator>();
		//if (act != null) {
		act.Activate();
		//}
	}

	void OnTriggerEnter(Collider obj) {
		
		if (obj.gameObject == activatorObject) {
			doActivateTrigger();
		}
	} 
}
