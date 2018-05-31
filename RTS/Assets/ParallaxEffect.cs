using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxEffect : MonoBehaviour {
    public Transform rootOfObjects;
    List<Transform> objectList;

    float cameraClippingPlane;

    public float movingSpeed = 1;
    
    void setObjectList(Transform father)
    {
        if (father.childCount == 0)
        {
            objectList.Add(father);
            return;
        }

        for(int i = 0; i < father.childCount; i++)
        {
            setObjectList(father.GetChild(i));
        }
        
    }

	// Use this for initialization
	void Start () {
        objectList = new List<Transform>();
        setObjectList(rootOfObjects);
        cameraClippingPlane = this.GetComponent<Camera>().farClipPlane;

    }
	
	// Update is called once per frame
	void Update () {
       // GetComponent<Camera>().fieldOfView -= 0.01f;
     //   Debug.Log(GetComponent<Camera>().fieldOfView);
        foreach (Transform ob in objectList)
        {
           // float distance = Mathf.Abs(Vector3.Distance(ob.transform.position,this.transform.position));
            //float moving = cameraClippingPlane / distance;
            ob.Translate(this.transform.right * Time.deltaTime*(movingSpeed),Space.World);
        }
	}
}
