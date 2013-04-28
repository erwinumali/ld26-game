using UnityEngine;
using System.Collections;

public class Footsteps : MonoBehaviour {
	
	private AudioSource _stepSoundPlayer;
    public AudioClip _randomStepSounds;
	// Update is called once per frame
 
    void Start(){
       _stepSoundPlayer=gameObject.GetComponent<AudioSource>();  
    }
 
    void Update(){
		//sample pa lang to mga sir
		if(Input.GetKey(KeyCode.W)){
			if(!_stepSoundPlayer.isPlaying) _stepSoundPlayer.Play();
		}
		//uncomment if gusto nyo ng stop / pause
		/*
		else{
			//_stepSoundPlayer.Pause();
			_stepSoundPlayer.Stop();
		}
		*/
    }
	
}
