
using UnityEngine;
using Random = UnityEngine.Random;


public class Rotator : MonoBehaviour
{
    private void Start()
    {
        transform.position = new Vector3(Random.Range(-9.0f,9.0f),0.5f,Random.Range(-8.0f,8.0f));
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(15,30,45) * Time.deltaTime);
    }
}
