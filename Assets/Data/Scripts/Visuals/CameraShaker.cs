using System.Collections;
using UnityEngine;


public class CameraShaker : MonoBehaviour
{
    private void Start()
    {
        //StartCoroutine(Shake(8f, 0.00010f));
    }
    public IEnumerator Shake(float duration, float magnitude)
    {
        Vector3 orignalPos = transform.localPosition;

        float elapsed = 0.0f;

        while (elapsed < duration)
        {
            float x = Random.Range(-1f, 1f) * magnitude;

            float y = Random.Range(-1f, 1f) * magnitude;

            transform.localPosition = new Vector3(x, y, orignalPos.z);

            elapsed += Time.deltaTime;

            yield return null;
        }
        transform.localPosition = orignalPos;
    }

}