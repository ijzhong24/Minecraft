using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeGenerator : MonoBehaviour
{
    public GameObject trunkBlock;
    public GameObject leavesBlock;

    public int minHeight = 5;
    public int maxHeight = 12;

    // Start is called before the first frame update
    void Start()
    {
        // place trunk
        Vector3Int growPoint = new Vector3Int(3, 1, -3);
        Instantiate(trunkBlock, growPoint, Quaternion.identity);

        // randomize total height
        int height = Random.Range(minHeight, maxHeight + 1);

        // grow straight up to height
        for (int i = growPoint.y; i < growPoint.y + height; i++)
        {
            growPoint += new Vector3Int(0, 1, 0);
            Instantiate(trunkBlock, growPoint, Quaternion.identity);
            //    // Randomly grow branches 10% chance at each trunk segment
            ////    if (Random.Range(0f, 1f) > .9f)
            ////    {
            ////        // choose direction of branch
            ////        // 0 - forward, 1 - right, 2 - back, 3 - left
            ////        int branchDir = Random.Range(0, 4);
            ////        // create growthVector
            ////        Vector3Int branchGrowthVector = new Vector3Int();
            ////        switch(branchDir)
            ////        {
            ////            case 0:
            ////                branchGrowthVector = new Vector3Int(0, 0, 1);
            ////                break;
            ////            case 1:
            ////                branchGrowthVector = new Vector3Int(1, 0, 0);
            ////                break;
            ////            case 2:
            ////                branchGrowthVector = new Vector3Int(0, 0, -1);
            ////                break;
            ////            case 3:
            ////                branchGrowthVector = new Vector3Int(-1, 0, 0);
            ////                break;
            ////        }
            ////        // place branch start
            ////        Vector3Int branchStart = growPoint + branchGrowthVector;
            ////        Instantiate(trunkBlock, branchStart, Quaternion.identity); 

            ////        // determine length of branch
            ////        int branchLength = Random.Range(3, maxHeight - minHeight);

            ////        // grow branch
            ////        while (branchLength > 0)
            ////        {
            ////            // set prevDir to opposite prev branch growth
            ////            // prevent choosing the branch to grow backwards into itself
            ////            int prevDir = branchDir - 2 >= 0 ? branchDir - 2 : branchDir + 2;

            ////            // choose direction of branch
            ////            // 0 - forward, 1 - right, 2 - back, 3 - left
            ////            branchDir = Random.Range(0, 4);
            ////            while (prevDir == branchDir)
            ////            {
            ////                branchDir = Random.Range(0, 4);
            ////            }

            ////            switch (branchDir)
            ////            {
            ////                case 0:
            ////                    branchGrowthVector = new Vector3Int(0, 0, 1);
            ////                    break;
            ////                case 1:
            ////                    branchGrowthVector = new Vector3Int(1, 0, 0);
            ////                    break;
            ////                case 2:
            ////                    branchGrowthVector = new Vector3Int(0, 0, -1);
            ////                    break;
            ////                case 3:
            ////                    branchGrowthVector = new Vector3Int(-1, 0, 0);
            ////                    break;
            ////            }
            ////            branchStart = branchStart + branchGrowthVector;
            ////            Instantiate(trunkBlock, branchStart, Quaternion.identity);
            ////            branchLength--;
            ////        }
            ////        // place leaves on branch
            ////        for (int x = branchStart.x; x < branchStart.x + 2; x++)
            ////        {
            ////            for (int y = branchStart.y; y < branchStart.y + 2; y++)
            ////            {
            ////                for (int z = branchStart.z ; z < branchStart.z + 2; z++)
            ////                {
            ////                    Vector3Int leafPlacement = new Vector3Int(x, y, z);
            ////                    Instantiate(leavesBlock, leafPlacement, Quaternion.identity);
            ////                }
            ////            }
            ////        }

            ////    }
        }

        //// place some leaves on top
        ////for (int x = growPoint.x - 1; x < growPoint.x + 1; x++)
        ////{
        ////    for (int y = growPoint.y + 1; y < growPoint.y + 2; y++)
        ////    {
        ////        for (int z = growPoint.z - 1; z < growPoint.z + 1; z++)
        ////        {
        ////            Vector3Int leafPlacement = new Vector3Int(x, y, z);
        ////            Instantiate(leavesBlock, leafPlacement, Quaternion.identity);
        ////        }
        ////    }
        ////}
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
