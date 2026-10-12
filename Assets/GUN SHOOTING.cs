using UnityEngine;
using UnityEngine.InputSystem;

public class GUNSHOOTING : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject bulletPrefab;
    public float bulletspeed = 20f;
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
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void Fire(InputAction.CallbackContext context)
    {
        RaycastHit hit;
        Physics.Raycast(FirePoint.position, FirePoint.forward, 100f);

        GameObject bullet = Instantiate(bulletPrefab, FirePoint.position, bulletPrefab.transform.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.linearVelocity = FirePoint.forward * bulletspeed;

        firesound.Play();

        Destroy(bullet, 10);

    }

}

