using UnityEngine;

public class ScaleCube : MonoBehaviour
{
    public float scaleSpeed = 0.5f;
    public float minScale = 0.5f;
    public float maxScale = 2.0f;

    private Vector3 initialScale;
    private bool isScalingUp = false;
    private bool isScalingDown = false;

    private void Start()
    {
        initialScale = transform.localScale;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.H))
        {
            isScalingUp = true;
        }
        else
        {
            isScalingUp = false;
        }

        if (Input.GetKey(KeyCode.J))
        {
            isScalingDown = true;
        }
        else
        {
            isScalingDown = false;
        }

        if (isScalingUp)
        {
            ScaleUp();
        }

        if (isScalingDown)
        {
            ScaleDown();
        }
    }

    private void ScaleUp()
    {
        Vector3 newScale = transform.localScale + Vector3.one * scaleSpeed * Time.deltaTime;

        if (newScale.x > maxScale)
        {
            newScale = Vector3.one * maxScale;
        }

        transform.localScale = newScale;
    }

    private void ScaleDown()
    {
        Vector3 newScale = transform.localScale - Vector3.one * scaleSpeed * Time.deltaTime;

        if (newScale.x < minScale)
        {
            newScale = Vector3.one * minScale;
        }

        transform.localScale = newScale;
    }
}
