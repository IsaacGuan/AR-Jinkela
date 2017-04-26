using UnityEngine;
using System.Collections;

public class QuitGame : MonoBehaviour {

    int escapeTimes = 1;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Escape))
        {
            GUI.Label(new Rect(450, 180, 100, 20), "再按一次退出");
            escapeTimes++;

            StartCoroutine("resetTimes");
            if (escapeTimes > 1)
            {
                Application.Quit();
            }
        }
	}

    IEnumerator resetTimes()
    {
        yield return new WaitForSeconds(1);
        escapeTimes = 1;
    }

}
