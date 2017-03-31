/***
 * Snakes and Ladders The Game
 * By Joe Wileman
 * IDS6938 Spring 2017 - Homework 2
 **/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour {

    [Tooltip("Yellow Material")]
    public Material yellowMat;
    [Tooltip("Dark Yellow Material")]
    public Material yellowMat2;
    [Tooltip("light Orange Material")]
    public Material yellowMat3;
    [Tooltip("Orange Material")]
    public Material yellowMat4;
    [Tooltip("Dark Orange Material")]
    public Material yellowMat5;
    [Tooltip("Red Material")]
    public Material yellowMat6;
    [Tooltip("Blue Material")]
    public Material blueMat;
    [Tooltip("Green Material")]
    public Material greenMat;
    [Tooltip("Player object")]
    public GameObject player;
    private Material defaultMaterial;
    public string cubeNum;
    public bool meYellow;
    public bool meBlue;
    public bool iAmYellow;
    public int myOrderNum;
    private int orderRec;

    void Start ()
    {
        defaultMaterial = gameObject.GetComponent<Renderer>().material;
        string myName = gameObject.name;
        meYellow = false;
        meBlue = false;
        iAmYellow = false;
        myOrderNum = 0;
        orderRec = 0;

        for (int i = 6; i < myName.Length; i++)
        {
            if (myName[i] == ')')
            {
                //DO NOTHING
            }
            else
            {
                cubeNum += myName[i];
            }
        }
    }

    private void Update()
    {
        //string mousedCubeNum = Camera.main.GetComponent<MouseOverCube>().savedName;
        string playerCubeNum = player.GetComponent<PlayerManager>().playerCurrentTile;

        if (playerCubeNum == "95" && cubeNum == "100" && meYellow)
        {
            gameObject.GetComponent<Renderer>().material = yellowMat2;
            myOrderNum = orderRec;
            iAmYellow = true;
        }
        else if (playerCubeNum == "96" && cubeNum == "100" && meYellow)
        {
            gameObject.GetComponent<Renderer>().material = yellowMat3;
            myOrderNum = orderRec;
            iAmYellow = true;
        }
        else if (playerCubeNum == "97" && cubeNum == "100" && meYellow)
        {
            gameObject.GetComponent<Renderer>().material = yellowMat4;
            myOrderNum = orderRec;
            iAmYellow = true;
        }
        else if (playerCubeNum == "98" && cubeNum == "100" && meYellow)
        {
            gameObject.GetComponent<Renderer>().material = yellowMat5;
            myOrderNum = orderRec;
            iAmYellow = true;
        }
        else if (meYellow && cubeNum != "03" && cubeNum != "15" && cubeNum != "22" && cubeNum != "25" && cubeNum != "41" && cubeNum != "53" && cubeNum != "63" && cubeNum != "76" && cubeNum != "84"
            && cubeNum != "11" && cubeNum != "18" && cubeNum != "28" && cubeNum != "36" && cubeNum != "77" && cubeNum != "47" && cubeNum != "83" && cubeNum != "92" && cubeNum != "99"
            && cubeNum != "07" && cubeNum != "13" && cubeNum != "34"/* && cubeNum != "16" && cubeNum != "26" && cubeNum != "39" && cubeNum != "75" && cubeNum != "70"*/
            && playerCubeNum != "03" && playerCubeNum != "15" && playerCubeNum != "22" && playerCubeNum != "25" && playerCubeNum != "41" && playerCubeNum != "53" && playerCubeNum != "63" && playerCubeNum != "76" && playerCubeNum != "84"
            && playerCubeNum != "11" && playerCubeNum != "18" && playerCubeNum != "28" && playerCubeNum != "36" && playerCubeNum != "77" && playerCubeNum != "47" && playerCubeNum != "83" && playerCubeNum != "92" && playerCubeNum != "99")
        {
            gameObject.GetComponent<Renderer>().material = yellowMat;
            myOrderNum = orderRec;
            iAmYellow = true;
        }
        else if (meYellow && cubeNum == "19" && (playerCubeNum == "01" || playerCubeNum == "02")) //Ladders
        {
            gameObject.GetComponent<Renderer>().material = yellowMat;
            myOrderNum = orderRec;
            iAmYellow = true;
        }
        else if (meYellow && cubeNum == "37" && (playerCubeNum == "09" || playerCubeNum == "10" || playerCubeNum == "12" || playerCubeNum == "13" || playerCubeNum == "14"))
        {
            gameObject.GetComponent<Renderer>().material = yellowMat;
            myOrderNum = orderRec;
            iAmYellow = true;
        }
        else if (meYellow && cubeNum == "42" && (playerCubeNum == "16" || playerCubeNum == "17" || playerCubeNum == "19" || playerCubeNum == "20" || playerCubeNum == "21"))
        {
            gameObject.GetComponent<Renderer>().material = yellowMat;
            myOrderNum = orderRec;
            iAmYellow = true;
        }
        else if (meYellow && cubeNum == "64" && (playerCubeNum == "19" || playerCubeNum == "20" || playerCubeNum == "21" || playerCubeNum == "23" || playerCubeNum == "24"))
        {
            gameObject.GetComponent<Renderer>().material = yellowMat;
            myOrderNum = orderRec;
            iAmYellow = true;
        }
        else if (meYellow && cubeNum == "73" && (playerCubeNum == "35" || playerCubeNum == "37" || playerCubeNum == "38" || playerCubeNum == "39" || playerCubeNum == "40"))
        {
            gameObject.GetComponent<Renderer>().material = yellowMat;
            myOrderNum = orderRec;
            iAmYellow = true;
        }
        else if (meYellow && cubeNum == "74" && (playerCubeNum == "48" || playerCubeNum == "49" || playerCubeNum == "50" || playerCubeNum == "51" || playerCubeNum == "52"))
        {
            gameObject.GetComponent<Renderer>().material = yellowMat;
            myOrderNum = orderRec;
            iAmYellow = true;
        }
        else if (meYellow && cubeNum == "86" && (playerCubeNum == "57" || playerCubeNum == "58" || playerCubeNum == "59" || playerCubeNum == "60" || playerCubeNum == "61" || playerCubeNum == "62"))
        {
            gameObject.GetComponent<Renderer>().material = yellowMat;
            myOrderNum = orderRec;
            iAmYellow = true;
        }
        else if (meYellow && cubeNum == "91" && (playerCubeNum == "70" || playerCubeNum == "71" || playerCubeNum == "72" || playerCubeNum == "73" || playerCubeNum == "74" || playerCubeNum == "75"))
        {
            gameObject.GetComponent<Renderer>().material = yellowMat;
            myOrderNum = orderRec;
            iAmYellow = true;
        }
        else if (meYellow && cubeNum == "98" && (playerCubeNum == "78" || playerCubeNum == "79" || playerCubeNum == "80" || playerCubeNum == "81" || playerCubeNum == "82"))
        {
            gameObject.GetComponent<Renderer>().material = yellowMat;
            myOrderNum = orderRec;
            iAmYellow = true;
        }
        else if (meYellow && cubeNum == "07" && (playerCubeNum == "05" || playerCubeNum == "06")) //Snakes
        {
            gameObject.GetComponent<Renderer>().material = yellowMat2;
            myOrderNum = orderRec;
            iAmYellow = true;
        }
        else if (meYellow && cubeNum == "07" && (playerCubeNum == "01" || playerCubeNum == "02" || playerCubeNum == "04" || playerCubeNum == "08" || playerCubeNum == "09" || playerCubeNum == "10"))
        {
            gameObject.GetComponent<Renderer>().material = yellowMat;
            myOrderNum = orderRec;
            iAmYellow = true;
        }
        else if (meYellow && cubeNum == "13" && playerCubeNum == "12")
        {
            gameObject.GetComponent<Renderer>().material = yellowMat2;
            myOrderNum = orderRec;
            iAmYellow = true;
        }
        else if (meYellow && cubeNum == "13" && (playerCubeNum == "07" || playerCubeNum == "08" || playerCubeNum == "09" || playerCubeNum == "10" || playerCubeNum == "13" || playerCubeNum == "14" || playerCubeNum == "16" || playerCubeNum == "17"))
        {
            gameObject.GetComponent<Renderer>().material = yellowMat;
            myOrderNum = orderRec;
            iAmYellow = true;
        }
        else if (meYellow && cubeNum == "12" && (playerCubeNum == "23" || playerCubeNum == "24" || playerCubeNum == "26" || playerCubeNum == "27"))
        {
            gameObject.GetComponent<Renderer>().material = yellowMat;
            myOrderNum = orderRec;
            iAmYellow = true;
        }
        else if (meYellow && cubeNum == "34" && (playerCubeNum == "30" || playerCubeNum == "31" || playerCubeNum == "32" || playerCubeNum == "33"))
        {
            gameObject.GetComponent<Renderer>().material = yellowMat2;
            myOrderNum = orderRec;
            iAmYellow = true;
        }
        else if (meYellow && cubeNum == "34" && (playerCubeNum == "29" || playerCubeNum == "35"))
        {
            gameObject.GetComponent<Renderer>().material = yellowMat;
            myOrderNum = orderRec;
            iAmYellow = true;
        }
        else if (meYellow && cubeNum == "16" && (playerCubeNum == "71" || playerCubeNum == "72" || playerCubeNum == "73" || playerCubeNum == "74" || playerCubeNum == "75"))
        {
            gameObject.GetComponent<Renderer>().material = yellowMat;
            myOrderNum = orderRec;
            iAmYellow = true;
        }
        else if (meYellow && cubeNum == "26" && (playerCubeNum == "42" || playerCubeNum == "43" || playerCubeNum == "44" || playerCubeNum == "45" || playerCubeNum == "46"))
        {
            gameObject.GetComponent<Renderer>().material = yellowMat;
            myOrderNum = orderRec;
            iAmYellow = true;
        }
        else if (meYellow && cubeNum == "39" && (playerCubeNum == "78" || playerCubeNum == "79" || playerCubeNum == "80" || playerCubeNum == "81" || playerCubeNum == "82"))
        {
            gameObject.GetComponent<Renderer>().material = yellowMat;
            myOrderNum = orderRec;
            iAmYellow = true;
        }
        else if (meYellow && cubeNum == "75" && (playerCubeNum == "86" || playerCubeNum == "87" || playerCubeNum == "88" || playerCubeNum == "89" || playerCubeNum == "90" || playerCubeNum == "91"))
        {
            gameObject.GetComponent<Renderer>().material = yellowMat;
            myOrderNum = orderRec;
            iAmYellow = true;
        }
        else if (meYellow && cubeNum == "70" && (playerCubeNum == "93" || playerCubeNum == "94" || playerCubeNum == "95" || playerCubeNum == "96" || playerCubeNum == "97" || playerCubeNum == "98"))
        {
            gameObject.GetComponent<Renderer>().material = yellowMat;
            myOrderNum = orderRec;
            iAmYellow = true;
        }
        else if (meBlue && playerCubeNum == "100") //YOU WIN!!!
        {
            gameObject.GetComponent<Renderer>().material = greenMat;
            iAmYellow = false;
        }
        else if (meBlue && cubeNum != "03" && cubeNum != "15" && cubeNum != "22" && cubeNum != "25" && cubeNum != "41" && cubeNum != "53" && cubeNum != "63" && cubeNum != "76" && cubeNum != "84"
            && cubeNum != "11" && cubeNum != "18" && cubeNum != "28" && cubeNum != "36" && cubeNum != "77" && cubeNum != "47" && cubeNum != "83" && cubeNum != "92" && cubeNum != "99")
        {
            gameObject.GetComponent<Renderer>().material = blueMat;
            iAmYellow = false;
        }
        else if (player.GetComponent<PlayerManager>().playerCurrentTile == cubeNum) //Player is on the blue tile
        {
            gameObject.GetComponent<Renderer>().material = blueMat;
            iAmYellow = false;
        }
        else
        {
            gameObject.GetComponent<Renderer>().material = defaultMaterial;
            iAmYellow = false;
            myOrderNum = 0;
        }
    }

    public void orderReceive(int i)
    {
        orderRec = i;
    }
}
