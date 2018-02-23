using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meshTest : MonoBehaviour {

    public Mesh thisMesh;
    public GameObject obj;


	void Start () {
        Vector3[] verts = thisMesh.vertices;

        for (int i = 0; i < verts.Length; i++)
        {
            if (i % 4 == 0)
            {
                Instantiate(obj, verts[i] + transform.position, Quaternion.identity).transform.parent = gameObject.transform;
            }
        }
	}
}
