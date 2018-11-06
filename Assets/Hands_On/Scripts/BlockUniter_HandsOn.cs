using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockUniter_HandsOn : MonoBehaviour
{
    //コライダー内にオブジェクトが入ると実行される。入った相手のオブジェクトはcolsとする
    private void OnCollisionEnter2D(Collision2D cols)
    {
        //このスクリプトがアタッチされているオブジェクト(newBlock)の色を取得
        Color selfColor = this.transform.GetComponent<Renderer>().material.color;
        //Collider内に入った相(cols)の色を取得
        Color oppoColor = cols.transform.GetComponent<Renderer>().material.color;

        //生成時に自動付与されたIDを取得
        int selfID = this.gameObject.GetInstanceID();
        int oppoID = cols.gameObject.GetInstanceID();

        //同色　かつ　IDが大きいときに合体させる
        if (selfColor == oppoColor && selfID >= oppoID)
        {
            //２つのオブジェクトの中点を計算し、移動する
            //this.transform.position = 

            //Rigidbody2Dコンポーネントを取得する
            Rigidbody2D selfrb = this.GetComponent<Rigidbody2D>();
            Rigidbody2D opporb = cols.transform.GetComponent<Rigidbody2D>();

            //相手の質量を、自分の質量に足す(selfrb、opporbを利用できる)
            //

            //衝突"相手"を消去する
            //Destroy();

        }
    }
}
