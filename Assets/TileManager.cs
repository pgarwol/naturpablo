using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    // Start is called before the first frame update

    public List<GameObject> tiles;

    void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            tiles.Add(transform.GetChild(i).gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
