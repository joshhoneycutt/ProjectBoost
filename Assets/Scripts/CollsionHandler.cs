using UnityEngine;
using UnityEngine.SceneManagement;

public class CollsionHandler : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        switch(collision.gameObject.tag)
        {
            case "Friendly":
                Debug.Log("This thing is Friendly");
                break;
            case "Finish":
                Debug.Log("This thing is Finish");
                break;
            case "Fuel":
                Debug.Log("this thing is fuel");
                break;
            default:
                ReloadLevel();
                break;
        }
    }

    void ReloadLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
