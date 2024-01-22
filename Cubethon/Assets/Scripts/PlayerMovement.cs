using UnityEngine;

namespace Chapter.Command
{
    public class PlayerMovement : MonoBehaviour
    {
        public Rigidbody rb;

        public float forwardForce = 2000f;
        public float sidwaysForce = 500f;

        public enum Direction
        {
            Left = -1, Right = 1
        }

        private float _distance = 1.0f;

        void FixedUpdate()
        {

            rb.AddForce(0, 0, forwardForce * Time.deltaTime);

            if ( Input.GetKey("d") )
             {

                 rb.AddForce(sidwaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

             }

             if (Input.GetKey("a"))
             {

                 rb.AddForce(-sidwaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

             }

            if (rb.position.y < -1f)
            {

                FindObjectOfType<GameManager>().EndGame();

            }
        }

        public void Turn(Direction direction)
        {
            if (direction == Direction.Left)
                transform.Translate(Vector3.left * _distance);

            if (direction == Direction.Right)
                transform.Translate(Vector3.right * _distance);
        }

        public void ResetPosition()
        {
            transform.position = new Vector3(0.0f, 1.0f, 0.0f);
        }
    }
}
