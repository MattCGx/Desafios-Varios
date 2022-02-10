using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float playerSpeed = 30f;
    [SerializeField] float playerRotationSpeed = 70f;
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] GameObject shootPoint1;
    [SerializeField] GameObject shootPoint2;
    //[SerializeField] float fireRate = 10f;
    //[SerializeField] float loadTime = 0f;


    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("BulletSpawn", loadTime, 1/fireRate);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) { MovePlayer(Vector3.forward); };
        if (Input.GetKey(KeyCode.S)) { MovePlayer(Vector3.back); };
        //if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.LeftShift)) { MovePlayer(Vector3.left); };
        //if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.LeftShift)) { MovePlayer(Vector3.right); };
        if (Input.GetKey(KeyCode.Q)) { MovePlayer(Vector3.left); };
        if (Input.GetKey(KeyCode.E)) { MovePlayer(Vector3.right); };
        RotatePlayer();
        if (Input.GetKey(KeyCode.Mouse0)) {BulletSpawn(); };
    }

    void MovePlayer(Vector3 directionPlayer)

    {
        transform.Translate(playerSpeed * Time.deltaTime * directionPlayer);
    }

    void RotatePlayer()
    {
        float hAxis = Input.GetAxis("Horizontal");

        transform.Rotate(Vector3.up, hAxis * playerRotationSpeed * Time.deltaTime);

    }

    private void BulletSpawn()
    {
        Instantiate(bulletPrefab, shootPoint1.transform.position, shootPoint1.transform.rotation);
        Instantiate(bulletPrefab, shootPoint2.transform.position, shootPoint2.transform.rotation); 
    }

}


