using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class BlockScaler : MonoBehaviour
{
    void OnRenderObject()
    {
        Rigidbody2D selfrb = this.GetComponent<Rigidbody2D>();
        this.transform.localScale = Mathf.Pow(selfrb.mass, 0.5f) * Vector3.one;
    }
}
