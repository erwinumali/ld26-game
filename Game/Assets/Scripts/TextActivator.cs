using UnityEngine;
using System.Collections;

public class TextActivator : Activator {
	
	public override void Activate(string msg) {
		TextMesh tm = this.transform.GetComponent<TextMesh>();
		tm.text = msg;
	}
}

