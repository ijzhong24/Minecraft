using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeGenerator : MonoBehaviour
{
    [SerializeField] GameObject trunkPrefab;
    [SerializeField] GameObject leafPrefab;

    // Start is called before the first frame update
    void Start()
    {
        GrowTree(new Vector3Int(3, 0, 3));
        GrowTree(new Vector3Int(-2, 0, 5));

        int x, y, z;

       

        for (int i = 0; i < 30; i++)
        {
            x = Random.Range(-40, 40);
            y = 0;
            z = Random.Range(-40, 40);
            GrowTree(new Vector3Int(x, y, z));
        }

    }

    // Update is called once per frame
    void Update()
    {
   

    }

    void GrowTree(Vector3Int pos)
    {
        Vector3Int growPos = pos;
        GameObject tree = new GameObject("Tree");
        tree.transform.position = growPos;
        GameObject leaf = new GameObject("Leaf");
        
        int height = Random.Range(5, 15);
        Vector3Int[] branchDirections = { Vector3Int.forward, Vector3Int.right, Vector3Int.back, Vector3Int.left };
        int leafheight = Random.Range(3, 5);
        Vector3Int[] leafDirections = { Vector3Int.forward, Vector3Int.right, Vector3Int.back, Vector3Int.left };


        for (int i = 0; i < height; i++)
        {
            Instantiate(trunkPrefab, growPos, Quaternion.identity, tree.transform);
            growPos += Vector3Int.up;

            // chance for branch growth
            if (Random.Range(0f, 1f) > .6f && i > 3)
            {
                Vector3Int branchPos = growPos;
                Debug.Log("Branching!");
                leaf.transform.position = branchPos;
                Vector3Int leafPos = branchPos;

                // 0 - forward, 1 - right, 2 - back, 3 - left
                Vector3Int branchDir = branchDirections[Random.Range(0, 4)];
                int branchLength = Random.Range(1, 5);

                while (branchLength > 0)
                {
                    if(Random.Range(0f,1f) > 0.7)
                    {
                        branchPos += branchDir + Vector3Int.up;
                        Instantiate(trunkPrefab, branchPos, Quaternion.identity, tree.transform);

                    }
                    else
                    {
                        branchPos += branchDir;
                        Instantiate(trunkPrefab, branchPos, Quaternion.identity, tree.transform);
                    }
                    branchLength--;
                    if (branchLength == 0)
                    {
                        leafPos += branchDir + Vector3Int.forward;
                        Instantiate(leafPrefab, leafPos, Quaternion.identity, leaf.transform);
                        leafPos += Vector3Int.right;
                        Instantiate(leafPrefab, leafPos, Quaternion.identity, leaf.transform);
                        leafPos += Vector3Int.left*2;
                        Instantiate(leafPrefab, leafPos, Quaternion.identity, leaf.transform);
                        leafPos += Vector3Int.back;
                        Instantiate(leafPrefab, leafPos, Quaternion.identity, leaf.transform);
                    }
                }
                
                //Instantiate(leafPrefab, growPos, Quaternion.identity, leaf.transform);
                //growPos += Vector3Int.up;

                //if (Random.Range(0f, 1f) > .1f && branchLength ==0 )
                //{
                //    Debug.Log("Leafing!");

                //    // 0 - forward, 1 - right, 2 - back, 3 - left
                //    Vector3Int leafDir = branchDirections[Random.Range(0, 4)];
                //    int leafLength = Random.Range(2, 4);

                //    while (leafLength > 0)
                //    {
                //        branchPos += leafDir;
                //        Instantiate(leafPrefab, branchPos, Quaternion.identity, tree.transform);
                //        leafLength--;
                //    }
                }

                //int leafheight = Random.Range(3, 5);

                //for (int l = 0; l < leafheight; l++)
                //{
                //    Instantiate(leafPrefab, growPos, Quaternion.identity, leaf.transform);
                //    growPos += Vector3Int.up;

                //    if (Random.Range(0f, 1f) > .1f)
                //    {
                //        Vector3Int leafPos = growPos;
                //        Debug.Log("Leafing!");

                //        // 0 - forward, 1 - right, 2 - back, 3 - left
                //        Vector3Int leafDir = branchDirections[Random.Range(0, 4)];
                //        int leafLength = Random.Range(1, 3);

                //        while (leafLength > 0)
                //        {
                //            leafPos += leafDir;
                //            Instantiate(leafPrefab, leafPos, Quaternion.identity, tree.transform);
                //            leafLength--;
                //        }
                //    }
            }
        }
    }
