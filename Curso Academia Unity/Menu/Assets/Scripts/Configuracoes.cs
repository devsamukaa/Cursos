using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Configuracoes : MonoBehaviour
{

    public bool     isFullScreen;
    public int      resolutionIndex;
    public int      qualityTexture;
    public float    musicVolume;

    public Toggle       fullScreenToggle;
    public Dropdown     resolutionDropdown, qualityTextureDropDown;
    public Slider       musicVolumeSlider;

    public Resolution[] resolutions;

    private void OnEnable() {
        resolutions = Screen.resolutions;
        foreach (Resolution resolution in resolutions)
        {
            resolutionDropdown.options.Add(new Dropdown.OptionData(resolution.ToString()));
        }

        //o Chamado das funções
        fullScreenToggle.onValueChanged.AddListener(delegate {OnFullScreenToggle();});
        resolutionDropdown.onValueChanged.AddListener(delegate {OnResolutionChange();});
        qualityTextureDropDown.onValueChanged.AddListener(delegate {OnTextureQualityChange();});
        musicVolumeSlider.onValueChanged.AddListener(delegate {OnMusicVolumeChange();});
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnFullScreenToggle()
    {
        Screen.fullScreen = fullScreenToggle.isOn;
        OnResolutionChange();
    }

    public void OnResolutionChange()
    {
        Screen.SetResolution(resolutions[resolutionDropdown.value].width, resolutions[resolutionDropdown.value].height, fullScreenToggle.isOn);
    }

    public void OnTextureQualityChange()
    {
        QualitySettings.SetQualityLevel(qualityTextureDropDown.value);
    }

    public void OnMusicVolumeChange()
    {

    }
}
