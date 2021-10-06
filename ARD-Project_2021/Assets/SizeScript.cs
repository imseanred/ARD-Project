using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeScript : MonoBehaviour
{
    //public int's for controlling the different dimensions of the "room" box.
    //private int x;
    public int Width;
    public int Length;
    public int Height;
    public GameObject target;
    // Start is called before the first frame update
    void Start(){
        //explicit conversion of Width from float value to interger
        //int x = (int)Width;
    }

    // Update is called once per frame
    void Update(){

        //float x = target.transform.localScale.x * Width (using x, to convert to int);
        target.transform.localScale = new Vector3(0 + Width, 0 + Height, 0 + Length);
    }
}
