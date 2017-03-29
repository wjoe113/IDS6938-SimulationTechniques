/***
 * Snakes and Ladders The Game
 * By Joe Wileman
 * IDS6938 Spring 2017 - Homework 2
 **/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOverCube : MonoBehaviour {

    Ray ray;
    RaycastHit hit;
    private Material savedMaterial;
    public string savedName;
    private GameObject savedObject;
    private GameObject[] cubes;

    private void Start()
    {
        savedName = "";
        if (cubes == null)
        {
            cubes = GameObject.FindGameObjectsWithTag("Cube");
        }
    }

    void Update ()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            if (savedName == "" && hit.transform.tag == "Cube")
            {
                savedObject = hit.collider.gameObject;
                savedName = savedObject.GetComponent<CubeManager>().cubeNum;
                hit.collider.gameObject.GetComponent<CubeManager>().meBlue = true;

                foreach (GameObject currentCube in cubes)
                {
                    int currentCubeNum = int.Parse(currentCube.GetComponent<CubeManager>().cubeNum);
                    int savedCubeNum = int.Parse(savedName);
                    if (currentCubeNum == savedCubeNum + 1
                        || currentCubeNum == savedCubeNum + 2
                        || currentCubeNum == savedCubeNum + 3
                        || currentCubeNum == savedCubeNum + 4
                        || currentCubeNum == savedCubeNum + 5
                        || currentCubeNum == savedCubeNum + 6)
                    {
                        currentCube.GetComponent<CubeManager>().meYellow = true;
                    }
                    else
                    {
                        currentCube.GetComponent<CubeManager>().meYellow = false;
                    }
                }
            }
            else if(savedName != hit.transform.name && hit.transform.tag == "Cube")
            {
                savedObject.GetComponent<CubeManager>().meBlue = false; //Restore old material
                savedObject = hit.collider.gameObject;
                savedName = savedObject.GetComponent<CubeManager>().cubeNum;
                hit.collider.gameObject.GetComponent<CubeManager>().meBlue = true;

                foreach (GameObject currentCube in cubes)
                {
                    int currentCubeNum = int.Parse(currentCube.GetComponent<CubeManager>().cubeNum);
                    int savedCubeNum = int.Parse(savedName);
                    if (currentCubeNum == savedCubeNum + 1 || currentCubeNum == savedCubeNum + 2 || currentCubeNum == savedCubeNum + 3
                        || currentCubeNum == savedCubeNum + 4 || currentCubeNum == savedCubeNum + 5 || currentCubeNum == savedCubeNum + 6)
                    {
                        currentCube.GetComponent<CubeManager>().meYellow = true;
                    }
                    else
                    {
                        currentCube.GetComponent<CubeManager>().meYellow = false;
                    }
                }
            }
        }
    }
}
