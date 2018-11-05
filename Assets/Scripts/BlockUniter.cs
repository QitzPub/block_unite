using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockUniter : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D cols)
    {
        Color selfColor = this.transform.GetComponent<Renderer>().material.color;
        Color oppoColor = cols.transform.GetComponent<Renderer>().material.color;

        int selfID = this.gameObject.GetInstanceID();
        int oppoID = cols.gameObject.GetInstanceID();

        if(selfColor == oppoColor && selfID >= oppoID){
            this.transform.position = (this.transform.position + cols.transform.position)/2;

            Rigidbody2D selfrb = this.GetComponent<Rigidbody2D>();
            Rigidbody2D opporb = cols.transform.GetComponent<Rigidbody2D>();

            selfrb.mass += opporb.mass;

            Destroy(cols.gameObject);

        }
    }
}
