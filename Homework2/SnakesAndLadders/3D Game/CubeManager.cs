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
    private Material defaultMaterial;
    public string cubeNum;
    public bool meYellow;
    public bool meBlue;

    void Start ()
    {
        defaultMaterial = gameObject.GetComponent<Renderer>().material;
        string myName = gameObject.name;
        meYellow = false;
        meBlue = false;

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
        string mousedCubeName = Camera.main.GetComponent<MouseOverCube>().savedName;

        if (mousedCubeName == "95" && cubeNum == "100" && meYellow)
        {
            gameObject.GetComponent<Renderer>().material = yellowMat2;
        }
        else if (mousedCubeName == "96" && cubeNum == "100" && meYellow)
        {
            gameObject.GetComponent<Renderer>().material = yellowMat3;
        }
        else if (mousedCubeName == "97" && cubeNum == "100" && meYellow)
        {
            gameObject.GetComponent<Renderer>().material = yellowMat4;
        }
        else if (mousedCubeName == "98" && cubeNum == "100" && meYellow)
        {
            gameObject.GetComponent<Renderer>().material = yellowMat5;
        }
        else if (meYellow && cubeNum != "03" && cubeNum != "15" && cubeNum != "22" && cubeNum != "25" && cubeNum != "41" && cubeNum != "53" && cubeNum != "63" && cubeNum != "76" && cubeNum != "84"
            && cubeNum != "11" && cubeNum != "18" && cubeNum != "28" && cubeNum != "36" && cubeNum != "77" && cubeNum != "47" && cubeNum != "83" && cubeNum != "92" && cubeNum != "99"
            && cubeNum != "07" && cubeNum != "13" && cubeNum != "34"/* && cubeNum != "16" && cubeNum != "26" && cubeNum != "39" && cubeNum != "75" && cubeNum != "70"*/
            && mousedCubeName != "03" && mousedCubeName != "15" && mousedCubeName != "22" && mousedCubeName != "25" && mousedCubeName != "41" && mousedCubeName != "53" && mousedCubeName != "63" && mousedCubeName != "76" && mousedCubeName != "84"
            && mousedCubeName != "11" && mousedCubeName != "18" && mousedCubeName != "28" && mousedCubeName != "36" && mousedCubeName != "77" && mousedCubeName != "47" && mousedCubeName != "83" && mousedCubeName != "92" && mousedCubeName != "99")
        {
            gameObject.GetComponent<Renderer>().material = yellowMat;
        }
        else if (cubeNum == "19" && (mousedCubeName == "01" || mousedCubeName == "02")) //Ladders
        {
            gameObject.GetComponent<Renderer>().material = yellowMat;
        }
        else if (cubeNum == "37" && (mousedCubeName == "09" || mousedCubeName == "10" || mousedCubeName == "12" || mousedCubeName == "13" || mousedCubeName == "14"))
        {
            gameObject.GetComponent<Renderer>().material = yellowMat;
        }
        else if (cubeNum == "42" && (mousedCubeName == "16" || mousedCubeName == "17" || mousedCubeName == "19" || mousedCubeName == "20" || mousedCubeName == "21"))
        {
            gameObject.GetComponent<Renderer>().material = yellowMat;
        }
        else if (cubeNum == "64" && (mousedCubeName == "19" || mousedCubeName == "20" || mousedCubeName == "21" || mousedCubeName == "23" || mousedCubeName == "24"))
        {
            gameObject.GetComponent<Renderer>().material = yellowMat;
        }
        else if (cubeNum == "73" && (mousedCubeName == "35" || mousedCubeName == "37" || mousedCubeName == "38" || mousedCubeName == "39" || mousedCubeName == "40"))
        {
            gameObject.GetComponent<Renderer>().material = yellowMat;
        }
        else if (cubeNum == "74" && (mousedCubeName == "48" || mousedCubeName == "49" || mousedCubeName == "50" || mousedCubeName == "51" || mousedCubeName == "52"))
        {
            gameObject.GetComponent<Renderer>().material = yellowMat;
        }
        else if (cubeNum == "86" && (mousedCubeName == "57" || mousedCubeName == "58" || mousedCubeName == "59" || mousedCubeName == "60" || mousedCubeName == "61" || mousedCubeName == "62"))
        {
            gameObject.GetComponent<Renderer>().material = yellowMat;
        }
        else if (cubeNum == "91" && (mousedCubeName == "70" || mousedCubeName == "71" || mousedCubeName == "72" || mousedCubeName == "73" || mousedCubeName == "74" || mousedCubeName == "75"))
        {
            gameObject.GetComponent<Renderer>().material = yellowMat;
        }
        else if (cubeNum == "98" && (mousedCubeName == "78" || mousedCubeName == "79" || mousedCubeName == "80" || mousedCubeName == "81" || mousedCubeName == "82"))
        {
            gameObject.GetComponent<Renderer>().material = yellowMat;
        }
        else if (cubeNum == "07" && (mousedCubeName == "05" || mousedCubeName == "06")) //Snakes
        {
            gameObject.GetComponent<Renderer>().material = yellowMat2;
        }
        else if (cubeNum == "07" && (mousedCubeName == "01" || mousedCubeName == "02" || mousedCubeName == "04" || mousedCubeName == "08" || mousedCubeName == "09" || mousedCubeName == "10"))
        {
            gameObject.GetComponent<Renderer>().material = yellowMat;
        }
        else if (cubeNum == "13" && mousedCubeName == "12")
        {
            gameObject.GetComponent<Renderer>().material = yellowMat2;
        }
        else if (cubeNum == "13" && (mousedCubeName == "07" || mousedCubeName == "08" || mousedCubeName == "09" || mousedCubeName == "10" || mousedCubeName == "13" || mousedCubeName == "14" || mousedCubeName == "16" || mousedCubeName == "17"))
        {
            gameObject.GetComponent<Renderer>().material = yellowMat;
        }
        else if (cubeNum == "12" && (mousedCubeName == "23" || mousedCubeName == "24" || mousedCubeName == "26" || mousedCubeName == "27"))
        {
            gameObject.GetComponent<Renderer>().material = yellowMat;
        }
        else if (cubeNum == "34" && (mousedCubeName == "30" || mousedCubeName == "31" || mousedCubeName == "32" || mousedCubeName == "33"))
        {
            gameObject.GetComponent<Renderer>().material = yellowMat2;
        }
        else if (cubeNum == "34" && (mousedCubeName == "29" || mousedCubeName == "35"))
        {
            gameObject.GetComponent<Renderer>().material = yellowMat;
        }
        else if (cubeNum == "16" && (mousedCubeName == "71" || mousedCubeName == "72" || mousedCubeName == "73" || mousedCubeName == "74" || mousedCubeName == "75"))
        {
            gameObject.GetComponent<Renderer>().material = yellowMat;
        }
        else if (cubeNum == "26" && (mousedCubeName == "42" || mousedCubeName == "43" || mousedCubeName == "44" || mousedCubeName == "45" || mousedCubeName == "46"))
        {
            gameObject.GetComponent<Renderer>().material = yellowMat;
        }
        else if (cubeNum == "39" && (mousedCubeName == "78" || mousedCubeName == "79" || mousedCubeName == "80" || mousedCubeName == "81" || mousedCubeName == "82"))
        {
            gameObject.GetComponent<Renderer>().material = yellowMat;
        }
        else if (cubeNum == "75" && (mousedCubeName == "86" || mousedCubeName == "87" || mousedCubeName == "88" || mousedCubeName == "89" || mousedCubeName == "90" || mousedCubeName == "91"))
        {
            gameObject.GetComponent<Renderer>().material = yellowMat;
        }
        else if (cubeNum == "70" && (mousedCubeName == "93" || mousedCubeName == "94" || mousedCubeName == "95" || mousedCubeName == "96" || mousedCubeName == "97" || mousedCubeName == "98"))
        {
            gameObject.GetComponent<Renderer>().material = yellowMat;
        }
        else if (meBlue && mousedCubeName == "100") //YOU WIN!!!
        {
            gameObject.GetComponent<Renderer>().material = greenMat;
        }
        else if (meBlue && cubeNum != "03" && cubeNum != "15" && cubeNum != "22" && cubeNum != "25" && cubeNum != "41" && cubeNum != "53" && cubeNum != "63" && cubeNum != "76" && cubeNum != "84"
            && cubeNum != "11" && cubeNum != "18" && cubeNum != "28" && cubeNum != "36" && cubeNum != "77" && cubeNum != "47" && cubeNum != "83" && cubeNum != "92" && cubeNum != "99")
        {
            gameObject.GetComponent<Renderer>().material = blueMat;
        }
        else
        {
            gameObject.GetComponent<Renderer>().material = defaultMaterial;
        }
    }
}
