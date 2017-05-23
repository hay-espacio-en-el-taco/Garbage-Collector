using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DragAndDrop : MonoBehaviour
{
    public float moveSpeed;
    public float offset = 0.05f;
    private bool following;
    // Use this for initialization
    void Start()
    {
        following = false;
        offset += 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && ((Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position).magnitude <= offset))
        {
            following = true;
        } else if (Input.GetMouseButtonUp(0))
        {
            following = false;
        }
        if (following)
        {
            transform.position = Vector2.Lerp(transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition), moveSpeed);
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "PlaySurface")
        {
            Debug.Log("Activated!");
        }

    }
}