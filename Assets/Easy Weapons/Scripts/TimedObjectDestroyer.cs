/// <summary>
/// TimedObjectDestroyer.cs
/// Author: MutantGopher
/// This script destroys a GameObject after the number of seconds specified in
/// the lifeTime variable.  Useful for things like explosions and rockets.
/// </summary>

using UnityEngine;
using System.Collections;

public class TimedObjectDestroyer : MonoBehaviour
{
	public float lifeTime = 10.0f;

    /*
    public string objectType;
    public static int destroyNum = 0;

    private GUIStyle guiStyle = new GUIStyle();
     * */


	// Use this for initialization
	void Start()
	{
		Destroy(gameObject, lifeTime);

        /*
        if (!GameObject.Find("enemy"))
        {
            if (objectType == "enemy")
            {
                destroyNum++;
            }
        }
         * */

    }

    /*
    void OnGUI()
    {
        guiStyle.fontSize = 120;
        guiStyle.normal.textColor = new Color(255f / 256f, 164f / 256f, 0f / 256f, 255f / 256f);
        if (objectType == "enemy")
        {
            GUI.Label(new Rect(320, 300, 100, 20), "×" + destroyNum, guiStyle);
        }

    }
     * */


}
