using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
	public GameObject player;
    public GameObject ovObj;
    OverlapWFC ov;
    public Slider sliderX;
    public Slider sliderY;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ov = ovObj.GetComponent<OverlapWFC>();
        ov.seed = Random.Range(1, 1000000);
        ov.Run();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void regenerate1()
    {
        float x1 = sliderX.value, y1 = 0;
        float x2 = 49, y2 = sliderY.value;
        float x, y;
        int seed = Random.Range(1, 1000000);
        ov.seed = seed;
        List<Transform> clones = ovObj.GetComponentsInChildren<Transform>().Where(t => t.tag != "wfc").ToList();
		foreach (Transform t in clones)
		{
            x = t.transform.localPosition.x;
            y = t.transform.localPosition.y;
			if (x >= x1 && x <= x2 && y >= y1 && y <= y2)
			{
				Destroy(t.gameObject);
			}
		}
		ov.regenerateBlock(x1, y1, x2, y2);
	}

	public void regenerate2()
	{
		float x1 = 0, y1 = 0;
		float x2 = sliderX.value, y2 = sliderY.value;
		float x, y;
		int seed = Random.Range(1, 1000000);
		ov.seed = seed;
		List<Transform> clones = ovObj.GetComponentsInChildren<Transform>().Where(t => t.tag != "wfc").ToList();
		foreach (Transform t in clones)
		{
			x = t.transform.localPosition.x;
			y = t.transform.localPosition.y;
			if (x >= x1 && x <= x2 && y >= y1 && y <= y2)
			{
				Destroy(t.gameObject);
			}
		}
		ov.regenerateBlock(x1, y1, x2, y2);
	}

	public void regenerate3()
	{
		float x1 = sliderX.value, y1 = sliderY.value;
		float x2 = 49, y2 = 49;
		float x, y;
		int seed = Random.Range(1, 1000000);
		ov.seed = seed;
		List<Transform> clones = ovObj.GetComponentsInChildren<Transform>().Where(t => t.tag != "wfc").ToList();
		foreach (Transform t in clones)
		{
			x = t.transform.localPosition.x;
			y = t.transform.localPosition.y;
			if (x >= x1 && x <= x2 && y >= y1 && y <= y2)
			{
				Destroy(t.gameObject);
			}
		}
		ov.regenerateBlock(x1, y1, x2, y2);
	}

	public void regenerate4()
	{
		float x1 = 0, y1 = sliderY.value;
		float x2 = sliderX.value, y2 = 49;
		float x, y;
		int seed = Random.Range(1, 1000000);
		ov.seed = seed;
		List<Transform> clones = ovObj.GetComponentsInChildren<Transform>().Where(t => t.tag != "wfc").ToList();
		foreach (Transform t in clones)
		{
			x = t.transform.localPosition.x;
			y = t.transform.localPosition.y;
			if (x >= x1 && x <= x2 && y >= y1 && y <= y2)
			{
				Destroy(t.gameObject);
			}
		}
		ov.regenerateBlock(x1, y1, x2, y2);
	}

	public void monter()
	{
		player.transform.position = new Vector3(-52.2f, 6, -23);
	}

	public void descendre()
	{
		player.transform.position = new Vector3(-51, 0.5f, -26.5f);
	}
}
