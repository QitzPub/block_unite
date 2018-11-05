using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class BlockGenerator : MonoBehaviour
{
    [SerializeField] GameObject Block;
    GameObject newBlock;
    [SerializeField] Transform BlockContainer;
    [SerializeField] int InitialSpawnNumber;
    [SerializeField] int FeverSpawnNumber;

    // Start is called before the first frame update
    void Start()
    {
        InitialSpawn();
    }
    Vector3 SpawnPosition(){
        Vector3 position;
        position.x = UnityEngine.Random.Range(-3, 3);
        position.y = UnityEngine.Random.Range(3, 9);
        position.z = 0;
        return position;
    }
    Color BlockColor(){
        return MasterData.ColorList.OrderBy(i => Guid.NewGuid()).First();
    }
    public void SpawnOnce(){
        newBlock = Instantiate(Block);
        newBlock.transform.SetParent(BlockContainer);
        newBlock.transform.localPosition = SpawnPosition();
        newBlock.GetComponent<Renderer>().material.color = BlockColor();
    }
    void InitialSpawn(){
        for (int i = 0; i < InitialSpawnNumber; i++){
            SpawnOnce();
        }
    }
    public void SpawnManyTimes(){
        for (int i = 0; i < FeverSpawnNumber; i++)
        {
            SpawnOnce();
        }
    }
}
