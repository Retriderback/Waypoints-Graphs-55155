using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowWaypoints : MonoBehaviour
{
    Transform goal;
    float speed = 5.0f;
    float accuracy = 1.0f;
    float rotSpeed = 2.0f;

    public GameObject wpManager;
    GameObject[] wps;
    GameObject currentNode;
    int currentWP = 0;
    Graph g;

    void Start()
    {
    	wps = wpManager.GetComponent<WPManager>().waypoints;
    	g = wpManager.GetComponent<WPManager>().graph;
    	currentNode = wps[0];
    }

    public void GoToHeli()
    {
    	g.AStar(currentNode, wps[5]);
    	currentWP = 0;
    }

    public void GoToRuin()
    {
    	g.AStar(currentNode, wps[8]);
    	currentWP = 0;
    }

    void Update()
    {

    }
}
