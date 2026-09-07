using JetBrains.Annotations;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public GameObject Canvas;

    public GameObject sphere;
    float timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

       
        Debug.Log("Printing");
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        Debug.Log("is this working");
        if (timer > 5)
        {

        }
      
    }
 public void Destroycanvas()
            {
                Destroy(Canvas);
            }
}

