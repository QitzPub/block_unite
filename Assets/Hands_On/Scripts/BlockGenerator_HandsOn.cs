using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BlockGenerator_HandsOn : MonoBehaviour
{
    //SerializeFieldが必要な変数を特定し、記述して設定する
    GameObject Block;
    GameObject newBlock;
    Transform BlockContainer;
    int InitialSpawnNumber;
    int FeverSpawnNumber;

    // ゲーム開始時にこの中の関数が実行される
    void Start()
    {
        InitialSpawn();
    }
    //位置(x,y,z)を取得する関数
    Vector3 SpawnPosition(){
        Vector3 position;
        //x,y座標を適切に再設定する
        position.x = 5000000000000000;
        position.y = 5000000000000000;
        position.z = 0;
        return position;
    }
    //色情報を取得する関数
    Color BlockColor(){
        //MasterDataのColorListの中から１色を返す
        return MasterData.ColorList.OrderBy(i => Guid.NewGuid()).First();
    }
    //ブロック１つを生成する関数
    public void SpawnOnce(){
        //ブロックプレハブ(Block)をインスタンス化し、クローン(newBlock)とする
        //newBlock = 

        //BlockContainerを親オブジェクトに設定する
        //newBlock.transform.

        //SpawnPosition関数を利用し、生成位置を設定する
        //newBlock.transform.

        //BlockColor関数を利用して、Rendererの色を変更する
        //newBlock.
    }
    void InitialSpawn(){
        //InitialSpawnNumberの回数だけ、ブロックを生成する（SpawnOnce関数を実行する）
        //for ()
        //{

        //}
    }
    public void SpawnManyTimes(){
        //FeverSpawnNumberの回数だけ、ブロックを生成する（SpawnOnce関数を実行する）
        //for ()
        //{

        //}
    }
}
