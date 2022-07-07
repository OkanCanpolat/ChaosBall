using UnityEngine;

public class VelocityScrip : MonoBehaviour
{
    [SerializeField] private float startSpeed = 50f;

    // give the balls starting speed
    void Start()
    {
        Rigidbody rigidBody = GetComponent<Rigidbody>();
        rigidBody.velocity = new Vector3(startSpeed, 0, startSpeed);
    }
}
