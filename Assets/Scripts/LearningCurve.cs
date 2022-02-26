using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public int speed = 5;
    public float accelaration = 2.5f;
    public string name = "Jerry";
    private bool alive = true;
    public Transform CamTransform;
    public GameObject DirectionLight;
    public Transform LightTransform;

    // Single Line Comment
    /*
    multiline
    comment
    */
    ///<summary>
    ///summary comment
    ///</summary>
    public int[] Scores = {96, 90, 93};
    public List<string> Friends = new List<string>()
    {
        "Russell",
        "Terry",
        "Jack"
    };
    public Dictionary<string, int> FriendAge = new Dictionary<string,int>()
    {
        { "Russell", 20},
        { "Terry", 19},
        { "Jack", 18}
    };
    public string FullName(string LastName)
    {
      return name+LastName;
    }



    void Start()
    {
      Debug.Log(speed);
      Debug.Log(name+name);
      Debug.Log($"My name is {name}");
      Debug.LogFormat("My name is {0}", name);
      Debug.Log(FullName("Li"));

      if (alive){
        Debug.Log("alive");
      }
      else if (speed == 6) {
        Debug.Log("6");
        if(name == "Jerry"){
          Debug.Log("Jerry6");
        }
      }
      else{
        Debug.Log("Wrong");
      }

      switch(name)
      {
      case "Jerry":
        Debug.Log("Jerry is Here");
        break;
      case "Toffy":
        Debug.Log("Toffy is Here");
        break;
      default:
        Debug.Log("Someone else is Here");
        break;
      }

      for (int i = 0; i < Friends.Count; i++)
      {
          Debug.LogFormat("Name: {0} - {1}", i, Friends[i]);
      }

      foreach(string name in Friends)
      {
          Debug.Log(name);
      }

      foreach(KeyValuePair<string, int> name_age in FriendAge)
      {
           Debug.LogFormat("{0} - {1}", name_age.Key, name_age.Value);
      }

      Character heroine = new Character("Toffy");
      Character hero = new Character("Jelli");
      Debug.LogFormat("Hero: {0} - {1} EXP", heroine.name,
        heroine.exp);
      Debug.LogFormat("Hero: {0} - {1} EXP", hero.name,
        hero.exp);

      Weapon huntingBow = new Weapon("Hunting Bow", 105);
      Weapon warBow = new Weapon("War Bow", 200);
      huntingBow.PrintWeaponStats();
      warBow.PrintWeaponStats();

      Paladin knight = new Paladin("Russell", warBow);
      knight.PrintStatsInfo();

      CamTransform = this.GetComponent<Transform>();
      Debug.Log(CamTransform.localPosition);

      DirectionLight = GameObject.Find("Directional Light");
      LightTransform = DirectionLight.GetComponent<Transform>();
      Debug.Log(LightTransform.localPosition);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
