using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WellGenerator : MonoBehaviour
{
    [SerializeField] GameObject StoneBlockPrefab;
    [SerializeField] GameObject WaterVariantPrefab;

    // Start is called before the first frame update
    void Start()
    {
        Dictionary<Vector3Int, string> world = new Dictionary<Vector3Int, string>();

        int x, y, z;

        x = Random.Range(-40, 40);
        y = 1;
        z = Random.Range(-40, 40);

        GenerateWell(new Vector3Int(x, y, z));

    }

    // Update is called once per frame
    void Update()
    {


    }

    void GenerateWell(Vector3Int startPos)
    {
        GameObject well = new GameObject("well");
        well.transform.position = startPos;
        for (int y = startPos.y; y < startPos.y - Random.Range(-8, -4); y--)
        {

            for (int d = 4; d > 1; d--)
            {
                int i = 4;
                if (i > 1)
                {
                    Instantiate(StoneBlockPrefab, startPos, Quaternion.identity, well.transform);
                    startPos += startPos + Vector3Int.forward;
                    i--;

                }
                startPos = startPos + Vector3Int.right;
            }

        }
    }

}

