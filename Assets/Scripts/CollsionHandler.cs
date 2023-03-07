using UnityEngine;

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
                Debug.Log("Sorry, you blew up");
                break;
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
