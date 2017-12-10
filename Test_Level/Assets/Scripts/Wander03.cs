using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wander03 : MonoBehaviour {

public float moveSpeed = 15f;
    public bool ready;

    void Start()
    {
        ready = true;
    }

        void MoveFoward () {
    transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);

}

IEnumerator Turn() {
        ready = false;
        yield return new WaitForSeconds(5);
        ready = true;
        int randomNum = Random.Range(0,360);

    transform.Rotate(0,randomNum,0);

}
    private void Update()
    {
        if(ready == true)
        {
            StartCoroutine(Turn());
        }
        MoveFoward();
    }
    //void OnTriggerStay(Collider other){
    //if(other.gameObject.tag == "CheckPoint"){
       // Turn();

    //}
    //else{
       // MoveFoward();
    }
//}

//}
