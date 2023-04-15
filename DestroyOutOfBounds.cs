using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private const float TopBoundary = 25f;
    private const float LowerBoundary = -15f;
    private const float SideBoundary = 30f;
    // Start is called before the first frame update
    // Update is called once per frame
    private void Update() 
    {
        switch (transform.position.z)
        {
            case > TopBoundary:
                Destroy(gameObject);
                break;
            case < LowerBoundary:
                Debug.Log("Game Over!");
                Destroy(gameObject);
                break;
        }

        switch (transform.position.x)
        {
            case > SideBoundary:
                Debug.Log("Game Over!");
                Destroy(gameObject);
                break;
            case < -SideBoundary:
                Debug.Log("Game Over");
                Destroy(gameObject);
                break;
        }
    }
}
