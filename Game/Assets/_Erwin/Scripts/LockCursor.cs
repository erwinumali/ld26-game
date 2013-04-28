using UnityEngine;
using System.Collections;

// from http://docs.unity3d.com/Documentation/ScriptReference/Screen-lockCursor.html
public class LockCursor : MonoBehaviour {
    void DidLockCursor() {
        Debug.Log("Locking cursor");
    }
    void DidUnlockCursor() {
        Debug.Log("Unlocking cursor");
    }
	
    private bool wasLocked = false;
	
    void Update() {
        if (Input.GetKeyDown("escape"))
            Screen.lockCursor = false;
		
		if (Input.GetMouseButtonDown(0) ||
			Input.GetMouseButtonDown(1) ||
			Input.GetMouseButtonDown(2)){
			Screen.lockCursor = true;
		}
        
        if (!Screen.lockCursor && wasLocked) {
            wasLocked = false;
            DidUnlockCursor();
        } else
            if (Screen.lockCursor && !wasLocked) {
                wasLocked = true;
                DidLockCursor();
            }
    }
}
