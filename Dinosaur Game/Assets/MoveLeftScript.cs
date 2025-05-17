using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveLeftScript : MonoBehaviour
{
    public float speed = 1f;
    private void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
