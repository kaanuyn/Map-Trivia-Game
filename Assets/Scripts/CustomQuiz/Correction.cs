using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Correction : MonoBehaviour
{
    // Bu script doğru cevabı ayarlamak için vardı ama şu an sadece doğru cevabı seçmek için ayarladığınızda seçeneğin rengini yeşil diğerlerini kırmızı yapıyor başka bir işlevi yok.
    // consolde da uyarı çıkıcak ama önemli değil unity içerisinden çağırıyoruz voidleri
    private bool aiscorrect = false;
    private bool biscorrect = false;
    private bool ciscorrect = false;
    private bool discorrect = false;

    public Button ButtonA;
    public Button ButtonB;
    public Button ButtonC;
    public Button ButtonD;

    public void A()
    {
        aiscorrect = true;
        biscorrect = false;
        ciscorrect = false;
        discorrect = false;
        ButtonA.GetComponent<Image>().color = Color.green;
        ButtonB.GetComponent<Image>().color = Color.red;
        ButtonC.GetComponent<Image>().color = Color.red;
        ButtonD.GetComponent<Image>().color = Color.red;

    }
    public void B()
    {
        aiscorrect = false;
        biscorrect = true;
        biscorrect = false;
        biscorrect = false;
        ButtonA.GetComponent<Image>().color = Color.red;
        ButtonB.GetComponent<Image>().color = Color.green;
        ButtonC.GetComponent<Image>().color = Color.red;
        ButtonD.GetComponent<Image>().color = Color.red;

    }
    public void C()
    {
        aiscorrect = false;
        biscorrect = false;
        ciscorrect = true;
        discorrect = false;
        ButtonA.GetComponent<Image>().color = Color.red;
        ButtonB.GetComponent<Image>().color = Color.red;
        ButtonC.GetComponent<Image>().color = Color.green;
        ButtonD.GetComponent<Image>().color = Color.red;

    }
    public void D()
    {
        aiscorrect = false;
        biscorrect = false;
        ciscorrect = false;
        discorrect = true;
        ButtonA.GetComponent<Image>().color = Color.red;
        ButtonB.GetComponent<Image>().color = Color.red;
        ButtonC.GetComponent<Image>().color = Color.red;
        ButtonD.GetComponent<Image>().color = Color.green;

    }

}
