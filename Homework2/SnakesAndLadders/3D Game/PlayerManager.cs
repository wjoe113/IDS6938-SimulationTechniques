using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour {

    public string playerCurrentTile;
    private GameObject[] cubes;
    private GameObject[] yellowCubes;
    private GameObject cube1;
    private GameObject cube2;
    private GameObject cube3;
    private GameObject cube4;
    private GameObject cube5;
    private GameObject cube6;
    [Tooltip("Main canvas rolled text")]
    public Text canvasRolled;
    [Tooltip("Main canvas rolls text")]
    public Text canvasRolls;
    public int rolls;

    private void Awake()
    {
        gameObject.transform.position = new Vector3(1, 1, 1); //Start at cell 1
        playerCurrentTile = "01";
    }

    void Start ()
    {
        yellowCubes = new GameObject[7];
        rolls = 0;
        if (cubes == null)
        {
            cubes = GameObject.FindGameObjectsWithTag("Cube");
        }
    }

    void Update()
    {    
        foreach (GameObject currentCube in cubes)
        {
            int playerCubeNum = int.Parse(playerCurrentTile);
            int currentCubeNum = int.Parse(currentCube.GetComponent<CubeManager>().cubeNum);

            if (currentCubeNum == playerCubeNum + 1)
            {
                currentCube.GetComponent<CubeManager>().meYellow = true;
                currentCube.GetComponent<CubeManager>().orderReceive(1);
            }
            else if (currentCubeNum == playerCubeNum + 2)
            {
                currentCube.GetComponent<CubeManager>().meYellow = true;
                currentCube.GetComponent<CubeManager>().orderReceive(2);
            }
            else if (currentCubeNum == playerCubeNum + 3)
            {
                currentCube.GetComponent<CubeManager>().meYellow = true;
                currentCube.GetComponent<CubeManager>().orderReceive(3);
            }
            else if (currentCubeNum == playerCubeNum + 4)
            {
                currentCube.GetComponent<CubeManager>().meYellow = true;
                currentCube.GetComponent<CubeManager>().orderReceive(4);
            }
            else if (currentCubeNum == playerCubeNum + 5)
            {
                currentCube.GetComponent<CubeManager>().meYellow = true;
                currentCube.GetComponent<CubeManager>().orderReceive(5);
            }
            else if (currentCubeNum == playerCubeNum + 6)
            {
                currentCube.GetComponent<CubeManager>().meYellow = true;
                currentCube.GetComponent<CubeManager>().orderReceive(6);
            }
            else
            {
                currentCube.GetComponent<CubeManager>().meYellow = false;
                currentCube.GetComponent<CubeManager>().orderReceive(0);
            }
        }
    }

    public void movePlayer()
    {
        foreach (GameObject currentCube in cubes)
        {
            if (currentCube.GetComponent<CubeManager>().myOrderNum == 1 && currentCube.GetComponent<CubeManager>().iAmYellow)
            {
                yellowCubes[1] = currentCube;
            }
            if (currentCube.GetComponent<CubeManager>().myOrderNum == 2 && currentCube.GetComponent<CubeManager>().iAmYellow)
            {
                yellowCubes[2] = currentCube;
            }
            if (currentCube.GetComponent<CubeManager>().myOrderNum == 3 && currentCube.GetComponent<CubeManager>().iAmYellow)
            {
                yellowCubes[3] = currentCube;
            }
            if (currentCube.GetComponent<CubeManager>().myOrderNum == 4 && currentCube.GetComponent<CubeManager>().iAmYellow)
            {
                yellowCubes[4] = currentCube;
            }
            if (currentCube.GetComponent<CubeManager>().myOrderNum == 5 && currentCube.GetComponent<CubeManager>().iAmYellow)
            {
                yellowCubes[5] = currentCube;
            }
            if (currentCube.GetComponent<CubeManager>().myOrderNum == 6 && currentCube.GetComponent<CubeManager>().iAmYellow)
            {
                yellowCubes[6] = currentCube;
            }
        }
    
        int moveSpaces = Random.Range(1, 6);
        rolls++;
        print(moveSpaces);
        canvasRolled.text = "Rolled a " + moveSpaces.ToString();
        canvasRolls.text = "Rolls: " + rolls.ToString();

        if (moveSpaces == 1)
        {
            gameObject.transform.position = new Vector3(yellowCubes[1].transform.position.x, 1, yellowCubes[1].transform.position.z);
            playerCurrentTile = yellowCubes[1].GetComponent<CubeManager>().cubeNum;
        }
        else if (moveSpaces == 2)
        {
            gameObject.transform.position = new Vector3(yellowCubes[2].transform.position.x, 1, yellowCubes[2].transform.position.z);
            playerCurrentTile = yellowCubes[2].GetComponent<CubeManager>().cubeNum;
        }
        else if (moveSpaces == 3)
        {
            gameObject.transform.position = new Vector3(yellowCubes[3].transform.position.x, 1, yellowCubes[3].transform.position.z);
            playerCurrentTile = yellowCubes[3].GetComponent<CubeManager>().cubeNum;
        }
        else if (moveSpaces == 4)
        {
            gameObject.transform.position = new Vector3(yellowCubes[4].transform.position.x, 1, yellowCubes[4].transform.position.z);
            playerCurrentTile = yellowCubes[4].GetComponent<CubeManager>().cubeNum;
        }
        else if (moveSpaces == 5)
        {
            gameObject.transform.position = new Vector3(yellowCubes[5].transform.position.x, 1, yellowCubes[5].transform.position.z);
            playerCurrentTile = yellowCubes[5].GetComponent<CubeManager>().cubeNum;
        }
        else if (moveSpaces == 6)
        {
            gameObject.transform.position = new Vector3(yellowCubes[6].transform.position.x, 1, yellowCubes[6].transform.position.z);
            playerCurrentTile = yellowCubes[6].GetComponent<CubeManager>().cubeNum;
        }
    }
}
