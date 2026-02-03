using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TvLogic : MonoBehaviour
{
    [Header("Настройки питания")]
    public Toggle electricToggle;    // Сюда перетащи Toggle (Розетка)
    private bool isTvOn = false;     // Внутренняя переменная состояния кнопки ТВ

    [Header("Объекты экрана")]
    public GameObject TV_display;    // Сюда перетащи черный экран (заставку)
    public GameObject channelsParent; // Сюда перетащи родительский объект персонажей

    [Header("Каналы (Dropdown)")]
    public TMP_Dropdown channelDropdown; // Сюда перетащи Dropdown
    public GameObject channel1;         // Сюда перетащи Полицейского
    public GameObject channel2;         // Сюда перетащи Машину

    [Header("Звук (Slider)")]
    public Slider volumeSlider;         // Сюда перетащи Slider

    // Вызывается один раз при запуске игры
    void Start()
    {
        // Устанавливаем громкость в соответствии со значением слайдера при старте
        if (volumeSlider != null)
        {
            AudioListener.volume = volumeSlider.value;
        }

        // Обновляем состояние ТВ, чтобы всё было выключено правильно
        ApplyTvState();
    }

    // 1. Метод для Слайдера (Динамический float)
    public void ChangeVolume(float value)
    {
        AudioListener.volume = value;
    }

    // 2. Метод для Дропдауна (Динамический int)
    public void ChangeChannel(int index)
    {
        if (channel1 != null) channel1.SetActive(index == 0);
        if (channel2 != null) channel2.SetActive(index == 1);
    }

    // 3. Метод для Кнопки питания (Button OnClick)
    public void ClickPowerButton()
    {
        // Включаем ТВ только если есть электричество
        if (electricToggle != null && electricToggle.isOn)
        {
            isTvOn = !isTvOn;
        }
        else
        {
            isTvOn = false;
        }
        ApplyTvState();
    }

    // 4. Метод для Тогла электричества (Динамический bool)
    public void OnElectricToggleChanged(bool hasPower)
    {
        if (!hasPower)
        {
            isTvOn = false; // Если выключили ток, ТВ гаснет
        }
        ApplyTvState();
    }

    // 5. Главная логика отображения
    private void ApplyTvState()
    {
        // Проверяем: есть ли ток И нажата ли кнопка на самом ТВ
        bool works = isTvOn && (electricToggle != null && electricToggle.isOn);

        if (works)
        {
            // ТВ РАБОТАЕТ
            if (channelsParent != null) channelsParent.SetActive(true);
            if (TV_display != null) TV_display.SetActive(false); // Скрываем черный экран
            
            // Обновляем текущий выбранный канал
            if (channelDropdown != null) ChangeChannel(channelDropdown.value);
        }
        else
        {
            // ТВ ВЫКЛЮЧЕН
            if (channelsParent != null) channelsParent.SetActive(false);
            if (TV_display != null) TV_display.SetActive(true); // Показываем черный экран
        }
    }
}