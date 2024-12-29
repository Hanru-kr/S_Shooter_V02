using Unity.Hierarchy;
using UnityEditor.PackageManager.UI;
using UnityEngine;

public class player_move : MonoBehaviour
{
   
    public float Movespeed = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

        // a = -1 
        float xx = Input.GetAxis("Horizontal");
        float zz = Input.GetAxis("Vertical");

        

        //위치 지정
        Vector3 temposs = transform.position;
        //위치 변경
        temposs.x += xx * Movespeed * Time.deltaTime;
        temposs.z += zz * Movespeed * Time.deltaTime;

        this.transform.position = temposs;


    }
}