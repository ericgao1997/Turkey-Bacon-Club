using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class collisionDD : MonoBehaviour {

    void Start(){
    }

    bool in_ring(int r){
        return (    System.Math.Sqrt(
                                        System.Math.Pow((transform.position.x),2) + 
                                        System.Math.Pow((transform.position.y),2)
                                    ) <= 
                                        r
                );
    }

    void Update(){
        if (in_ring(5)){
            Debug. Log ("In!");
            gameObject.GetComponent<Renderer>().enabled = false;
			hpManager.health--;
            Destroy(gameObject);


        }
    }

    // void OncollisionEnter(){
    //     GetComponent<Renderer> ().enabled = false;
    //     Destroy (this);
    // }
}