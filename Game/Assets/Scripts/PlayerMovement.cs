using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
     
    public float speed = 3.0f;

    void Update (){
        Movement();
    }
     
    void Movement ( ){
        //Player object movement
        float horMovement = Input.GetAxisRaw("Horizontal");
        float vertMovement = Input.GetAxisRaw("Vertical");

        transform.Translate(-transform.right * horMovement * Time.deltaTime * speed);
        transform.Translate(transform.forward * vertMovement * Time.deltaTime * speed);
         
        //Player graphic rotation
        Vector3 moveDirection= new Vector3 (horMovement, 0, vertMovement);

        if (moveDirection != Vector3.zero){
            Quaternion newRotation = Quaternion.LookRotation(moveDirection);
            transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, Time.deltaTime * 8);
        }
 
    }
}