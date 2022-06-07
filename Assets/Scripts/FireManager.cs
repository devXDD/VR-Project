using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using Firebase;
using Firebase.Auth;
using Firebase.Database;
using TMPro;
using System.Linq;

public class FireManager : MonoBehaviour
{
    //Firebase variables
    [Header("Firebase")]
    public DependencyStatus dependencyStatus;
    public FirebaseAuth auth;    
    public FirebaseUser User;
    public DatabaseReference DBreference;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Timer.timeLef<1)
        {
            SaveData();
        }
    }

 void Awake()
    {
        //Check that all of the necessary dependencies for Firebase are present on the system
        FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(task =>
        {
            dependencyStatus = task.Result;
            if (dependencyStatus == DependencyStatus.Available)
            {
                //If they are avalible Initialize Firebase
                InitializeFirebase();
            }
            else
            {
                Debug.LogError("Could not resolve all Firebase dependencies: " + dependencyStatus);
            }
        });
    }

 private void InitializeFirebase()
    {
        Debug.Log("Setting up Firebase Auth");
        //Set the authentication instance object
        auth = FirebaseAuth.DefaultInstance;
       DBreference = FirebaseDatabase.DefaultInstance.RootReference;
    }


     public void SaveData()
    {
        User user = new User();
        MetersDemo md = new MetersDemo();
        
     
    //     MetersDemo md = new MetersDemo();
    //    md.speeder = speedTextt.text;
        string json = JsonUtility.ToJson(md);

       

        DBreference.Child("User").Child(md.name).SetRawJsonValueAsync(json).ContinueWith(task => {
             if(task.IsCompleted)
             {
                 Debug.Log("successfully added data");
             }
             else
             {
                 Debug.Log("not successful");
             }
        });
    }
}
