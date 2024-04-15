using UnityEngine;

public class CloudManager : MonoBehaviour
{
    public float speed = 5f;
    private Vector3 initialPosition;
    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
        initialPosition = transform.position;
    }

    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);

        float posX = transform.position.x;
        if (posX < 220)
        {
            RepositionCloud();
        }
    }

    void RepositionCloud()
    {
        transform.position = initialPosition;
    }
}
