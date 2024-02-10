using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRLocomotion : MonoBehaviour
{
    public Transform vrPlayer;
    public float moveAngle = 25.0F;
    public int moveSpeed = 10;

    public bool moveForward;

    private CharacterController cc;

    // Start is called before the first frame update
    void Start()
    {
        // cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(vrPlayer.eulerAngles.x >= moveAngle && vrPlayer.eulerAngles.x < 90.0f){
            moveForward = true;
        }else{
            moveForward = false;
        }

        if(moveForward){
            // Vector3 forward = vrPlayer.TransformDirection(Vector3.forward);
            transform.position = transform.position + Camera.main.transform.forward * moveSpeed * Time.deltaTime;
        }
        // if(Input.GetButton("Fire1")){
            // transform.position = transform.position + Camera.main.transform.forward * moveSpeed * Time.deltaTime;
        // }
    }
}
