using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ColorTurn : MonoBehaviour
{
    [SerializeField] Image TurnObject;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("TurnColor");
    }
    IEnumerator TurnColor(){
        while(true){
            yield return StartCoroutine(ChangeColor(Color.red, 1f));
            yield return StartCoroutine(ChangeColor(Color.green, 1f));
            yield return StartCoroutine(ChangeColor(Color.blue, 1f));
        }
    }
    IEnumerator ChangeColor(Color toColor, float duration){
        Color fromColor = TurnObject.color;
        float endTime = Time.time + duration;

        float marginR = toColor.r - fromColor.r;
        float marginG = toColor.g - fromColor.g;
        float marginB = toColor.b - fromColor.b;


        while (Time.time < endTime){
            fromColor.r += Time.deltaTime / duration * marginR;
            fromColor.g += Time.deltaTime / duration * marginG;
            fromColor.b += Time.deltaTime / duration * marginB;

            TurnObject.color = fromColor;

            yield return null;
        }

        TurnObject.color = toColor;

        yield break;
    }

}
