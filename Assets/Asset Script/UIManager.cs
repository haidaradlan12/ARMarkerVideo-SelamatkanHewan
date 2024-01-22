using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    public RectTransform MenuUtamaKanan, MenuUtamaKiri, MenuInfopetKanan, MenuInfopetKiri, MenuUtama, MenuUtamaGm, MenuInformasi, MenuPetunjuk;
    // Start is called before the first frame update
    void Start()
    {
        MenuUtama.DOAnchorPos(new Vector2(0,0), 1.0f);
        MenuUtamaKanan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuUtamaKiri.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuUtamaGm.DOAnchorPos(new Vector2(0, 0), 1.0f);

        MenuInformasi.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuInfopetKanan.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuInfopetKiri.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
    }
    public void MenuKembalibutton()
    {
        MenuUtama.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuUtamaKanan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuUtamaKiri.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuUtamaGm.DOAnchorPos(new Vector2(0, 0), 1.0f);

        MenuInformasi.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuInfopetKanan.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuInfopetKiri.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
    }
    public void MenuInformasibutton()
    {
        MenuUtama.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuUtamaKanan.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuUtamaKiri.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuUtamaGm.DOAnchorPos(new Vector2(0, -2500), 1.0f);

        MenuInformasi.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuInfopetKanan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuInfopetKiri.DOAnchorPos(new Vector2(0, 0), 1.0f);
    }
    public void MenuPetunjukbutton()
    {
        MenuUtama.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuUtamaKanan.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuUtamaKiri.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuUtamaGm.DOAnchorPos(new Vector2(0, -2500), 1.0f);

        MenuInformasi.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuInfopetKanan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuInfopetKiri.DOAnchorPos(new Vector2(0, 0), 1.0f);
    }
    public void MenuARbutton()
    {
        MenuUtama.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuUtamaKanan.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuUtamaKiri.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuUtamaGm.DOAnchorPos(new Vector2(0, -2500), 1.0f);

        MenuInformasi.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuInfopetKanan.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuInfopetKiri.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
    }

}
