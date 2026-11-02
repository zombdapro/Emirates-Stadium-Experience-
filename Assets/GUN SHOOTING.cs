using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using TMPro; 

public class GUNSHOOTING : MonoBehaviour

{
    public Transform FirePoint;
    public GameObject bulletPrefab;
    public float bulletspeed = 50f;
    public AudioSource firesound;

   

    public InputActionReference fireBtn;
    // Start is called once beore the first execution of Update after the MonoBehaviour is created

    private void OnEnable()
    {
        fireBtn.action.Enable();
        fireBtn.action.performed += Fire;
    }

    private void OnDisable()
    {
        fireBtn.action.performed-= Fire;
        fireBtn.action.Disable();
    }

    void Fire(InputAction.CallbackContext context)
    {
        RaycastHit hit;
        Physics.Raycast(FirePoint.position, FirePoint.forward, 100f);

        GameObject bullet = Instantiate(bulletPrefab, FirePoint.position, FirePoint.rotation, this.gameObject.transform);
        Debug.Log("After shoot "+bullet.transform.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.linearVelocity = FirePoint.forward * bulletspeed * 2;
        Debug.Log("After rigidbody " + bullet.transform.rotation);

        firesound.Play();

        Destroy(bullet, 10);

    }

}

