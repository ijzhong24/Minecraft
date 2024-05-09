using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WellGeneratorBrix : MonoBehaviour
{
    Dictionary<Vector3Int, GameObject> world = new Dictionary<Vector3Int, GameObject>();
    public GameObject stonePrefab;
    public GameObject waterPrefab;

    // Start is called before the first frame update
    void Start()
    {
        //GenerateWell(new Vector3Int(0, 0, 0));
    }

    // Update is called once per frame
    void Update()
    {

    }

    void GenerateWell(Vector3Int startPos) //creates well at startpos
    {
        for (int y = startPos.y; y > startPos.y - Random.Range(5,10); y--) //make well go down
        {
            for (int x = startPos.x; x < startPos.x + 3; x++) //side of well
            {
                for (int z = startPos.z; z < startPos.z + 3; z++) //other side of well
                {
                    if (x != startPos.x && x != startPos.x + 2 && z != startPos.z && z != startPos.z + 2)
                        continue;

                    //instantiate the well
                    Vector3Int position = new Vector3Int(x, y, z);
                    Vector3Int waterposition = new Vector3Int(x + 1, y, z + 1);
                    world[position] = Instantiate(stonePrefab, position, Quaternion.identity);
                    Instantiate(waterPrefab, waterposition, Quaternion.identity);
                }
            }
        }
    }
}