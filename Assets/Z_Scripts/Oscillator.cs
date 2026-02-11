using UnityEngine;

public class Oscillator : MonoBehaviour
{
    Vector3 startingPos;
    [SerializeField] Vector3 movementVector;
    float movementFactor;
    [SerializeField] float period = 5f;

    private void Start()
    {
        startingPos = transform.position;
    }

    private void Update()
    {
        movementFactor = Mathf.Sin(Time.time);

        Vector3 offset = movementVector * movementFactor;
        transform.position = startingPos + offset;
    }
}
