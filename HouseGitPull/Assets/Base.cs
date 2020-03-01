using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{
    public GameObject Cubee;
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {

            for (int a = 0; a < 5; a++)
            {
                Instantiate(Cubee, new Vector3(a, i, 0), Quaternion.identity);//backWall
                Instantiate(Cubee, new Vector3(0, i, a), Quaternion.identity);//LeftWall
                Instantiate(Cubee, new Vector3(a, i, 5), Quaternion.identity);//FrontWall
                Instantiate(Cubee, new Vector3(i, 0, a), Quaternion.identity);//Floor
            }

        }
        for (int z = 0; z < 5; z++)
        {

            for (int x = 0; x < 6; x++)
            {
                Instantiate(Cubee, new Vector3(5, z, x), Quaternion.identity);//RightWall
            }

        }
    }


}
