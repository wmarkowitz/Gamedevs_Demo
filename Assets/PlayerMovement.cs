using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Movement
    private float spd = 10;
    private float moveBuff = 5;
    private Vector3 moveStore;

    void Update()
    {
        moveStore += new Vector3(Input.GetAxisRaw("Horizontal") * Time.deltaTime * spd,
                                 Input.GetAxisRaw("Vertical") * Time.deltaTime * spd, 0);

        // More precise "jerky" movement
//      Vector3 moveDelta =  	new Vector3(Input.GetAxisRaw("Horizontal") * Time.deltaTime * spd,
//                    			Input.GetAxisRaw("Vertical") * Time.deltaTime * spd, 0);
        
		// More fluid "floaty" movement
        Vector3 moveDelta = moveStore * Time.deltaTime * moveBuff;
        transform.position += moveDelta;
        
        // removing this creates ice physics
        moveStore -= moveDelta;


		//Shooting
		//Defensea
		//Pause/Menu

    }
}