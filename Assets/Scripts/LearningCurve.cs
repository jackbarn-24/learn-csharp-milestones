using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
  public int Var1 = 7;
  public float Var2 = 8.0f;
  public string FirstName = "Jack";
  public string LastName = "Barnett";
  public bool Var4 = true;
  public int[] arr = {1,2,3};
  public List<string> lst = new List<string>(5);
  public Dictionary<string, int> dict = new Dictionary<string, int>();
  //single line comment
  /* multi
  line
  comment */
  /// <summary> This is a summary comment.
  public int Add(int Number)
  {
    return Number+1;
  }

    // Start is called before the first frame update
    void Start()
    {
      lst.Add("one");
      lst.Add("two");
      dict.Add("one", 1);
      dict.Add("two", 2);
      for(int i=0;i<2;i++){
        Debug.Log(lst[i]);
      }
      foreach (string number in lst){
        Debug.Log($"{number}");
      }
      foreach (var i in dict){
        Debug.LogFormat("Key: {0}, Value: {1}", i.Key, i.Value);
      }
      string Name = FirstName + " " + LastName;
      string greeting = $"Hello, {Name}";
      Debug.Log(Var1);
      Debug.LogFormat("Hey this number should be 8: {0}", Var2);
      Debug.LogFormat("Add one to {0}, and you get {1}", Var1, Add(Var1));
      if(Var4 == true){
      }
      else if(Var4 == !true){
        if(Var1 == 7){
        }
      }
      else{
      }

      switch(Var1){
        case 3:
          break;
        case 7:
          break;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
