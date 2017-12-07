using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wander03 : MonoBehaviour {

public float moveSpeed = 15f;

void MoveFoward () {
    transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);

}

void Turn() {
    int randomNum = Random.Range(0,350);
    transform.Rotate(0,randomNum,0);

}

void OnTriggerStay(Collider other){
    if(other.gameObject.tag == "CheckPoint"){
        Turn();

    }
    else{
        MoveFoward();
    }
}

}
