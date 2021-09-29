using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeScript : MonoBehaviour
{
    //public int's for controlling the different dimensions of the "room" box.
    private float x;
    public float Width;
    public float Length;
    public float Height;
    public GameObject target;
    // Start is called before the first frame update
    void Start(){
    }

    // Update is called once per frame
    void Update(){
        //float x = target.transform.localScale.x * Width;
        target.transform.localScale = new Vector3(0 + Width, 8, 40);
    }
}
