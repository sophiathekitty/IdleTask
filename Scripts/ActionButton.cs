using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(Button))]
[AddComponentMenu("Actions/Buttion")]
public class ActionButton : MonoBehaviour {
    public ActionLevel level;
    public TextMeshProUGUI text;
    public TextMeshProUGUI count_txt;
    public Image bar;
    public Image icon;
    private Button button;
    private AudioSource audioSource;
    private float cooldown = 0f;
    private Image background;
    public int click_count = 0;
    // Use this for initialization
    void Start() {
        button = GetComponent<Button>();
        audioSource = GetComponent<AudioSource>();
        ApplyLevel();
        Debug.Log(level.sound.length);
    }
    void ApplyLevel() { 
        bar.color = level.cooldown;
        background = button.GetComponent<Image>();
        background.color = level.background;
        text.color = level.text;
        icon.color = level.text;
	}
	
	// Update is called once per frame
	void Update () {
        ApplyLevel();
        cooldown -= Time.deltaTime;
        if (cooldown > 0)
            button.enabled = false;
        else
        {
            button.enabled = true;
            cooldown = 0;
        }
        if(cooldown > 0)
            bar.rectTransform.localScale = new Vector3(cooldown/level.cooldownTime, cooldown / level.cooldownTime, 1);
        else
            bar.rectTransform.localScale = new Vector3(0, 0, 1);
        count_txt.text = click_count.ToString();
    }

    public void OnButtonClick()
    {
        audioSource.PlayOneShot(level.sound);
        cooldown = level.cooldownTime;
        click_count++;
    }
}
