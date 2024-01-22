using UnityEngine;

namespace Chapter.Command
{
    public class EndTrigger : MonoBehaviour
    {

        public GameManager gameManager;

        void OnTriggerEnter()
        {
            gameManager.CompleteLevel();

        }

    }
}
