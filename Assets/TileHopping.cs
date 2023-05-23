using UnityEngine;

public class TileHopping : MonoBehaviour
{
    // Tile logic
    public int tileStanding = 0;
    public int nextTile = 1;
    public TileManager tm;
    public int tilesLeftToMove = 0;

    // Movement logic
    public float jumpHeight = 1f;
    public float duration = 1f;

    //Height of piece
    // Get the mesh renderer component of the object
    public float height;

    private void Start()
    {


        // Calculate and return the height of the object
        height = 1.1f;
    }

    private void Update()
    {
        //Increase tiles
        nextTile = tileStanding + 1;

        if (Input.GetMouseButtonDown(0))
        {
            MoveBy(3);
        }
    }

    private void MoveBy(int spaces)
    {
        tilesLeftToMove = spaces;
        LeanTween.move(gameObject, new Vector3(tm.tiles[tileStanding + 1].transform.position.x, tm.tiles[tileStanding + 1].transform.position.y + height, tm.tiles[tileStanding + 1].transform.position.z), duration).setEase(LeanTweenType.easeInOutQuad).setOnComplete(CompleteMovement);
    }

    private void CompleteMovement()
    {
        tileStanding++;
        tilesLeftToMove--;
        if (tilesLeftToMove > 0)
        {
            MoveBy(tilesLeftToMove);
        }
    }
}
