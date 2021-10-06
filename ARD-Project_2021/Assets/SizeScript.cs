using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeScript : MonoBehaviour
{
    //public int's for controlling the different dimensions of the "room" box.
    //private int x;
    public float Width;
    public float Length;
    public float Height;

    public GameObject plane; //Lets the script select the plane mesh through unity

    //refers to tags for controlling attributes of the walls
    private GameObject WallLength;

    //4 Different walls defined, this is so that each can be set to a specific position relative to the plane
    private GameObject WallOne;
    private GameObject WallTwo;
    private GameObject WallThree;
    private GameObject WallFour;

    // Start is called before the first frame update
    void Start(){
        //Calling Gameobjects from unity and defining them as variables
        WallOne = GameObject.Find("WallOne");
        WallTwo = GameObject.Find("WallTwo");
        WallThree = GameObject.Find("WallThree");
        WallFour = GameObject.Find("WallFour");

    }

    // Update is called once per frame
    void Update(){

        //float x = target.transform.localScale.x * Width (using x, to convert to int);
        plane.transform.localScale = new Vector3(0 + Width * 0.2f, 1, 0 + Length * 0.2f);
        //In unity 1m = 0.2 units, therefore we calculate the inserted number times 0.2f. The result will be that 1 unit = 1m

        //#Room Length# Parallel scaling for Wall 1 & 3
        WallOne.transform.localScale = new Vector3(0.1f, 0 + Height, 0 + Length * 2f + 0.1f); // + 0.1f to account for the thickness of the wall
        WallOne.transform.position = new Vector3(0 + Width, 0 + Height/2, 0);

        WallThree.transform.localScale = new Vector3(0.1f, 0 + Height, 0 + Length * 2f + 0.1f);
        WallThree.transform.position = new Vector3(0 - Width, 0 + Height/2, 0); //#Room Length End#

        //#Room Width# Parallel scaling for Wall 2 & 4
        WallTwo.transform.localScale = new Vector3(0 + Width * 2f - 0.1f, 0 + Height, 0.1f);
        WallTwo.transform.position = new Vector3(0, 0 + Height/2, 0 + Length);

        WallFour.transform.localScale = new Vector3(0 + Width * 2f - 0.1f, 0 + Height, 0.1f);
        WallFour.transform.position = new Vector3(0, 0 + Height/2, 0 - Length); //#Room Width End#




    }
}
