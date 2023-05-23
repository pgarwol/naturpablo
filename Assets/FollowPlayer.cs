using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    private void Awake()
    {
        player = GameObject.Find("Pablo").transform;
    }

    private void LateUpdate()
    {
        // Calculate the desired position for the camera
        Vector3 desiredPosition = player.position + offset;

        // Use lerp to smoothly move the camera towards the desired position
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);

        // Update the camera position
        transform.position = smoothedPosition;
    }
}