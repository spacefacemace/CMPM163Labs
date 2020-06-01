using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildCity : MonoBehaviour
{
    public GameObject[] buildings;
    public int mapWidth = 20;
    public int mapHeight = 20;
    //int buildingFootprint = Random.Range(0, 6); //6;

    // Start is called before the first frame update
    void Start()
    {
        float seed = Random.Range(0, 100);
        for (int h = 0; h < mapHeight; h += Random.Range(1, 2))
        {
            for (int w = 0; w < mapWidth; w += Random.Range(1, 2))
            {
                //int result = (int)(Mathf.PerlinNoise(w / 20.0f + seed, h / 20.0f + seed) * 10);
               
                // Vector3 pos = new Vector3(w * buildingFootprint, 0, h * buildingFootprint);
                Vector3 pos = new Vector3(w * Random.Range(0, 6), 0, h * Random.Range(0, 6));
                //if (result <= 1)
                //    Instantiate(buildings[0], pos, Quaternion.identity);
                //else if (result < 2)
                //    Instantiate(buildings[1], pos, Quaternion.identity);
                //else if (result < 3)
                //    Instantiate(buildings[2], pos, Quaternion.identity);
                //else if (result < 4)
                //    Instantiate(buildings[3], pos, Quaternion.identity);
                //else if (result < 5)
                //    Instantiate(buildings[4], pos, Quaternion.identity);
                //else if (result < 6)
                //    Instantiate(buildings[5], pos, Quaternion.identity);
                //else if (result < 7)
                //    Instantiate(buildings[6], pos, Quaternion.identity);
                //else if (result < 8)
                //    Instantiate(buildings[7], pos, Quaternion.identity);
                //else if (result < 9)
                //    Instantiate(buildings[8], pos, Quaternion.identity);
                //else if (result <= 10)
                //    Instantiate(buildings[9], pos, Quaternion.identity);


                int result = (int)(Mathf.PerlinNoise(w / 10.0f + seed, h / 10.0f + seed) * 10);
                Debug.Log(result);
                //Vector3 pos = new Vector3(w * buildingFootprint, 0, h * buildingFootprint);
                if (result < 2)
                    Instantiate(buildings[0], pos, Quaternion.identity);
                else if (result < 4)
                    Instantiate(buildings[1], pos, Quaternion.identity);
                else if (result < 5)
                    Instantiate(buildings[2], pos, Quaternion.identity);
                else if (result < 6)
                    Instantiate(buildings[3], pos, Quaternion.identity);
                else if (result < 7)
                    Instantiate(buildings[4], pos, Quaternion.identity);
                else if (result < 10)
                    Instantiate(buildings[5], pos, Quaternion.identity);
            }
        }

    }

}

//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class buildCity : MonoBehaviour
//{
//    public GameObject[] buildings;
//    public int mapWidth = 20;
//    public int mapHeight = 20;
//    int buildingFootprint = 3;

//    // Start is called before the first frame update
//    void Start()
//    {
//        float seed = Random.Range(0, 100);
//        for (int h = 0; h < mapHeight; h++)
//        {
//            for (int w = 0; w < mapWidth; w++)
//            {
//                int result = (int)(Mathf.PerlinNoise(w / 10.0f + seed, h / 10.0f + seed) * 10);
//                Vector3 pos = new Vector3(w * buildingFootprint, 0, h * buildingFootprint);
//                if (result < 2)
//                    Instantiate(buildings[0], pos, Quaternion.identity);
//                else if (result < 4)
//                    Instantiate(buildings[1], pos, Quaternion.identity);
//                else if (result < 5)
//                    Instantiate(buildings[2], pos, Quaternion.identity);
//                else if (result < 6)
//                    Instantiate(buildings[3], pos, Quaternion.identity);
//                else if (result < 7)
//                    Instantiate(buildings[4], pos, Quaternion.identity);
//                else if (result < 10)
//                    Instantiate(buildings[5], pos, Quaternion.identity);
//            }
//        }

//    }

//    // Update is called once per frame
//    //void Update()
//    //{

//    //}
//}
