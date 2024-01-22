using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KinematicSteeringOutputFlee
{
    public Vector3 velocity;
    public float rotation;
}

public class KinematicFlee : MonoBehaviour
{
    public Transform obstacle;
    public Transform player;

    public Rigidbody rb;

    public float currentRot;

    public float speed = 500f;

    public void Update()
    {
        getSteering();
    }

    public KinematicSteeringOutputFlee getSteering()
    {
        KinematicSteeringOutputFlee result = new KinematicSteeringOutputFlee();

        result.velocity = obstacle.transform.position - player.transform.position;

        result.velocity.Normalize();
        result.velocity *= speed;

        rb.AddForce(result.velocity * Time.deltaTime);

        float target = newOrientation(obstacle.rotation.eulerAngles.y, result.velocity);
        obstacle.eulerAngles = new Vector3(0, target, 0);

        result.rotation = 0;
        return result;
    }

    public float newOrientation(float currentRot, Vector3 velocity)
    {
        if (velocity.magnitude > 0)
        {
            float targetAngle = Mathf.Atan2(velocity.x, velocity.z);
            targetAngle *= Mathf.Rad2Deg;
            return targetAngle;
        }
        else
        {
            return currentRot;
        }
    }
}
