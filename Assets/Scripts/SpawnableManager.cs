using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class SpawnableManager : MonoBehaviour
{
    [SerializeField]
    ARRaycastManager m_RaycastManager;
    List<ARRaycastHit> m_Hits = new List<ARRaycastHit>();
    [SerializeField]
    GameObject spawnablePrefab;
    RaycastHit hit;
    Ray ray;
    Camera arCam;
    GameObject spawnableObject;
    // Start is called before the first frame update
    void Start()
    {
        spawnableObject = null;
        arCam = GameObject.Find("AR Camera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 0)
            return;

        if(m_RaycastManager.Raycast(Input.GetTouch(0).position,m_Hits))
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began && spawnableObject == null)
            {
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.gameObject.tag == "Spawnable")
                    {
                        spawnableObject = hit.collider.gameObject;
                    }
                    else
                    {
                        SpawnPrefab(m_Hits[0].pose.position);
                    }
                }
            }
        }
    }

    private void SpawnPrefab(Vector3 spawnPosition)
    {
        spawnableObject = Instantiate(spawnablePrefab, spawnPosition, Quaternion.identity);
    }
}
