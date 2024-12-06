using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cycle : MonoBehaviour
{
    [SerializeField] Slider slider;
    [SerializeField] GameObject light_sun;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            switch (slider.value)
            {
                case 0:
                    slider.value = 1;
                    light_sun.transform.rotation = Quaternion.Euler(8, -30, 0);
                    break;
                case 1:
                    slider.value = 2;
                    light_sun.transform.rotation = Quaternion.Euler(-50, -30, 0);
                    break;
                case 2:
                    slider.value = 0;
                    light_sun.SetActive(true);
                    light_sun.transform.rotation = Quaternion.Euler(130, -30, 0);
                    break;
            }
                
        }
    }
}
