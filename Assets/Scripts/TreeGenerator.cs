using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeGenerator : MonoBehaviour
{
    public GameObject trunkBlock;
    public GameObject leavesBlock;

    // Start is called before the first frame update
    void Start()
    {
        Vector3Int growPoint = new Vector3Int(3, 1, -3);
        GameObject block = Instantiate(trunkBlock, growPoint, trunkBlock.transform.rotation);
        growPoint += new Vector3Int(0, 1, 0);
        block = Instantiate(trunkBlock, growPoint, trunkBlock.transform.rotation);
        growPoint += new Vector3Int(-1, 0, 0);
        Instantiate(trunkBlock, growPoint, trunkBlock.transform.rotation);
        int num = Random.Range(0, 10);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
