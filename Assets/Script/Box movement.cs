using UnityEngine;

public class Boxmovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
           if(other.CompareTag("Player"))
            {
            Debug.Log("Player has entered the trigger zone");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Player has left the trigger zone");
        }
    }
    private void OnTriggerStay(Collider other)
    {
      if(other.CompareTag("Player"))
        {
            Debug.Log("Player is in the trigger zone");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Player has collided with the object");
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Player has stopped colliding with the object");
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Player is still colloding with the object");
    }
}
