using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
  
    public void StartGame ()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

}
