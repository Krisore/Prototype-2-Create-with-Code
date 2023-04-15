using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    private const float XRange = 20.0f;
    private const float ZRange = 10.0f;
    public float speed = 5f;
    public Transform projectileSpawnPoint;
    public GameObject projectilePizza;
    
    // Start is called before the first frame update
    // Update is called once per frame 
    
    private void Update()
    {
        var transform1 = transform;
        var position = transform1.position;
        position = position.x switch
        {
            < -XRange => new Vector3(-XRange, position.y, position.z),
            > XRange => new Vector3(XRange, position.y, position.z),
            _ => position
        };
        position = position.z switch
        {
            < -ZRange => new Vector3(position.x, position.y, -ZRange),
            > ZRange => new Vector3(position.x, position.y, ZRange),
            _ => position 
        };
        transform1.position = position;
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * (horizontalInput * Time.deltaTime * speed));
        transform.Translate(Vector3.forward * (verticalInput * Time.deltaTime * speed));
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //TODO : Launch a projectile from the player
            Instantiate(projectilePizza,  projectileSpawnPoint.position, projectilePizza.transform.rotation);
        }

    }
}
