using System.Collections;
using UnityEngine;

public class Test_3 : MonoBehaviour
{
    public GameObject cube1, cube2, cube3;
    public MeshRenderer rend1, rend2, rend3;
    public Color greenColor, yellowColor, redColor;

    void Start()
    {
        rend1 = cube1.GetComponent<MeshRenderer>();
        rend2 = cube2.GetComponent<MeshRenderer>();
        rend3 = cube3.GetComponent<MeshRenderer>();

        StartCoroutine(TrafficLightCycle());
    }

    IEnumerator TrafficLightCycle()
    {

    Color dimGreen = greenColor * 0.2f;
    Color dimYellow = yellowColor * 0.2f;
    Color dimRed = redColor * 0.2f;

        while (true)
        {
            // GREEN ON
            rend1.material.color = greenColor;
            rend1.material.SetColor("_EmissionColor", greenColor * 5f);

            rend2.material.color = dimYellow;
            rend2.material.SetColor("_EmissionColor", Color.black);

            rend3.material.color = dimRed;
            rend3.material.SetColor("_EmissionColor", Color.black);

            yield return new WaitForSeconds(5f);

            // YELLOW ON
            rend1.material.color = dimGreen;
            rend1.material.SetColor("_EmissionColor", Color.black);

            rend2.material.color = yellowColor;
            rend2.material.SetColor("_EmissionColor", yellowColor * 5f);

            rend3.material.color = dimRed;
            rend3.material.SetColor("_EmissionColor", Color.black);

            yield return new WaitForSeconds(2f);

            // RED ON
            rend1.material.color = dimGreen;
            rend1.material.SetColor("_EmissionColor", Color.black);

            rend2.material.color = dimYellow;
            rend2.material.SetColor("_EmissionColor", Color.black);

            rend3.material.color = redColor;
            rend3.material.SetColor("_EmissionColor", redColor * 5f);

            yield return new WaitForSeconds(5f);
        }

    }
}
