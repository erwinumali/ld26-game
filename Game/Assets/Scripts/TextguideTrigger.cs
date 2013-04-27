using UnityEngine;
using System.Collections;

public class TextguideTrigger : MonoBehaviour {
	public GameObject source;
	public string message;
	public bool repeatTrigger;

	void doActivateTrigger(Collider obj) {
		TextMesh tm = obj.transform.GetComponentInChildren<TextMesh>();
		tm.text = message;
	}

	void OnTriggerEnter(Collider obj) {
		if (obj.gameObject == source) {
			doActivateTrigger(obj);
		}
	} 
}
