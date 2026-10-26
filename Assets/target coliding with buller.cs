using UnityEngine;
using UnityEngine.UI;
using TMPro; 

public class targetcolidingwithbuller : MonoBehaviour
{

    public static float bulletcount;
    public TextMeshProUGUI scoreUI;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            bulletcount++;
            scoreUI.text = "Score: "  + bulletcount;
            Debug.Log(bulletcount);
        }
    }
}
