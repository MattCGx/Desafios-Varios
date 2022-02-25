using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float playerSpeed = 30f;
    [SerializeField] float playerRotationSpeed = 70f;
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] GameObject shootPoint1;
    [SerializeField] GameObject shootPoint2;
    [SerializeField] float fireRate = 10f;
     bool canshoot = true;
    float cooldown = 5f;
    //[SerializeField] float loadTime = 0f;


    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("BulletSpawn", loadTime, 1/fireRate); //Lo dejo por si me sirve 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) { MovePlayer(Vector3.forward); }; //acelerar
        if (Input.GetKey(KeyCode.S)) { MovePlayer(Vector3.back); }; //retroceder
        //if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.LeftShift)) { MovePlayer(Vector3.left); }; // strafe no salio como queria
        //if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.LeftShift)) { MovePlayer(Vector3.right); }; // strafe no salio como queria
        if (Input.GetKey(KeyCode.Q)) { MovePlayer(Vector3.left); }; //strafe left
        if (Input.GetKey(KeyCode.E)) { MovePlayer(Vector3.right); }; //strafe right
        RotatePlayer();
        if (Input.GetKey(KeyCode.Mouse0)) { BulletSpawn(); }; //aca falta un timer, pero aun no lo necesito
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

       

        if (!canshoot)
        {

            cooldown -= Time.deltaTime * fireRate;

            if(cooldown<=0f){
                canshoot = true;
                
            }

        }

        if (canshoot)
        {
            Instantiate(bulletPrefab, shootPoint1.transform.position, shootPoint1.transform.rotation);
            Instantiate(bulletPrefab, shootPoint2.transform.position, shootPoint2.transform.rotation);
            canshoot = false;
            cooldown = 5f;
        };



        //falta el timer con un bool 
    }

}


