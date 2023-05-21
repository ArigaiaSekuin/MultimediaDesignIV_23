using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Variables_Methods : MonoBehaviour
{
    
    public int MyInt = 8;
    public float MyFloat = 1.4f;
    public string MyString = "Heyyyy";
    public bool MyBool = true;

    public Vector3 MyVector;
    public Color MyColor;
     
    public GameObject MyGameObject;
    public Camera MyCamera;
    

    // Start is called before the first frame update
    public void Start()
    {
        //MyInt = 10;
    }

    // Update is called once per frame
    void Update()
    {
        MyMethodName();
    }

    
    public void MyMethodName()
    {
        MyInt = 10;
        MyInt = MyInt + 1;
        MyString = "Ciaociao";
    }



    


}
