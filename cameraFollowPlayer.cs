
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public Transform Player;
    public Vector3 velocity;
    public float damping;
    
    private void FixedUpdate()
    {
        transform.position = Vector3.SmoothDamp(transform.position, Player.position, ref velocity, damping);
        transform.position = new Vector3(transform.position.x, transform.position.y, -10);
    }
}
