using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
  public Transform CamTransform;
  public GameObject DirectionLight;
  public Transform LightTransform;

    // Start is called before the first frame update
    void Start()
    {
      CamTransform = this.GetComponent<Transform>();
      DirectionLight = GameObject.Find("Directional Light");
      Character hero = new Character("Brad");
      Character heroine = new Character("Shenine");
      Weapon huntingBow = new Weapon("Hunting Bow", 105);
      Paladin knight = new Paladin("Sir Arthur", huntingBow);
      Weapon warBow = new Weapon("War Bow", 20);
      hero.PrintStatsInfo();
      huntingBow.PrintWeaponStats();
      warBow.PrintWeaponStats();
      heroine.PrintStatsInfo();
      knight.PrintStatsInfo();
      Debug.Log(CamTransform.localPosition);
      LightTransform = DirectionLight.GetComponent<Transform>();
      Debug.Log(LightTransform.localPosition);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
