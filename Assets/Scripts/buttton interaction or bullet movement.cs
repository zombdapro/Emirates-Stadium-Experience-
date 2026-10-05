using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public InputActionReference  bullet;
    public GameObject spawnpobject;

    private void OnEnable()
    {
        bullet.action.Enable();
        bullet.action.performed += BulletObject; 
    }

    private void OnDisable()
    {
        bullet.action.performed -= BulletObject;
    }

    void BulletObject(InputAction.CallbackContext context)
    {
        Instantiate(spawnpobject, transform.position , Quaternion.identity);
    }
 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
