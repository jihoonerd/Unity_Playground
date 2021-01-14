using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Newtonsoft.Json;

public class JSONReader : MonoBehaviour
{
    public string folderPath;
    private int curIndex;
    const int totalJoint = 49;
    GameObject[] jointList = new GameObject[totalJoint];
    public GameObject jointPrefab;
    string [] fileEntries;
    public List<List<float>> jointPos = new List<List<float>>();
    // Start is called before the first frame update
    void Start()
    {
        fileEntries = Directory.GetFiles(folderPath, "*.json"); // Read files from given path
        curIndex = 0; // Initialize starting index
        JSONData parsed = processJSONFile(fileEntries[0]);
        curIndex++;

        jointPos = parsed.pred_joints_img;
        for (int i = 0; i < totalJoint; i++)
        {
            jointList[i] = Instantiate(jointPrefab, new Vector3(jointPos[i][0], jointPos[i][1], jointPos[i][2]), jointPrefab.transform.rotation);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (curIndex < fileEntries.Length)
        {
            JSONData parsed = processJSONFile(fileEntries[curIndex]);
            jointPos = parsed.pred_joints_img;
            for (int i = 0; i < totalJoint; i++)
            {
                jointList[i].transform.position = new Vector3(jointPos[i][0], jointPos[i][1], jointPos[i][2]);
            }
            curIndex++;
        }
        if (curIndex == fileEntries.Length)
        {
            curIndex = 1;
        }
        Debug.Log(curIndex);
    }

    JSONData processJSONFile(string fileName)
    {
       StreamReader reader = new StreamReader(fileName);
       string readString = reader.ReadToEnd();
       reader.Close();
       JSONData parsed = JsonConvert.DeserializeObject<JSONData>(readString);
       return parsed;
    }
}
