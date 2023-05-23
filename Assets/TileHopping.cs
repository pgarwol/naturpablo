using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileHopping : MonoBehaviour
{

    // Tile logic
    public int tileStanding = 0;
    public int nextTile;
    public TileManager tm;

    // Movement logic
    public Transform startPoint;
    public Transform endPoint;
    public float jumpHeight = 1f;
    public float duration = 1f;

    // Start is called before the first frame update
    void Start()
    {
        // Set whatever tile is next
        nextTile = tileStanding + 1;
        // Get tile manager
        tm = GameObject.Find("Tiles").GetComponent<TileManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //Jump to and fro
        startPoint = tm.tiles[tileStanding].transform;
        endPoint = tm.tiles[nextTile].transform;

        if (Input.GetMouseButtonDown(0))
        {
            HopFromTileToTile();
        }
    }

    public void HopFromTileToTile()
    {
        Vector3 centerPoint = (startPoint.position + endPoint.position) / 2f;
        centerPoint += Vector3.up * jumpHeight;

        // Start the LeanTween animation
        LeanTween.move(gameObject, endPoint.position, duration)
            .setEase(LeanTweenType.easeOutQuad)
            .setOnComplete(OnMovementComplete);

        LeanTween.move(gameObject, centerPoint, duration / 2f)
            .setEase(LeanTweenType.easeInQuad);
    }

    private void OnMovementComplete()
    {
        Debug.Log("Movement completed!");
        tileStanding++;
    }
}
