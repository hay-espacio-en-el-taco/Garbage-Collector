using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardTouch : MonoBehaviour {

    private SpringJoint2D spring;


    void Awake()
    {

        spring = this.gameObject.GetComponent<SpringJoint2D>(); 
        //"spring" is the SpringJoint2D component that I added to my object

        spring.connectedAnchor = gameObject.transform.position;
        //i want the anchor position to start at the object's position

        Debug.Log("I'm ready to be drag!");

    }


    void OnMouseDown()
    {

        spring.enabled = true;
        Debug.Log("Clicked!");
        //I'm reactivating the SpringJoint2D component each time I'm clicking on my object becouse I'm disabling it after I'm releasing the mouse click so it will fly in the direction i was moving my mouse

    }


    void OnMouseDrag()
    {

        if (spring.enabled == true)
        {

            Vector2 cursorPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //getting cursor position
            Debug.Log(cursorPosition);

            //spring.connectedAnchor = cursorPosition;
            this.gameObject.transform.Translate(cursorPosition);
            //the anchor get's cursor's position


        }
    }


    void OnMouseUp()
    {

        spring.enabled = false;//disabling the spring component
        Debug.Log("No more dragging");

    }

    void Update()
    {
        // TODO: stuff
    }
}
